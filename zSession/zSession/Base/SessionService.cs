using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zSession.Base
{
    public static class SessionService
    {
       
        /// <summary>
        /// 
        /// </summary>                       
        public static bool NetStatus
        {
            get
            {
                return SignalIntensity != ConnectStatus.Broken;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static ConnectStatus SignalIntensity { get; set; } = ConnectStatus.Broken;

        
        /// <summary>
        /// 打开链接,侦测网络是否通
        /// </summary>
        /// <returns></returns>
        public static bool Connection()
        {

            //连接网络
            Thread.Sleep(3000);
            

            return true;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public static void DisConnection()
        {

        }

        /// <summary>
        /// 登录系统
        /// </summary>
        /// <returns></returns>
        public static bool LogIn()
        {
           FormLogin login = new FormLogin();
            
            if (login.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 登出系统
        /// </summary>
        /// <param name="userID"></param>
        public static void LogOut(string userID="")
        {

        }
    }
}
