using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zSession.Extend
{
    public enum ExtendFunction
    {
        EMail,
        Finance,
        Device,
        AppCenter,
        GameCenter,
        WareMarket
    }

    /// <summary>
    /// 扩展功能总入口
    /// </summary>
    public class SessionExtend
    {
        
        public static bool ShowFunction(string userID,ExtendFunction _func,params object[] paramList)
        {

            return false;
        }
        public static void CloseFunction()
        {

        }
    }
}
