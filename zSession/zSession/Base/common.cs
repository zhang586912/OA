using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zSession.SystemSetup
{
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

    public class common
    {
    }
}
