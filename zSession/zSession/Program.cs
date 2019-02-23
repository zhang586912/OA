using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using zSession.Base;

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
            
            common.AutoWait();
            List<string> macList = common.GetMacAddress();
            SessionService.Connection();
            if (SessionService.SignalIntensity != ConnectStatus.Broken)
            {
                common.DownLoadDataToLocal(macList);//下载本机数据库
                common.UpLoadDataToServer(macList);//上载本机数据到服务器
            }
            Thread.Sleep(10000);

            
            if (SessionService.LogIn())
            {
                common.DownLoadDataToLocal(SystemParamters.UserID, macList);
                
                //进入主界面
                Application.Run(new FormMain(SystemParamters.UserID, SessionService.SignalIntensity));
            }
            else
            {
                common.CancelWait();
            }
                        
        }

       
        
    }
}
