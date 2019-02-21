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

namespace zSession
{
    public partial class FormWelcome : Form
    {
        //private delegate void scrollprogressBar(int value);
        //private scrollprogressBar scroll;
        public FormWelcome()
        {
            InitializeComponent();

           
            

            //scroll = scrollValue;
        }

        //private void scrollValue(int value)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        try
        //        {
        //            scrollprogressBar setpos = new scrollprogressBar(scrollValue);
        //            this.Invoke(setpos, new object[] { value });
        //        }
        //        catch
        //        {

        //        }
                
        //    }
        //    else
        //    {
        //        if (!this.IsDisposed)
        //        {
        //            progressBar1.Value = value;
        //        }

        //    }

            
        //}

        private void FormWelcome_Shown(object sender, EventArgs e)
        {
           
        }


        private void FormWelcome_Load(object sender, EventArgs e)
        {


            //int max = progressBar1.Maximum;
            //Thread fThread = new Thread(new ThreadStart(() => {
            //    int _value = 0;
            //    while (_value <= max)
            //    {
            //        scrollValue(_value);
            //        Thread.Sleep(10);
            //        _value++;   
            //        if (_value > max)
            //        {
            //            Thread.Sleep(100);
            //            _value = 0;
            //        }
            //    }
            //}));
            //fThread.Start();
        }

        //private int i = 0;
        //private void bgkProgress_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    if(i>progressBar1.Maximum)
        //    {
        //        i = 0;
        //    }
        //    else
        //    {
        //        i++;
        //    }
        //}

        //private void bgkProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    progressBar1.Value = i;
        //}

        //private void bgkProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    if(!bgkProgress.IsBusy)
        //    {
        //        bgkProgress.RunWorkerAsync();
        //    }
        //}
    }
}
