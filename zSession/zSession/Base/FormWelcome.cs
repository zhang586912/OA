using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zSession.Base
{
    public partial class FormWelcome : Form
    {
        private int Maximum = 0;
        private delegate void SetProgressValue(int _value);
        
        public FormWelcome()
        {
            InitializeComponent();
            Maximum = progressBar1.Maximum;
        }

        public FormWelcome(int iMax)
        {
            InitializeComponent();
            setProgressMax(iMax);            
        }

        private void FormWelcome_Shown(object sender, EventArgs e)
        {

        }
        private void FormWelcome_Load(object sender, EventArgs e)
        {

        }

        public void setProgressMax(int max)
        {
            if (this.InvokeRequired)
            {
                SetProgressValue SetProgressMax = new SetProgressValue(setProgressMax);
                this.Invoke(SetProgressMax, new object[] { max });
            }
            else
            {
                Maximum = max;
                progressBar1.Maximum = max;
            }
        }

        public void setProgressStep(int step)
        {
            if (this.InvokeRequired)
            {
                SetProgressValue SetProgressStep = new SetProgressValue(setProgressStep);
                this.Invoke(SetProgressStep, new object[] { step });
            }
            else
            {
                progressBar1.Step = step;
            }
        }
        public void setProgressValue(int _value)
        {
            if(this.InvokeRequired)
            {
                SetProgressValue SetProgress = new SetProgressValue(setProgressValue);       
                this.Invoke(SetProgress, new object[] { _value % Maximum });
            }
            else
            {
                progressBar1.Value = _value % Maximum;
            }            
        }

       

      
    }
}
