using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.Basic.Session;
using System.Threading;
using zSession.Base;

namespace zSession.Session
{
    public partial class SessionPanel : UserControl
    {
        private string userID;

        private object allowUpdate = true;
        private object MessageUpdate_Start = false;
        private object FriendUpdate_Start;
        private object GroupChatUpdate_Start;
        private object BusinessUpdate_Start;
        private object NonprofitUpdate_Start;
        private object AcademicUpdate_Start;
        private object PartyUpdate_Start;

        private delegate bool Status_Update();
        private Status_Update isAllowUpdate;
        private Status_Update MsgUpdateStart;
        private Status_Update FriendUpdateStart;
        private Status_Update GroupChatUpdateStart;
        private Status_Update BusinessUpdateStart;
        private Status_Update NonprofitUpdateStart;
        private Status_Update AcademicUpdateStart;
        private Status_Update PartyUpdateStart;

        private SessionInfo messageClass;

        private FlowLayoutPanel flpMessage;
        private TreeView tvFriend;
        private TreeView tvGroupChat;
        private TreeView tvBusiness;
        private TreeView tvNonprofit;
        private TreeView tvAcademic;
        private TreeView tvParty;

        public SessionPanel(string userID, params object[] paramlist)
        {
            InitializeComponent();

            this.userID = userID;
            isAllowUpdate = new Status_Update(() => { return bool.Parse(allowUpdate.ToString()); });

            MsgUpdateStart = new Status_Update(() => { return bool.Parse(MessageUpdate_Start.ToString()); });
            FriendUpdateStart = new Status_Update(() => { return bool.Parse(FriendUpdate_Start.ToString()); });
            GroupChatUpdateStart = new Status_Update(() => { return bool.Parse(GroupChatUpdate_Start.ToString()); });
            BusinessUpdateStart = new Status_Update(() => { return bool.Parse(BusinessUpdate_Start.ToString()); });
            NonprofitUpdateStart = new Status_Update(() => { return bool.Parse(NonprofitUpdate_Start.ToString()); });
            AcademicUpdateStart = new Status_Update(() => { return bool.Parse(AcademicUpdate_Start.ToString()); });
            PartyUpdateStart = new Status_Update(() => { return bool.Parse(PartyUpdate_Start.ToString()); });

           if(!bkgInit.IsBusy)
            {
                bkgInit.RunWorkerAsync();
            }
        }
        
        



        private void bkgInit_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bkgInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //
            flpMessage = new FlowLayoutPanel();
            flpMessage.Dock = DockStyle.Fill;
            panelBody.Controls.Add(flpMessage);

            ThreadPool.QueueUserWorkItem(new WaitCallback((object _user) =>
            {
                while (isAllowUpdate())
                {
                    if (MsgUpdateStart())
                    {
                        if (MessageRefreshStatus())
                        {
                            sessionMessageTimes(messageClass);
                            Thread.Sleep(SystemParamters.MessageFrequency);
                        }
                    }
                }
                //实时刷新用户信息

            }), userID);

            //
            tvFriend = new TreeView();
            tvFriend.ImageList = imageList1;
            tvFriend.Nodes.Add("root", "根目录", 0);
            tvFriend.ContextMenuStrip = ctMSTools;

            tvFriend.Dock = DockStyle.Fill;
            panelBody.Controls.Add(tvFriend);

            //
            tvGroupChat = new TreeView();

            //
            tvBusiness = new TreeView();

            //
            tvNonprofit = new TreeView();

            //
            tvAcademic = new TreeView();

            //
            tvParty = new TreeView();




            CreateGroup(SessionGroup.Personal);
        }


        private void AddChatGroup(string btnName, string btnLabel, SessionInfo sessionInfo)
        {
            Button btn = new Button();
            btn.Name = btnName;
            btn.Text = btnLabel;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new Point(0, 0);
            btn.ForeColor = Color.LightCoral;
            btn.Size = new Size(flpGroup.Width / sessionInfo.CrewNumber, flpGroup.Height - 4);            
            btn.Tag = sessionInfo;

            lock(messageClass)
            {
                messageClass = sessionInfo;
            }

            btn.Click += new EventHandler((object sender, EventArgs e) =>
            {                
                if(sessionInfo.SessionType== SessionFunction.Message)
                {
                    


                    LoadMessage(sessionInfo);
                }
                else
                {
                    LoadArchitecture(sessionInfo.UserID, sessionInfo.GroupID,sessionInfo.SessionType.ToString());
                }
                
            });

            flpGroup.Controls.Add(btn);
            btn.Margin = new Padding(0, 0, 0, 4);
        }

        private static object isStopRefreshMessage = false;        
        private delegate bool IsStopRefreshMessage();
        private IsStopRefreshMessage MessageRefreshStatus = new IsStopRefreshMessage(() => { return bool.Parse(isStopRefreshMessage.ToString()); });

