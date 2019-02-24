using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zSession.Assistant
{
    public partial class AssistantPanel : UserControl
    {
        private string userID;
        public AssistantPanel(string userID, params object[] paramlist)
        {
            InitializeComponent();

            this.userID = userID;
        }
    }
}
