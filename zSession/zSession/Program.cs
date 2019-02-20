using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.Base;
using zSession.SystemSetup;

namespace zSession
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //连接字符串中路径改为相对路径 |DataDirectory|
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            //AppDomain.CurrentDomain.SetData("DataPassword", "zSession@zysheng.com");

            SessionService.Connection();  
            if(SessionService.SignalIntensity!= ConnectStatus.Broken)
            {
                //启动更新本机数据库线程
            }
            if (SessionService.LogIn())
            {   
                //进入主界面
                Application.Run(new FormMain(SystemParamters.UserID, SessionService.SignalIntensity));
            }
                        
        }
    }
}
