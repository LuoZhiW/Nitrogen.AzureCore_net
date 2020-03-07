using System;
using log4net;

namespace Nitrogen.Foundation.LogManage
{
    /// <summary>
    /// LogFactory。
    /// </summary>
    public class LogFactory
    {
        /// <summary>
        /// LogFactory。
        /// </summary>
        static LogFactory()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// GetLogger。
        /// </summary>
        /// <param name="type">type。</param>
        /// <returns>Log。</returns>
        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }

        /// <summary>
        /// GetLogger。
        /// </summary>
        /// <param name="str">str。</param>
        /// <returns>Log。</returns>
        public static Log GetLogger(string str)
        {
            return new Log(LogManager.GetLogger(str));
        }
    }
}
