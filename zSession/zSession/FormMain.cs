using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.Assistant;
using zSession.Base;
using zSession.Base.DBModel;
using zSession.Market;
using zSession.News;
using zSession.Session;
using zSession.SocialNet;

namespace zSession
{
    public partial class FormMain : Form
    {
        private string userID;
        private string userAccount;
        private string userName;
        private Image userPhoto=null;
        private List<string> roleList = new List<string>();

        private ConnectStatus connectStatus;
        private DateTime lastSessionTime;

        private AnchorStyles StopAanhor = AnchorStyles.None;       
        private Point loadPoint;

        public FormMain(string _userID,ConnectStatus _initSignal)
        {
            InitializeComponent();
            userID = _userID;
            connectStatus = _initSignal;

            lastSessionTime = DateTime.Now;
            this.MinimumSize = this.Size;
            tpMain.Location = new Point(2, 2);
            tpMain.Size = new Size(this.Width - 5, this.Height - 5);            
            timerHover.Enabled = true; //是否不断重复定时器操作

            if (!bgkInit.IsBusy)
            {
                bgkInit.RunWorkerAsync();
            }
        }

        private void timerHover_Tick(object sender, EventArgs e)
        {
            if (this.Bounds.Contains(Cursor.Position))
            {
                switch (this.StopAanhor)
                {
                    case AnchorStyles.Top:
                        //窗体在最上方隐藏时，鼠标接触自动出现
                        this.Location = new Point(this.Location.X, 0);
                        break;
                    case AnchorStyles.Left:
                        //窗体在最左方隐藏时，鼠标接触自动出现
                        this.Location = new Point(0, this.Location.Y);
                        break;
                    case AnchorStyles.Right:
                        //窗体在最右方隐藏时，鼠标接触自动出现
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
                        break;
                }
            }
            else
            {
                //窗体隐藏时在靠近边界的一侧边会出现2像素原因：感应鼠标，同时2像素不会影响用户视线
                switch (this.StopAanhor)
                {
                    case AnchorStyles.Top:
                        //窗体在顶部时时，隐藏在顶部，底部边界出现2像素
                        this.Location = new Point(this.Location.X, (this.Height - 2) * (-1));
                        break;
                    case AnchorStyles.Left:
                        //窗体在最左边时时，隐藏在左边，右边边界出现2像素
                        this.Location = new Point((-1) * (this.Width - 2), this.Location.Y);
                        break;
                    case AnchorStyles.Right:
                        //窗体在最右边时时，隐藏在右边，左边边界出现2像素
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 2, this.Location.Y);
                        break;
                }
            }
        }

        #region 实现窗体可以移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void tsTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            loadPoint = this.Location;
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

