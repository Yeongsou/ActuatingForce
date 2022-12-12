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
            this.panelChild = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_System = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Comm = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
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
            // panelChild
            // 
            this.panelChild.Location = new System.Drawing.Point(2, 70);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1276, 888);
            this.panelChild.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ActuatingForce.Properties.Resources.Status_Dot;
            this.pictureBox1.Location = new System.Drawing.Point(859, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // btn_System
            // 
            this.btn_System.BackColor = System.Drawing.Color.White;
            this.btn_System.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_System.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_System.Location = new System.Drawing.Point(1121, 3);
            this.btn_System.Name = "btn_System";
            this.btn_System.Size = new System.Drawing.Size(77, 32);
            this.btn_System.TabIndex = 177;
            this.btn_System.Text = "설정";
            this.btn_System.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Exit.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.Location = new System.Drawing.Point(1211, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(57, 32);
            this.btn_Exit.TabIndex = 179;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.Color.White;
            this.btn_History.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_History.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_History.Location = new System.Drawing.Point(1023, 3);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(92, 32);
            this.btn_History.TabIndex = 180;
            this.btn_History.Text = "이력 조회";
            this.btn_History.UseVisualStyleBackColor = false;
            // 
            // btn_Comm
            // 
            this.btn_Comm.BackColor = System.Drawing.Color.White;
            this.btn_Comm.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Comm.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Comm.Location = new System.Drawing.Point(940, 3);
            this.btn_Comm.Name = "btn_Comm";
            this.btn_Comm.Size = new System.Drawing.Size(77, 32);
            this.btn_Comm.TabIndex = 181;
            this.btn_Comm.Text = "통신";
            this.btn_Comm.UseVisualStyleBackColor = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.White;
            this.btn_Home.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Home.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Home.Location = new System.Drawing.Point(857, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(77, 32);
            this.btn_Home.TabIndex = 183;
            this.btn_Home.Text = "메인";
            this.btn_Home.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 960);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Comm;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_System;
    }
}

