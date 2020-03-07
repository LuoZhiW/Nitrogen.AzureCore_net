using System.ComponentModel;

namespace Nitrogen.Foundation.LogManage
{
    /// <summary>
    /// LogLevel。
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Error。
        /// </summary>
        [Description("错误")]
        Error,

        /// <summary>
        /// Warning。
        /// </summary>
        [Description("警告")]
        Warning,

        /// <summary>
        /// Info。
        /// </summary>
        [Description("信息")]
        Info,

        /// <summary>
        /// Debug。
        /// </summary>
        [Description("调试")]
        Debug
    }
}
