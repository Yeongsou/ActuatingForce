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
    public partial class frmMain : Form
    {
        private frmHome frmHome;
        private frmComm frmComm;
        private frmHistory frmHistory;
        private frmSetting frmSetting;

        string frmEnter = string.Empty;
        string frmBefore = "frmHome";

        // 시간 표시 타이머
        private static System.Timers.Timer theTime;

        public frmMain()
        {
            InitializeComponent();

            this.frmHome = new frmHome();
            this.frmHome.TopLevel = false;
            this.Controls.Add(this.frmHome);
            this.frmHome.Parent = this.panelChild;
            this.frmHome.Show();


            #region 시간 표시 타이머
            theTime = new System.Timers.Timer(100);
            theTime.Elapsed += OnTimeEvent;
            theTime.AutoReset = true;
            theTime.Enabled = true;
            #endregion

        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            this.SynchronizedInvoke(() =>
            {
                txtTime.Text = System.DateTime.Now.ToString("HH:mm:ss");
                txtDate.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
            });
        }

        private void MenuClickEvent(object sender, EventArgs e)
        { 

            {
                Button btn = sender as Button;

                MenuClick(btn.Name);
            }
        }


        private void MenuClick(string btnName)
        {
            string[] str = btnName.Split('_');
            string strName = "btn_" + str[1];
            //if (str[1] == "Exit") strName = "btn_Power";

            //labBtnNameRollBack();

            //Control[] conLab;
            //conLab = this.Controls.Find("lab_" + str[1], true);
            //Label lab = conLab[0] as Label;
            //lab.ForeColor = Color.Black;

            //pic.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(strName);

            // 열린 폼 확인하여 form close 
            if (CloseFormCheck("frm" + str[1]) == false) return;

            //gaugeMgr.SetEWorldShapeCalibrationFlag = false;    //frmGauge 를 벗어나면 무조건 False 해줘서 DrawRoi에서 Calibration WorldGrid를 보여주지 않도록 !!!

            switch (str[1])
            {
                case "Main":
                    load_Main();

                    break;
                case "Home":
                    load_Home();

                    break;
                case "Comm":
                    load_Comm();

                    break;
                case "History":
                    load_History();

                    break;
                case "Setting":
                    load_Setting();

                    break;
                case "Exit":

                    this.Close();
                    break;
            }
        }



        private void load_Main()
        {

        }
        private void load_Home()
        {
            //this.frmHome = new frmHome();
            //this.frmHome.TopLevel = false;
            //this.Controls.Add(this.frmHome);
            //this.frmHome.Parent = this.panelChild;



            frmHome.Show();
        }   
        private void load_Comm()
        {
            this.frmComm = new frmComm();
            this.frmComm.TopLevel = false;
            this.Controls.Add(this.frmComm);
            this.frmComm.Parent = this.panelChild;

            frmComm.Show();
        }
        private void load_History()
        {
            this.frmHistory = new frmHistory();
            this.frmHistory.TopLevel = false;
            this.Controls.Add(this.frmHistory);
            this.frmHistory.Parent = this.panelChild;

            frmHistory.Show();
        }
        private void load_Setting()
        {
            this.frmSetting = new frmSetting();
            this.frmSetting.TopLevel = false;
            this.Controls.Add(this.frmSetting);
            this.frmSetting.Parent = this.panelChild;

            frmSetting.Show();
        }

        private Boolean CloseFormCheck(string frmName)
        {
            bool thisVal = true;

            if (frmBefore == null || frmBefore == frmName)
            {
                return false;
            }

            Form frm = Application.OpenForms[frmBefore];
            if (frm != null && frmBefore != frmName) //&& frmBefore != "frmHome")
            {
                if (frm.Name == "frmGrab" || frm.Name == "frmHome")
                {
                    frm.Hide();
                }
                else
                {
                    frm.Close();
                }

            }

            frmEnter = frmBefore;
            frmBefore = frmName;


            return thisVal;
        }





        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
         
    }
}
