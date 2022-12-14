using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActuatingForce
{
    public partial class StatusLamp : UserControl
    {

        #region Enums
        public enum Status
        {
            Non,
            True,
            False
        }
        #endregion


        private Status _statusFlag = Status.Non;
        private string _text = "Status";
        //private Font _font = new Font("굴림", 10, FontStyle.Bold);

        public StatusLamp()
        {
            InitializeComponent();

        }
         
        //public Font labFont
        //{
        //    get => this._font;
        //    set
        //    {
        //        this._font = value;
        //        Invalidate();
        //    }
        //}

        public string text
        {
            get => this._text;
            set
            {
                this._text = value;
                Invalidate();
            }
        }

        public Status status
        {
            get => this._statusFlag;
            set
            {
                this._statusFlag = value;

                if (this._statusFlag == Status.Non) picLamp.Image = Properties.Resources.Status_Dot;
                else if (this._statusFlag == Status.True) picLamp.Image = Properties.Resources.Status_Green_50;
                else picLamp.Image = Properties.Resources.Status_Red_50;
            }
        }
         

        protected override void OnPaint(PaintEventArgs e)
        {
            this.labName.Text = this._text;
            this.labName.Font = this.Font;
            this.labName.ForeColor = this.ForeColor;

            int H = this.Height;

            this.picLamp.Width = H - 2;
            this.picLamp.Height = H - 2;
            this.picLamp.Location = new Point(1, 1);

            int locationMid = (int)((H - this.labName.Height) / 2) + 1;
            this.labName.Location = new Point(picLamp.Width + 2, locationMid);

            base.OnPaint(e);

            this.Width = picLamp.Width + labName.Width + 3;
        }

    }
}
