using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zSession.SocialNet
{
    public partial class SocialNetPanel : UserControl
    {
        private string userID;
        public SocialNetPanel(string userID, params object[] paramlist)
        {
            InitializeComponent();

            this.userID = userID;
        }
    }
}
