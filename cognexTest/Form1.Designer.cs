namespace cognexTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.State1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.OnLine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CY1 = new System.Windows.Forms.Label();
            this.CX1 = new System.Windows.Forms.Label();
            this.CA1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.QRRes = new System.Windows.Forms.Label();
            this.OKNGBox = new System.Windows.Forms.Label();
            this.Trigger = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(12, 12);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(572, 587);
            this.cvsInSightDisplay1.TabIndex = 0;
            this.cvsInSightDisplay1.ResultsChanged += new System.EventHandler(this.cvsInSightDisplay1_ResultsChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnLine);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.State1);
            this.groupBox1.Location = new System.Drawing.Point(590, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // State1
            // 
            this.State1.AutoSize = true;
            this.State1.Location = new System.Drawing.Point(20, 43);
            this.State1.Name = "State1";
            this.State1.Size = new System.Drawing.Size(85, 18);
            this.State1.TabIndex = 0;
            this.State1.Text = "Vision Off";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vision Mode";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(265, 34);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(103, 37);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // OnLine
            // 
            this.OnLine.Location = new System.Drawing.Point(265, 90);
            this.OnLine.Name = "OnLine";
            this.OnLine.Size = new System.Drawing.Size(103, 34);
            this.OnLine.TabIndex = 3;
            this.OnLine.Text = "OnLine";
            this.OnLine.UseVisualStyleBackColor = true;
            this.OnLine.Click += new System.EventHandler(this.OnLine_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CA1);
            this.groupBox2.Controls.Add(this.CY1);
            this.groupBox2.Controls.Add(this.CX1);
            this.groupBox2.Location = new System.Drawing.Point(590, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 190);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Match";
            // 
            // CY1
            // 
            this.CY1.AutoSize = true;
            this.CY1.Location = new System.Drawing.Point(20, 94);
            this.CY1.Name = "CY1";
            this.CY1.Size = new System.Drawing.Size(31, 18);
            this.CY1.TabIndex = 1;
            this.CY1.Text = "Y :";
            // 
            // CX1
            // 
            this.CX1.AutoSize = true;
            this.CX1.Location = new System.Drawing.Point(20, 43);
            this.CX1.Name = "CX1";
            this.CX1.Size = new System.Drawing.Size(31, 18);
            this.CX1.TabIndex = 0;
            this.CX1.Text = "X :";
            // 
            // CA1
            // 
            this.CA1.AutoSize = true;
            this.CA1.Location = new System.Drawing.Point(20, 141);
            this.CA1.Name = "CA1";
            this.CA1.Size = new System.Drawing.Size(65, 18);
            this.CA1.TabIndex = 2;
            this.CA1.Text = "Angle :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QRRes);
            this.groupBox3.Location = new System.Drawing.Point(590, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QRCode";
            // 
            // QRRes
            // 
            this.QRRes.AutoSize = true;
            this.QRRes.Location = new System.Drawing.Point(173, 36);
            this.QRRes.Name = "QRRes";
            this.QRRes.Size = new System.Drawing.Size(57, 18);
            this.QRRes.TabIndex = 0;
            this.QRRes.Text = "Result";
            // 
            // OKNGBox
            // 
            this.OKNGBox.AutoSize = true;
            this.OKNGBox.Location = new System.Drawing.Point(763, 471);
            this.OKNGBox.Name = "OKNGBox";
            this.OKNGBox.Size = new System.Drawing.Size(64, 18);
            this.OKNGBox.TabIndex = 7;
            this.OKNGBox.Text = "OK/NG";
            // 
            // Trigger
            // 
            this.Trigger.Location = new System.Drawing.Point(701, 521);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(189, 44);
            this.Trigger.TabIndex = 8;
            this.Trigger.Text = "Trigger";
            this.Trigger.UseVisualStyleBackColor = true;
            this.Trigger.Click += new System.EventHandler(this.Trigger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 621);
            this.Controls.Add(this.Trigger);
            this.Controls.Add(this.OKNGBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cvsInSightDisplay1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OnLine;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label State1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CA1;
        private System.Windows.Forms.Label CY1;
        private System.Windows.Forms.Label CX1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label QRRes;
        private System.Windows.Forms.Label OKNGBox;
        private System.Windows.Forms.Button Trigger;
    }
}