            if(this.WindowState== FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyIcon1.Visible = true;                
            }
            else
            {
                notifyIcon1.Visible = false;
                tpMain.Size = new Size(this.Width - 5, this.Height - 5);
                this.Visible = true;
            }
        }

        #endregion

        private void FormMain_LocationChanged(object sender, EventArgs e)
        {
            this.mStopAnhor();
        }
        /// <summary>
        /// 固定了窗体位置的类型
        /// </summary>
        private void mStopAnhor()
        {
            if (this.Top <= 0)
            {
                StopAanhor = AnchorStyles.Top;
            }
            else if (this.Left <= 0)
            {
                StopAanhor = AnchorStyles.Left;
            }
            else if (this.Left >= Screen.PrimaryScreen.Bounds.Width - this.Width)
            {
                StopAanhor = AnchorStyles.Right;
            }
            else
            {
                StopAanhor = AnchorStyles.None;
            }

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MouseEventArgs Mouse_e = (MouseEventArgs)e;

            if (Mouse_e.Button == MouseButtons.Left)
            {
                this.Location = loadPoint;
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                //this.Activate();            
            }
        }
               

        private void tsmiShow_Click(object sender, EventArgs e)
        {           
            this.Location = loadPoint;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            
            //this.Activate();            
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
            //System.Environment.Exit(0);
        }


        private void FormMain_Shown(object sender, EventArgs e)
        {
            
             
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadPoint = this.Location;
        }

        private void timerNetStatus_Tick(object sender, EventArgs e)
        {
            var ts = lastSessionTime - DateTime.Now;
            if(ts.Milliseconds > 30) //30秒侦测是否断网
            {
                //bgkNetStatus
                if(!bgkNetStatus.IsBusy)
                {
                    bgkNetStatus.RunWorkerAsync();
                }
            }

        }

        #region
        private void bgkNetStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            //WebSocket 发送请求
        }

        private void bgkNetStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //WebSocket 获取回应

            SetNetStatus(connectStatus);
            if (connectStatus == ConnectStatus.Broken)
            {
                SetWorkStatus(WorkStatus.Leave);
            }
            else
            {
                //根据历史设置显示

            }
        }
        #endregion

        private void bgkInit_DoWork(object sender, DoWorkEventArgs e)
        {
            //读取本机数据库，获取配置信息
            using (mainEntities db = new mainEntities())
            {
                var user = db.Session_Users.Where(x => x.userID == userID).FirstOrDefault();
                if (user != null)
                {
                    
                    userName = user.userName;//获取
                    userAccount = user.userAccount;//获取账号
                    //获取照片
                    if (user.userPhoto != null)
                    {
                        try
                        {
                            Image photo = Image.FromStream(new MemoryStream(user.userPhoto));                            
                        }
                        catch
                        {
                        }
                    }

                    //获取拥有权限
                    var rights = db.Session_Grant_Users.Where(x => x.userID == user.userID).ToList();
                    
                    foreach (var itm in rights)
                    {
                        roleList.Add(itm.roleID);                        
                    }
                }

                //获取最后通信时间
                List<string> macIP = common.GetMacAddress();
                List<DateTime> lastTime = new List<DateTime>();
                foreach(string itm in macIP)
                {
                    var last = db.Session_LastOperation.Where(x => x.MacID == itm).FirstOrDefault();
                    if(last!=null)
                    {
                        try
                        {
                            DateTime tmp = DateTime.Parse(last.LastOperationTime);
                            if(tmp!=null)
                            {
                                lastTime.Add(tmp);
                            }                           
                        }
                        catch { }                        
                    }
                }
                if(lastTime.Count>0)
                {
                    lastSessionTime= lastTime.Max();
                }
                
            }



        }
               
        
        private void bgkInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowPhotoWall(userID);
            SetUser(userAccount,userName, userPhoto, roleList);           
                        
            SetNetStatus(connectStatus);
            if (connectStatus == ConnectStatus.Broken)
            {
                SetWorkStatus(WorkStatus.Leave);
            }
            else
            {
                //根据历史设置显示
            }

            ShowFunction(BasicFunction.Session);

            //启动网络侦测定时器，如没有实时会话消息过来，定时网络侦测
            timerNetStatus.Enabled = true;
            //启用天气接口，实时预报天气情况
            timerWeather.Enabled = true;
        }

        #region 设置用户个人信息
        /// <summary>
        /// 设置账号信息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userAccount"></param>       
        /// <param name="_photo"></param>
        /// <param name="roleList"></param>
        private void SetUser(string userName, string userAccount, Image _photo,List<string> roleList)
        {
            if(roleList.Contains("ERP"))
            {
                //拥护有ERP账号
                tslAccount.Text = string.Format("{0}({1})", userName, userAccount);
            }
            else
            {
                tslAccount.Text = string.Format("{0}", userName);
            }

            SetPhoto(userPhoto);
            setRoles(roleList);

            

        }

        private void setRoles(List<string> roleList)
        {
            flpVIP.Controls.Clear();
            foreach (var itm in roleList)
            {               
                PictureBox pic = new PictureBox();
                pic.Image = GetRightImage(itm);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Size = new Size(flpVIP.Height - 4, flpVIP.Height - 4);

                flpVIP.Controls.Add(pic);
            }
        }

        private void SetPhoto(Image _photo)
        {
            if(_photo!=null)
            {
                tpPhoto.BackgroundImage = _photo;
            }
            else
            {
                tpPhoto.BackgroundImage = Properties.Resources.PhotoImages;
            }
        }

        /// <summary>
        /// 显示照片墙
        /// </summary>
        /// <param name="userID"></param>
        private void ShowPhotoWall(string userID)
        {

            //tpHeader.BackgroundImage=
            //tpBody.BackgroundImage=
        }

        #endregion

        private void SetNetStatus(ConnectStatus netStatus)
        {
            picNetStatus.Image = GetSignalIntensityImage(netStatus);
        }
        private void SetWorkStatus(WorkStatus _workStatus)
        {
            switch(_workStatus)
            {
                case WorkStatus.Free:
                    picWorkStatus.Image = Properties.Resources.phone_blue;
                    lblWorkStatus.Text = "空闲";
                    break;
                case WorkStatus.Busyness:
                    picWorkStatus.Image = Properties.Resources.phone_green;
                    lblWorkStatus.Text = "繁忙";
                    break;
                case WorkStatus.NoDisturb:
                    picWorkStatus.Image = Properties.Resources.phone_yellow;
                    lblWorkStatus.Text = "勿扰";
                    break;
                case WorkStatus.Leave:
                    picWorkStatus.Image = Properties.Resources.phone_red;
                    lblWorkStatus.Text = "离开";
                    break;
            }
        }

        private Image GetSignalIntensityImage(ConnectStatus connectStatus)
        {
            Image rtn = null;
            switch (connectStatus)
            {
                case ConnectStatus.Strong:
                    rtn = Properties.Resources.wireless_blue;
                    break;
                case ConnectStatus.Good:
                    rtn = Properties.Resources.wireless_green;
                    break;
                case ConnectStatus.Medium:
                    rtn = Properties.Resources.wireless_yellow;
                    break;
                case ConnectStatus.Broken:
                    rtn = Properties.Resources.wireless_red;
                    break;
            }

            return rtn;
        }

        private Image GetRightImage(string roleID)
        {
            Image rtn = null;
            switch (roleID)
            {
                case "Membership":
                    rtn = Properties.Resources.vcard;
                    break;
                case "Electronic":
                    rtn = Properties.Resources.Electronic_Business;
                    break;
                case "ERP":
                    rtn = Properties.Resources.ERP;
                    break;
            }

            return rtn;
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
            this.WindowState = FormWindowState.Minimized;
        }

        #region
        private void ShowFunction(BasicFunction _func)
        {
            switch(_func)
            {
                case BasicFunction.Session:
                    openTable("SessionPanel", "会话",userID);
                    break;

            }
        }

        #region 打开功能
        /// <summary>
        /// 打开内部控件
        /// </summary>
        /// <param name="tabName">内部功能控件名</param>
        /// <param name="tabLabel">标签名称</param>
        /// <param name="paramList">参数</param>
        /// <returns></returns>
        private bool openTable(string tabName,string tabLabel,params object[] paramList)
        {
            //SessionPanel
            //AssistantPanel
            //SocialNetPanel
            //MarketPanel
            //NewsPanel

            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabName"></param>
        private void closeTable(string tabName)
        {

        }

        /// <summary>
        /// 打开扩展功能
        /// </summary>
        /// <param name="winName">扩展功能控件名</param>
        /// <param name="winLabel">标签名称</param>
        /// <param name="paramList">参数</param>
        /// <returns></returns>
        private bool openWindow(string winName,string winLabel, params object[] paramList)
        {
            //FormBase 
            return false;
        }
        private void closeWindow(string winName)
        {

        }

        /// <summary>
        /// 打开外部链接
        /// </summary>
        /// <param name="linkName">链接URL</param>
        /// <param name="linkLabel">标签名称</param>
        /// <param name="paramList">参数</param>
        /// <returns></returns>
        private bool openLink(string linkName,string linkLabel, params object[] paramList)
        {

            return false;
        }

        #endregion
        #endregion
        #region 系统基础功能
        private void btnSetup_Click(object sender, EventArgs e)
        {

        }


        private void btnMail_Click(object sender, EventArgs e)
        {

        }

        private void tsbJournal_Click(object sender, EventArgs e)
        {

        }
        private void tsbProject_Click(object sender, EventArgs e)
        {

        }

        private void tsbTools_Click(object sender, EventArgs e)
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
