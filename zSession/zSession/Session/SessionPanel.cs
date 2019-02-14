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
        public SessionPanel()
        {
            InitializeComponent();
        }

        private void AddChatGroup(string btnName, string btnLabel, string KeyValue)
        {
            Button btn = new Button();
            btn.Name = btnName;
            btn.Text = btnLabel;
            btn.Width = flpGroup.Width / 4;
            btn.Height = flpGroup.Height;
            btn.Tag = KeyValue;
            btn.Click += new EventHandler((object sender, EventArgs e)=>
            {
                //写入单击事件
            });
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            flpGroup.Controls.Clear();
            AddChatGroup("btnFriend","好友", "");
            AddChatGroup("btnGroupChat", "群聊", "");
        }

        

        private void btnCorporation_Click(object sender, EventArgs e)
        {
            flpGroup.Controls.Clear();
            AddChatGroup("btnPersonal", "商业社团", "");
            AddChatGroup("btnGroupChat", "公益社团", "");
            AddChatGroup("btnGroupChat", "学术团体", "");
            AddChatGroup("btnGroupChat", "政党", "");
        }


    }
}
