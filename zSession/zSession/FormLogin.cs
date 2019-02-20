using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.Base;
using zSession.SystemSetup;

namespace zSession
{
    public partial class FormLogin : Form
    {
        private int connectCnt = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            //从本机数据库中加载历史登录信息

        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboUserID.Text.Trim().Length == 0) return;
            SystemParamters.UserID = string.Empty;

            if (connectCnt<3)
            {
                string userID = cboUserID.Text;
                string userPSD = txtUserPSD.Text;
                if(SessionService.NetStatus)
                {
                    SystemParamters.Log_Status = WebLogin(userID, userPSD);
                    if(SystemParamters.Log_Status == LogStatus.Success)
                    {
                        SystemParamters.UserID = userID;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else if (SystemParamters.Log_Status == LogStatus.Refuse)
                    {
                        //
                        if (LocadLogin(userID, userPSD))
                        {
                            SystemParamters.UserID = userID;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            SystemParamters.Log_Status = LogStatus.UnRegistered;
                        }
                    }                    
                }                
                else
                {
                    SystemParamters.Log_Status = LogStatus.Refuse;
                    if (LocadLogin(userID, userPSD))
                    {
                        SystemParamters.UserID = userID;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        SystemParamters.Log_Status = LogStatus.UnRegistered;
                    }
                }
                connectCnt++;

            }
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// 连接网络，网上查找是否允许登录
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userPSD"></param>
        /// <returns></returns>
        private LogStatus WebLogin(string userID,string userPSD)
        {
            return LogStatus.Success;
        }

        /// <summary>
        /// 连接本机数据库，是否允许登录
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userPSD"></param>
        /// <returns></returns>
        private bool LocadLogin(string userID, string userPSD)
        {
            return true;
        }

        private void linkSetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkAlterPSD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
    }
}
