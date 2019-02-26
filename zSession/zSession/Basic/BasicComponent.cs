using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zSession.Basic
{
    public enum BasisComponent
    {
        /// <summary>
        /// 日程管理组件
        /// </summary>
        JournalComponent,
        /// <summary>
        /// 项目管理组件
        /// </summary>
        ProjectComponent
    }

    /// <summary>
    /// 基础功能外延组件总入口
    /// </summary>
    public class BasicComponent
    {

        public static bool ShowFunction(string userID, BasisComponent _func, params object[] paramList)
        {

            return false;
        }

        public static void CloseFunction()
        {

        }
    }
}
