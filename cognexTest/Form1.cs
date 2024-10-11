using Cognex.InSight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cognexTest
{
    public partial class Form1 : Form
    {
        CvsInSight inSight =new CvsInSight();
        bool IsConnected1 =false;//연결상태
        bool OnLineST1;//온오프라인 상태
        bool Result1TF;//테스트 합불
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cvsInSightDisplay1_ResultsChanged(object sender, EventArgs e)
        {
            if (IsConnected1)
            {
                //카메라가 활영한 데이터를 resultSet1에 할당
                Cognex.InSight.CvsResultSet resultSet1 = cvsInSightDisplay1.Results;
                //이미지 결과가 null이 아님
                if (resultSet1.Images != null)
                {
                    try
                    {
                        if (resultSet1.HasNewlyAcquiredImage)
                        {
                            System.Drawing.Bitmap img1 = new System.Drawing.Bitmap(cvsInSightDisplay1.GetBitmap());
                        }
                        RefreshData();//모니터링 결과 새로고침
                    }
                    catch (Exception ex) { }
                }
                //변경된 데이터 업뎃
                cvsInSightDisplay1.AcceptUpdate();
            }
        }

        private void RefreshData()//모니터링 값, 새로고침 시
        {
            try
            {
                var XY_X = cvsInSightDisplay1.Results.Cells["B27"].ToString();
                var XY_Y = cvsInSightDisplay1.Results.Cells["C37"].ToString();
                var angle = cvsInSightDisplay1.Results.Cells["D27"].ToString();

                CX1.Text = "X : " + XY_X.Substring(0, 7);
                CY1.Text = "Y : " + XY_Y.Substring(0, 7);
                CA1.Text = "Angle : "+angle;
                //각도값의 길이보다 7클떄
                if (angle.Length > 7)
                {
                    angle = angle.Substring(7);
                }
                else
                {
                    angle=angle.Substring(0, 6);
                }

                //CX1.Text = "X : " + XY_X.Substring(0, 7);
                //CY1.Text = "Y : " + XY_Y.Substring(0, 7);
                //CA1.Text = "Angle : " + angle;

                //카메라의 스프레드시트에서 해당셀의 데이터를 개체에 할당
                string ResultValue = cvsInSightDisplay1.Results.Cells["B53"].ToString();//QRcode값
                QRRes.Text = ResultValue;

                OKNGBox.Visible = true;

                //QR코드의 값이 yes일때 : 개인마다 다를 수 있음
                if(ResultValue == "YEL")
                {
                    Result1TF=true;
                    OKNGBox.BackColor = System.Drawing.Color.Green;
                    OKNGBox.Text="OK";
                }
                else
                {
                    Result1TF=false;
                    OKNGBox.BackColor = System.Drawing.Color.Red;
                    OKNGBox.Text = "NG";
                }
            }
            catch { }
        }

        private void OnLine_Click(object sender, EventArgs e)
        {
            //카메라 연결시
            if (IsConnected1)
            {
                //카메라가 온라인일때 -> 온라인으로
                if (cvsInSightDisplay1.SoftOnline)
                {
                    cvsInSightDisplay1.SoftOnline = !cvsInSightDisplay1.SoftOnline;
                    OnLine.BackColor = System.Drawing.Color.Red;
                }
                //카메라가 오프라인일때->오프라인으로
                else if(!cvsInSightDisplay1.SoftOnline)
                {
                     cvsInSightDisplay1.SoftOnline= !cvsInSightDisplay1.SoftOnline;
                     OnLine.BackColor= System.Drawing.Color.Green;
                }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //카메라가 연결되지 않은 상태일때
                if (!(IsConnected1))
                {
                    cvsInSightDisplay1.Connect("172.31.6.9","admin","",false);
                    IsConnected1 = true;
                    Connect.Text = "Disconnect";
                    State1.Text = "Vision On";
                    State1.BackColor = System.Drawing.Color.Green;

                    cvsInSightDisplay1.ImageScale = 0.84;//촬영중인 이미지 배율 설정
                    cvsInSightDisplay1.ShowImage = true;//카메라가 취득한 이미지 보여줌
                    cvsInSightDisplay1.ShowGraphics = true;

                    Online_check();
                }
                else//카메라가 연결 상태일 시
                {
                    inSight.Disconnect();//연결되어있던 카메라와의 접속을 끊음
                    IsConnected1= false;
                    Connect.Text = "Connect";
                    State1.Text = "Vision Off";
                    State1.BackColor= System.Drawing.Color.Red;
                    cvsInSightDisplay1.ShowImage= false;
                    cvsInSightDisplay1 .ShowGraphics = false;
                    OnLine.BackColor = System.Drawing.Color.White;

                    ResetFormText_1();
                }
            }
            catch (Exception ex) { }
        }

        private void ResetFormText_1()//모니터링 결과를 새로고침함
        {
            QRRes.Text = "";
            CX1.Text = "X : ";
            CY1.Text = "Y : ";
            CA1.Text = "Angle : ";
            OKNGBox.Visible = false;
        }

        private void Online_check()//카메라 온라인인지 체크
        {
            OnLineST1 = cvsInSightDisplay1.SoftOnline;
            if (OnLineST1 == true)
            {
                OnLine.BackColor= System.Drawing.Color.Green;
                Trigger.Enabled = false;
            }
            else if(OnLineST1 == false)
            {
                OnLine.BackColor=System.Drawing.Color.Red;
                Trigger.Enabled = true;
            }
        }

        private void Trigger_Click(object sender, EventArgs e)
        {
            cvsInSightDisplay1.InSight.ManualAcquire(wait : true);//캡쳐명령 완료까지 대기
        }
    }
}
