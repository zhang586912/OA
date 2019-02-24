using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zSession.Session
{
    public partial class SessionPanel : UserControl
    {
        private string userID;
        public SessionPanel(string userID, params object[] paramlist)
        {
            InitializeComponent();

            this.userID = userID;

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
            
            btn.Click += new EventHandler((object sender, EventArgs e) =>
            {                
                if(sessionInfo.SessionType== SessionFunction.Message)
                {
                    LoadMessage(sessionInfo.UserID, sessionInfo.GroupID);
                }
                else
                {
                    LoadArchitecture(sessionInfo.UserID, sessionInfo.GroupID,sessionInfo.SessionType.ToString());
                }
                
            });

            flpGroup.Controls.Add(btn);
            btn.Margin = new Padding(0, 0, 0, 4);
        }

        /// <summary>
        /// 载入消息
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="groupID"></param>
        private void LoadMessage(string userID, string groupID)
        {
            //
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 载入框架
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="groupID"></param>
        /// <param name="functionID"></param>
        private void LoadArchitecture(string userID, string groupID,string functionID)
        {


            //throw new NotImplementedException();
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
        }

    }
}
