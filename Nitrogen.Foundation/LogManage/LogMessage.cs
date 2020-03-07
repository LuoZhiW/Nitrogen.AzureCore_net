using System;

namespace Nitrogen.Foundation.LogManage
{
    /// <summary>
    /// LogMessage Entity。
    /// </summary>
    public class LogMessage
    {
        /// <summary>
        /// OperationTime。
        /// </summary>
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// Url。
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// ClassName。
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// IP。
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Host。
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Browser。
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        /// OpertionUserName。
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Content。
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// ExceptionInfo。
        /// </summary>
        public string ExceptionInfo { get; set; }

        /// <summary>
        /// ExceptionSource。
        /// </summary>
        public string ExceptionSource { get; set; }

        /// <summary>
        /// ExceptionRemark。
        /// </summary>
        public string ExceptionRemark { get; set; }
    }
}
