using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.Base.Tools;

namespace zSession.Base
{
    public partial class FormBase : Form
    {
        
        public FormBase(string _title="")
        {
            InitializeComponent();
            tslTitle.Text = _title;
        }

        public FormBase(string userID, string tabName, string _title = "", params object[] paramList)
        {
            InitializeComponent();
            tslTitle.Text = _title;

            openTab(tabName, userID);
        }

        public void openTab(string tabName,string userID,params object[] paramList)
        {
            switch (tabName)
            {
                case "Setup":
                    SetupPanel tabSetup = new SetupPanel(userID, paramList);
                    
                    tabSetup.Dock = DockStyle.Fill;
                    panelBody.Controls.Add(tabSetup);
                    
                    break;
                case "Tools":
                    toolPanel tabTool = new toolPanel(userID, paramList);

                    tabTool.Dock = DockStyle.Fill;
                    panelBody.Controls.Add(tabTool);
                   
                    break;
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
