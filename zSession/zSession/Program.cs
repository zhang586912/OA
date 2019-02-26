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
            SystemParamters.MacAddress = common.GetMacAddress();
            SessionService.Connection();
            if (SessionService.SignalIntensity != ConnectStatus.Broken)
            {
                common.DownLoadDataToLocal(SystemParamters.MacAddress);//下载本机数据库
                common.UpLoadDataToServer(SystemParamters.MacAddress);//上载本机数据到服务器
            }
            
            if (SessionService.LogIn())
            {
                common.DownLoadDataToLocal(SystemParamters.UserID, SystemParamters.MacAddress);
                
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
