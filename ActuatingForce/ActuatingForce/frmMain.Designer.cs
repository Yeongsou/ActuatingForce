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
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Comm = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_System = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Controls.Add(this.btn_Comm);
            this.panel2.Controls.Add(this.btn_History);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Controls.Add(this.btn_System);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 66);
            this.panel2.TabIndex = 3;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.White;
            this.btn_Home.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Home.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Home.Location = new System.Drawing.Point(857, 1);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(77, 36);
            this.btn_Home.TabIndex = 183;
            this.btn_Home.Text = "메인";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_Comm
            // 
            this.btn_Comm.BackColor = System.Drawing.Color.White;
            this.btn_Comm.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Comm.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Comm.Location = new System.Drawing.Point(940, 1);
            this.btn_Comm.Name = "btn_Comm";
            this.btn_Comm.Size = new System.Drawing.Size(77, 36);
            this.btn_Comm.TabIndex = 181;
            this.btn_Comm.Text = "통신";
            this.btn_Comm.UseVisualStyleBackColor = false;
            this.btn_Comm.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.Color.White;
            this.btn_History.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_History.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_History.Location = new System.Drawing.Point(1023, 1);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(92, 36);
            this.btn_History.TabIndex = 180;
            this.btn_History.Text = "이력 조회";
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Exit.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.Location = new System.Drawing.Point(1211, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(57, 36);
            this.btn_Exit.TabIndex = 179;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // btn_System
            // 
            this.btn_System.BackColor = System.Drawing.Color.White;
            this.btn_System.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_System.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_System.Location = new System.Drawing.Point(1121, 1);
            this.btn_System.Name = "btn_System";
            this.btn_System.Size = new System.Drawing.Size(77, 36);
            this.btn_System.TabIndex = 177;
            this.btn_System.Text = "설정";
            this.btn_System.UseVisualStyleBackColor = false;
            this.btn_System.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Location = new System.Drawing.Point(2, 70);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1276, 888);
            this.panelChild.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 960);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Comm;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_System;
        private System.Windows.Forms.Panel panelChild;
    }
}

