namespace ActuatingForce
{
    partial class frmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Comm = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel_Time = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusLaser = new ActuatingForce.StatusLamp();
            this.statusLVDT = new ActuatingForce.StatusLamp();
            this.statusPLC = new ActuatingForce.StatusLamp();
            this.panel2.SuspendLayout();
            this.panel_Time.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Controls.Add(this.btn_Comm);
            this.panel2.Controls.Add(this.btn_History);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Controls.Add(this.btn_Setting);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 45);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 27);
            this.label1.TabIndex = 184;
            this.label1.Text = "SEAT TRACK 작동력 검사";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Home.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Location = new System.Drawing.Point(857, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(77, 35);
            this.btn_Home.TabIndex = 183;
            this.btn_Home.Text = "메인";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_Comm
            // 
            this.btn_Comm.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Comm.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Comm.ForeColor = System.Drawing.Color.Black;
            this.btn_Comm.Location = new System.Drawing.Point(940, 5);
            this.btn_Comm.Name = "btn_Comm";
            this.btn_Comm.Size = new System.Drawing.Size(77, 35);
            this.btn_Comm.TabIndex = 181;
            this.btn_Comm.Text = "통신";
            this.btn_Comm.UseVisualStyleBackColor = false;
            this.btn_Comm.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.Color.DarkGray;
            this.btn_History.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_History.ForeColor = System.Drawing.Color.Black;
            this.btn_History.Location = new System.Drawing.Point(1023, 5);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(92, 35);
            this.btn_History.TabIndex = 180;
            this.btn_History.Text = "이력 조회";
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(1211, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(57, 35);
            this.btn_Exit.TabIndex = 179;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Setting.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Setting.ForeColor = System.Drawing.Color.Black;
            this.btn_Setting.Location = new System.Drawing.Point(1121, 5);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(77, 35);
            this.btn_Setting.TabIndex = 177;
            this.btn_Setting.Text = "설정";
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Location = new System.Drawing.Point(2, 87);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1276, 871);
            this.panelChild.TabIndex = 4;
            // 
            // panel_Time
            // 
            this.panel_Time.BackColor = System.Drawing.Color.Gray;
            this.panel_Time.Controls.Add(this.txtTime);
            this.panel_Time.Controls.Add(this.txtDate);
            this.panel_Time.Location = new System.Drawing.Point(1045, 49);
            this.panel_Time.Name = "panel_Time";
            this.panel_Time.Size = new System.Drawing.Size(233, 36);
            this.panel_Time.TabIndex = 181;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Gray;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Black;
            this.txtTime.Location = new System.Drawing.Point(106, 3);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(122, 32);
            this.txtTime.TabIndex = 178;
            this.txtTime.Text = "12:12:12";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Gray;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDate.Location = new System.Drawing.Point(3, 8);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 179;
            this.txtDate.Text = "2022-07-10";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.statusLaser);
            this.panel4.Controls.Add(this.statusLVDT);
            this.panel4.Controls.Add(this.statusPLC);
            this.panel4.Location = new System.Drawing.Point(750, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 36);
            this.panel4.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(542, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 36);
            this.panel1.TabIndex = 182;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(64, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 37);
            this.textBox1.TabIndex = 180;
            this.textBox1.Text = "JK1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "차종";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Location = new System.Drawing.Point(2, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 36);
            this.panel3.TabIndex = 183;
            // 
            // statusLaser
            // 
            this.statusLaser.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusLaser.ForeColor = System.Drawing.Color.DimGray;
            this.statusLaser.Location = new System.Drawing.Point(192, 1);
            this.statusLaser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusLaser.Name = "statusLaser";
            this.statusLaser.Size = new System.Drawing.Size(90, 32);
            this.statusLaser.status = ActuatingForce.StatusLamp.Status.True;
            this.statusLaser.TabIndex = 2;
            this.statusLaser.text = "LASER";
            // 
            // statusLVDT
            // 
            this.statusLVDT.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusLVDT.ForeColor = System.Drawing.Color.DimGray;
            this.statusLVDT.Location = new System.Drawing.Point(95, 1);
            this.statusLVDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusLVDT.Name = "statusLVDT";
            this.statusLVDT.Size = new System.Drawing.Size(83, 32);
            this.statusLVDT.status = ActuatingForce.StatusLamp.Status.False;
            this.statusLVDT.TabIndex = 1;
            this.statusLVDT.text = "LVDT";
            // 
            // statusPLC
            // 
            this.statusPLC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusPLC.ForeColor = System.Drawing.Color.DimGray;
            this.statusPLC.Location = new System.Drawing.Point(10, 1);
            this.statusPLC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusPLC.Name = "statusPLC";
            this.statusPLC.Size = new System.Drawing.Size(71, 32);
            this.statusPLC.status = ActuatingForce.StatusLamp.Status.Non;
            this.statusPLC.TabIndex = 0;
            this.statusPLC.text = "PLC";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1280, 960);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Time);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "작동력검사";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Time.ResumeLayout(false);
            this.panel_Time.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Comm;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Time;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel panel4;
        private StatusLamp statusPLC;
        private System.Windows.Forms.Panel panel1;
        private StatusLamp statusLaser;
        private StatusLamp statusLVDT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}

