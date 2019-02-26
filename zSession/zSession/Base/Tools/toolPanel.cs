using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zSession.Base.Tools
{
    public partial class toolPanel : UserControl
    {
        public toolPanel(string userID, params object[] paramList)
        {
            InitializeComponent();
        }
    }
}
