namespace ActuatingForce
{
    partial class StatusLamp
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.picLamp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp)).BeginInit();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labName.ForeColor = System.Drawing.Color.DimGray;
            this.labName.Location = new System.Drawing.Point(42, 16);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 190;
            this.labName.Text = "PLC";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLamp
            // 
            this.picLamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLamp.Image = global::ActuatingForce.Properties.Resources.Status_Dot;
            this.picLamp.Location = new System.Drawing.Point(3, 3);
            this.picLamp.Name = "picLamp";
            this.picLamp.Size = new System.Drawing.Size(24, 24);
            this.picLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLamp.TabIndex = 189;
            this.picLamp.TabStop = false;
            // 
            // StatusLamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labName);
            this.Controls.Add(this.picLamp);
            this.Name = "StatusLamp";
            this.Size = new System.Drawing.Size(139, 44);
            ((System.ComponentModel.ISupportInitialize)(this.picLamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.PictureBox picLamp;
    }
}
