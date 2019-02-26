using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zSession.Base
{
    /// <summary>
    /// 系统登录类型
    /// </summary>
    public enum LogStatus
    {
        /// <summary>
        /// 允许登录
        /// </summary>
        Success,
        /// <summary>
        /// 不允许登陆，口令错误或系统拒绝登录（停用用户）
        /// </summary>
        Refuse,
        /// <summary>
        /// 不允许登陆，用户未注册
        /// </summary>
        UnRegistered
    }

    /// <summary>
    /// 信号类型
    /// </summary>
    public enum ConnectStatus
    {
        /// <summary>
        /// 信号强，color : blue
        /// </summary>
        Strong,
        /// <summary>
        /// 信号良好，color : green
        /// </summary>
        Good,
        /// <summary>
        /// 信号差，color : yellow
        /// </summary>
        Medium,
        /// <summary>
        /// 信号断开，color : red
        /// </summary>
        Broken
    }

    /// <summary>
    /// 在线状态
    /// </summary>
    public enum WorkStatus
    {
        /// <summary>
        /// 空闲
        /// </summary>
        Free,
        /// <summary>
        /// 忙碌
        /// </summary>
        Busyness,
        /// <summary>
        /// 勿扰
        /// </summary>
        NoDisturb,
        /// <summary>
        /// 离开
        /// </summary>
        Leave
    }

    /// <summary>
    /// 在线操作类型
    /// </summary>
    public enum OnLineOperateType
    {
        /// <summary>
        /// 登入
        /// </summary>
        LogIn,
        /// <summary>
        /// 登出
        /// </summary>
        LogOut,
        /// <summary>
        /// 
        /// </summary>
        NetDetection

    }

    public enum BasicFunction
    {
        /// <summary>
        /// 会话
        /// </summary>
        Session,
        /// <summary>
        /// 个人秘书
        /// </summary>
        Assistant,
        /// <summary>
        /// 社交网络
        /// </summary>
        SocialNet,
        /// <summary>
        /// 电子商城
        /// </summary>
        Market,
        /// <summary>
        /// 新闻
        /// </summary>
        News
    }

    public class common
    {
        #region 开机界面
        private delegate bool tStatus();
        
        private static FormWelcome welcome;
        public static void BeginWait()
        {
            welcome = new FormWelcome();
            welcome.Show();
        }

        public static void SetProgress(int value)
        {
            if (welcome != null)
            {
                if (!welcome.IsDisposed)
                {
                    welcome.setProgressValue(value);
                }
            }
        }
        public static void EndWait()
        {
            if (welcome != null )
            {
                if(!welcome.IsDisposed)
                {
                    welcome.Close();
                }                
            }
        }
                
        private static object isRunning { get; set; } = 0;

        private static tStatus TStatus = new tStatus(() => {
            return int.Parse(isRunning.ToString()) > 0;
        });

        public static void AutoWait()
        {
            isRunning = 1;
            ThreadPool.QueueUserWorkItem(new WaitCallback((object _initValue) =>
            {
                BeginWait();
                int i = int.Parse(_initValue.ToString());
                bool TContinue = TStatus();
                while (i <= 1000 && TContinue)
                {
                    SetProgress(i);
                    i++;
                    Thread.Sleep(10);
                    if (i > 1000) i = 0;
                    TContinue = TStatus();
                }
                EndWait();
            }), 0);
        }

        public static void CancelWait()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((object _isRunning) =>
            {               
                lock (isRunning)
                {
                    isRunning = int.Parse(_isRunning.ToString());
                }
            }),0);
        }
        #endregion

        #region 上传下载数据
        /// <summary>
        /// 上载数据
        /// </summary>
        /// <param name="macList">MAC地址列表</param>
        /// <param name="isAsync">是否为异步操作</param>
        /// <returns></returns>
        public static bool UpLoadDataToServer(List<string> macList, bool isAsync = true)
        {
            return ThreadPool.QueueUserWorkItem(new WaitCallback((object mac) =>
            {
                if (mac != null)
                {
                    List<string> _macList = mac as List<string>;
                }

                //上传数据



            }), macList);
        }

        /// <summary>
        /// 下载数据到本地数据库中 
        /// </summary>
        /// <param name="macList">MAC地址列表</param>
        /// <param name="isAsync">是否为异步操作</param>
        /// <returns></returns>
        public static void DownLoadDataToLocal(List<string> macList, bool isAsync = true)
        {
            //下载数据

        }

        /// <summary>
        /// 下载指定用户的数据到本地数据库中 
        /// </summary>
        /// <param name="userID">用户ID</param>
        /// <param name="macList">MAC地址列表</param>
        /// <param name="isAsync">是否为异步操作</param>
        public static void DownLoadDataToLocal(string userID, List<string> macList, bool isAsync = true)
        {
            //下载数据

        }

        #endregion

        /// <summary>
        /// 获取本机MAC地址
        /// </summary>
        /// <returns></returns>
        public static List<string> GetMacAddress()
        {
            List<string> macList = new List<string>();
            ManagementObjectSearcher nisc = new ManagementObjectSearcher("select * from Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject nic in nisc.Get())
            {
                if (Convert.ToBoolean(nic["ipEnabled"]) == true)
                {
                    macList.Add(nic["MACAddress"].ToString());
                }
            }

            return macList;
        }

        /// <summary>
        /// 打开外部链接
        /// </summary>
        /// <param name="linkName">链接URL</param>
        /// <param name="linkLabel">标签名称</param>
        /// <param name="paramList">参数</param>
        /// <returns></returns>
        private static bool openLink(string linkName, string linkLabel, string userID, params object[] paramlist)
        {

            return false;
        }
    }
}
