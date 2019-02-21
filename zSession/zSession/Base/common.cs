using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zSession.SystemSetup
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
    }
}
