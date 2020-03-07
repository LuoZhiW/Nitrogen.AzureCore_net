using log4net;

namespace Nitrogen.Foundation.LogManage
{
    /// <summary>
    /// Log。
    /// </summary>
    public class Log
    {
        private ILog _logger;

        public Log(ILog log)
        {
            this._logger = log;
        }

        /// <summary>
        /// debug。
        /// </summary>
        /// <param name="message">message。</param>
        public void Debug(object message)
        {
            this._logger.Debug(message);
        }

        /// <summary>
        /// Error。
        /// </summary>
        /// <param name="message">message。</param>
        public void Error(object message)
        {
            this._logger.Error(message);
        }

        /// <summary>
        /// Info。
        /// </summary>
        /// <param name="message">message。</param>
        public void Info(object message)
        {
            this._logger.Info(message);
        }

        /// <summary>
        /// Warn。
        /// </summary>
        /// <param name="message">message。</param>
        public void Warn(object message)
        {
            this._logger.Warn(message);
        }

    }
}