        /// <summary>
        /// 载入消息
        /// </summary>
        /// <param name="sessionInfo"></param>        
        private void LoadMessage(SessionInfo sessionInfo)
        {            
            panelBody.Controls.Clear();           

            FlowLayoutPanel flpMessage = new FlowLayoutPanel();
            flpMessage.Dock = DockStyle.Fill;
            isStopRefreshMessage = true;

            panelBody.Controls.Add(flpMessage);
            sessionInfo.Componet = flpMessage;

            ThreadPool.QueueUserWorkItem(new WaitCallback((object _user) => {
                //实时刷新用户信息
                while (MessageRefreshStatus())
                {
                    sessionMessageTimes( sessionInfo);
                    Thread.Sleep(SystemParamters.MessageFrequency);
                }
            }), userID);

            ControlEventHandler panelClose = new ControlEventHandler((object sender, ControlEventArgs e) => {
                flpMessage.Dispose();
            });

            flpMessage.Disposed += new EventHandler((object sender, EventArgs e) => {
                //释放托管的消息实时刷新功能
                lock (isStopRefreshMessage)
                {
                    isStopRefreshMessage = false;
                }
                panelBody.ControlRemoved -= panelClose;
            });

            
            panelBody.ControlRemoved += panelClose;


        }
        
        private delegate void SessionMessageTimes(SessionInfo sessionInfo);
        private void sessionMessageTimes( SessionInfo sessionInfo )
        {
            //if(!bkgShowMessage.IsBusy)
            //{
            //    bkgShowMessage.RunWorkerAsync(sessionInfo);
            //}


            if (this.InvokeRequired)
            {
                SessionMessageTimes _sessionMessageTimes = new SessionMessageTimes(sessionMessageTimes);
                this.Invoke(_sessionMessageTimes, new object[] { sessionInfo });
            }
            else
            {
                FlowLayoutPanel flpMessage = sessionInfo.Componet as FlowLayoutPanel;
                List<SessionMessage> message = GetLastMessage(sessionInfo.UserID, sessionInfo.GroupID, sessionInfo.SessionType.ToString());

                foreach (var itm in message)
                {
                    var find = flpMessage.Controls.Find(itm.Name, true);
                    if (find.Length <= 0)
                    {
                        flpMessage.Controls.Add(itm);
                        flpMessage.Controls.SetChildIndex(itm, 0);
                    }
                    else
                    {
                        find[0].Visible = true;
                    }
                }

            }
        }

       

        /// <summary>
        /// 从网络或本机数据库读取最新10记录
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="groupID"></param>
        /// <param name="sessionType"></param>
        /// <returns></returns>
        private List<SessionMessage> GetLastMessage(string userID, string groupID, string sessionType)
        {
            List<SessionMessage> rtn = new List<SessionMessage>();

            for(int i=0;i<10;i++)
            {
                SessionMessage itm = new SessionMessage();
                itm.Name = string.Format("M_{0}",i);
                rtn.Add(itm);
            }

            return rtn;
        }

        //private delegate void SessionMessageTimes(string userID);


        /// <summary>
        /// 载入框架
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="groupID"></param>
        /// <param name="functionID"></param>
        private void LoadArchitecture(string userID, string groupID,string functionID)
        {
           
            panelBody.Controls.Clear();
            

            TreeView tv = new TreeView();
            tv.ImageList = imageList1;
            tv.Nodes.Add("root", "根目录", 0);
            tv.ContextMenuStrip = ctMSTools;

            tv.Dock = DockStyle.Fill;
            panelBody.Controls.Add(tv);
            
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            CreateGroup(SessionGroup.Personal);
        }        

        private void btnCorporation_Click(object sender, EventArgs e)
        {
            CreateGroup(SessionGroup.Corporation);
        }

        private void CreateGroup(SessionGroup groupType)
        {
            flpGroup.Controls.Clear();

            switch (groupType)
            {
                case SessionGroup.Personal:
                    AddChatGroup("btnMessage", "消息", new SessionInfo(userID, btnPersonal.Tag.ToString(), SessionFunction.Message, 3));
                    AddChatGroup("btnFriend", "好友", new SessionInfo(userID, btnPersonal.Tag.ToString(), SessionFunction.Friend, 3));
                    AddChatGroup("btnGroupChat", "群聊", new SessionInfo(userID, btnPersonal.Tag.ToString(), SessionFunction.GroupChat, 3));
                    break;
                case SessionGroup.Corporation:
                    AddChatGroup("btnMessage", "消息", new SessionInfo(userID, btnPersonal.Tag.ToString(), SessionFunction.Message, 5));
                    AddChatGroup("btnBusiness", "商业", new SessionInfo(userID, btnCorporation.Tag.ToString(), SessionFunction.Business, 5));
                    AddChatGroup("btnNonprofit", "公益", new SessionInfo(userID, btnCorporation.Tag.ToString(), SessionFunction.Nonprofit, 5));
                    AddChatGroup("btnAcademic", "学术", new SessionInfo(userID, btnCorporation.Tag.ToString(), SessionFunction.Academic, 5));
                    AddChatGroup("btnParty", "政党", new SessionInfo(userID, btnCorporation.Tag.ToString(), SessionFunction.Party, 5));
                    break;
            }
        }
        private enum SessionGroup
        {
            /// <summary>
            /// 个人
            /// </summary>
            Personal,
            /// <summary>
            /// 团体
            /// </summary>            
            Corporation
        }
        private enum SessionFunction
        {
            Message,
            Friend,
            GroupChat,
            Business,
            Nonprofit,
            Academic,
            Party
        }


        private class SessionInfo
        {   
            public SessionInfo(string userID, string groupID, SessionFunction sessionType, int crewNumber=4)
            {
                this.GroupID = groupID;
                this.SessionType = sessionType;
                this.UserID = userID;
                this.CrewNumber = crewNumber;
            }

            public string GroupID { get; set; }
            public int CrewNumber { get; set; }
            public SessionFunction SessionType { get; set; }
            public string UserID { get; set; }

            public object Componet { get; set; }
        }

        
    }
}
