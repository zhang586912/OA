using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zSession.Base
{
    public class SystemParamters
    {
        public static LogStatus Log_Status { get; set; }
        public static string UserID { get; set; }
        /// <summary>
        /// 本机MAC地址列表
        /// </summary>
        public static List<string> MacAddress { get; set; } = new List<string>();
        /// <summary>
        /// 消息刷新频率
        /// </summary>
        public static int MessageFrequency = 100;
    }
}
