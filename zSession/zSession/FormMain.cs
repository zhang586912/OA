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

            tpMain.Location = new Point(2, 2);
            tpMain.Size = new Size(this.Width - 5, this.Height - 5);
            
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

        //FormBorderStyle.None时，支持改变窗体大小

        #region 支持改变窗体大小
        private const int Guying_HTLEFT = 10;
        private const int Guying_HTRIGHT = 11;
        private const int Guying_HTTOP = 12;
        private const int Guying_HTTOPLEFT = 13;
        private const int Guying_HTTOPRIGHT = 14;
        private const int Guying_HTBOTTOM = 15;
        private const int Guying_HTBOTTOMLEFT = 0x10;
        private const int Guying_HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMLEFT;
                        else
                            m.Result = (IntPtr)Guying_HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMRIGHT;
                        else
                            m.Result = (IntPtr)Guying_HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)Guying_HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)Guying_HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息
                    m.Msg = 0x00A1; //更改消息为非客户区按下鼠标
                    m.LParam = IntPtr.Zero; //默认值
                    m.WParam = new IntPtr(2); //鼠标放在标题栏内
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();            
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);            
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            tpMain.Size = new Size(this.Width - 5, this.Height - 5);
        }

        #endregion

        private void FormMain_Shown(object sender, EventArgs e)
        {           

            if (!bgkInit.IsBusy)
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
            MessageBox.Show("");
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
