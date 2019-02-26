using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.Base.DBModel;


namespace zSession.Base
{
    public partial class FormLogin : Form
    {
        private int connectCnt = 0;

        public FormLogin()
        {
            InitializeComponent();

            using (mainEntities db = new mainEntities())
            {
                List<Session_Users> list = db.Session_Users.ToList();
                cboUserID.DataSource = list;
                cboUserID.DisplayMember = "userName";
                cboUserID.ValueMember = "userID";
            }
            common.CancelWait();
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            //common.CancelWait();
        }

        private void txtUserPSD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboUserID.Text.Trim().Length == 0) return;
                SystemParamters.UserID = string.Empty;

                string userID = cboUserID.SelectedValue.ToString();
                string userPSD = txtUserPSD.Text;

                if (confirm(userID, userPSD))
                {
                    this.Close();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboUserID.Text.Trim().Length == 0) return;
            SystemParamters.UserID = string.Empty;

            string userID = cboUserID.SelectedValue.ToString();
            string userPSD = txtUserPSD.Text;

            if(confirm(userID, userPSD))
            {
                this.Close();
            }
            

        }

        private bool confirm(string userID,string userPSD)
        {
            bool rtn = false;
            if (SessionService.NetStatus)
            {
                SystemParamters.Log_Status = WebLogin(userID, userPSD);
                if (SystemParamters.Log_Status == LogStatus.Success)
                {
                    SystemParamters.UserID = userID;
                    this.DialogResult = DialogResult.OK;
                    rtn = true;
                }
                else if (SystemParamters.Log_Status == LogStatus.Refuse)
                {
                    //
                    if (LocadLogin(userID, userPSD))
                    {
                        SystemParamters.UserID = userID;
                        this.DialogResult = DialogResult.OK;
                        rtn = true;
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
                    rtn = true;
                }
                else
                {
                    SystemParamters.Log_Status = LogStatus.UnRegistered;
                }
            }
            connectCnt++;

            return rtn;
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

            //WriteOnLineStatus
            return LogStatus.Success;
        }

        /// <summary>
        /// 保存网络最新操作状态
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="macAddress"></param>
        /// <param name="onLineStatus"></param>
        /// <param name="OperateContext"></param>
        private void WriteOnLineStatus(string userID,List<string> macAddress, OnLineOperateType onLineStatus,string OperateContext="")
        {
            string _mac = string.Join(",", macAddress.ToArray());
            using (mainEntities db = new mainEntities())
            {
                var lines = db.Session_LastOperation.Where(x => x.MacID== _mac).FirstOrDefault();
                if(lines!=null)
                {
                    lines.LastOperator = onLineStatus.ToString();
                    lines.OperateContext = OperateContext;
                    lines.LastOperationTime = DateTime.Now.ToString();
                    lines.LastOperator = userID;
                }
                else
                {
                    lines = new Session_LastOperation();
                    lines.MacID = _mac;
                    lines.LastOperator = onLineStatus.ToString();
                    lines.OperateContext = OperateContext;
                    lines.LastOperationTime = DateTime.Now.ToString();
                    lines.LastOperator = userID;

                    db.Session_LastOperation.Add(lines);
                }

                db.SaveChanges();
                
            }



        }
        /// <summary>
        /// 连接本机数据库，是否允许登录
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userPSD"></param>
        /// <returns></returns>
        private bool LocadLogin(string userID, string userPSD)
        {
            bool bStatus = false;
            using (mainEntities db = new mainEntities())
            {
                bool isLogIn = false;
                Session_LogIn login = null;

                var users = db.Session_LogIn.Where(x => x.userID == userID).ToList();
                if (users.Count > 0)
                {
                    users = users.Where(x => x.userPSD == userPSD).ToList();
                    if(users.Count>0)
                    {
                        bStatus = true;
                        //有无当前机器MAC地址的登录记录
                        foreach (var itm in SystemParamters.MacAddress)
                        {
                            var user = users.FirstOrDefault(x => x.lastLogMacID.Contains(itm));
                            if (user != null)
                            {
                                isLogIn = true;
                                login = user;
                                break;
                            }
                        }
                    }                    
                }
                else
                {
                    var userRegister = db.Session_Users.Where(x => x.userID == userID).ToList();
                    string userInitPSD = "666666";//登录初始口令
                    bStatus = (userRegister.Count > 0 && userPSD == userInitPSD);
                }

                if(bStatus)
                {
                    if (!isLogIn)
                    {
                        login = new Session_LogIn();
                        login.userID = userID;
                        login.userPSD = userPSD;
                        login.lastLogMacID = string.Join(",", SystemParamters.MacAddress.ToArray());
                        login.lastLogTime = DateTime.Now.ToString();

                        db.Session_LogIn.Add(login);                        
                    }
                    else
                    {
                        login.lastLogTime = DateTime.Now.ToString();
                    }
                    db.SaveChanges();

                    //

                }                
            }
            
            
            return bStatus;
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
