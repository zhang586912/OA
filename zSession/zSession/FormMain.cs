using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.SystemSetup;

namespace zSession
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region 实现窗体可以移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        #endregion


        private void FormMain_Shown(object sender, EventArgs e)
        {
            if(!bgkInit.IsBusy)
            {
                bgkInit.RunWorkerAsync();
            }
        }

        private void bgkInit_DoWork(object sender, DoWorkEventArgs e)
        {
            //读取本机数据库，获取配置信息

            //获取

        }

        private void bgkInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private bool GitConnection(out ConnectStatus NetStatus)
        {
            NetStatus = ConnectStatus.Strong;
            return false;
        }

        private void LoadPersonInfo()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }
                
        private void btnSetup_Click(object sender, EventArgs e)
        {

        }

        #region 系统基础功能

        private void btnMail_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 主要功能
        private void btnChat_Click(object sender, EventArgs e)
        {

        }               

        private void btnAssistant_Click(object sender, EventArgs e)
        {

        }

        private void btnSocialNet_Click(object sender, EventArgs e)
        {

        }

        private void btnMarket_Click(object sender, EventArgs e)
        {

        }

        private void btnNews_Click(object sender, EventArgs e)
        {

        }

        #endregion



        #region  扩展功能
        private void tsbDeviceManagement_Click(object sender, EventArgs e)
        {

        }

        private void tsbApplicationCenter_Click(object sender, EventArgs e)
        {

        }

        private void tsbGameCenter_Click(object sender, EventArgs e)
        {

        }

        private void tsbWareMarket_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
