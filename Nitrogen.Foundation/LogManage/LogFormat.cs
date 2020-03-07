using System.Text;

namespace Nitrogen.Foundation.LogManage
{
    /// <summary>
    /// LogFormat。
    /// </summary>
    public class LogFormat
    {
        /// <summary>
        /// ErrorFormat。
        /// </summary>
        /// <param name="logMessage">logMessage。</param>
        /// <returns>string。</returns>
        public string ErrorFormat(LogMessage logMessage)
        {
            StringBuilder strInfo = new StringBuilder();
            strInfo.Append("1. 错误: >> 操作时间: " + logMessage.OperationTime + "  操作人: " + logMessage.UserName + "\r\n");
            strInfo.Append("2. 地址: " + logMessage.Url + "   \r\n");
            strInfo.Append("3. 类名: " + logMessage.Class + "  \r\n");
            strInfo.Append("4. Ip  : " + logMessage.Ip + "   主机: " + logMessage.Host + "   浏览器: " + logMessage.Browser + "   \r\n");
            strInfo.Append("5. 内容: " + logMessage.Content + "    \r\n");
            strInfo.Append("-----------------------------------------------------------------------------------------------------------------\r\n");
            return strInfo.ToString();
        }

        /// <summary>
        /// WarnFormat。
        /// </summary>
        /// <param name="logMessage">logMessage。</param>
        /// <returns>logMessage。</returns>
        public string WarnFormat(LogMessage logMessage)
        {
            StringBuilder strInfo = new StringBuilder();
            strInfo.Append("1. 警告: >> 操作时间: " + logMessage.OperationTime + "   操作人: " + logMessage.UserName + " \r\n");
            strInfo.Append("2. 地址: " + logMessage.Url + "    \r\n");
            strInfo.Append("3. 类名: " + logMessage.Class + " \r\n");
            strInfo.Append("4. Ip  : " + logMessage.Ip + "   主机: " + logMessage.Host + "   浏览器: " + logMessage.Browser + "    \r\n");
            strInfo.Append("5. 内容: " + logMessage.Content + "\r\n");
            strInfo.Append("-----------------------------------------------------------------------------------------------------------------------------\r\n");
            return strInfo.ToString();
        }

        /// <summary>
        /// InfoFormat。
        /// </summary>
        /// <param name="logMessage">logMessage。</param>
        /// <returns>string。</returns>
        public string InfoFormat(LogMessage logMessage)
        {
            StringBuilder strInfo = new StringBuilder();
            strInfo.Append("1. 信息: >> 操作时间: " + logMessage.OperationTime + "   操作人: " + logMessage.UserName + " \r\n");
            strInfo.Append("2. 地址: " + logMessage.Url + "    \r\n");
            strInfo.Append("3. 类名: " + logMessage.Class + " \r\n");
            strInfo.Append("4. Ip  : " + logMessage.Ip + "   主机: " + logMessage.Host + "   浏览器: " + logMessage.Browser + "    \r\n");
            strInfo.Append("5. 内容: " + logMessage.Content + "\r\n");
            strInfo.Append("-----------------------------------------------------------------------------------------------------------------------------\r\n");
            return strInfo.ToString();
        }

        /// <summary>
        /// DebugFormat。
        /// </summary>
        /// <param name="logMessage">logMessage。</param>
        /// <returns>string。</returns>
        public string DebugFormat(LogMessage logMessage)
        {
            StringBuilder strInfo = new StringBuilder();
            strInfo.Append("1. 调试: >> 操作时间: " + logMessage.OperationTime + "   操作人: " + logMessage.UserName + " \r\n");
            strInfo.Append("2. 地址: " + logMessage.Url + "    \r\n");
            strInfo.Append("3. 类名: " + logMessage.Class + " \r\n");
            strInfo.Append("4. Ip  : " + logMessage.Ip + "   主机: " + logMessage.Host + "   浏览器: " + logMessage.Browser + "    \r\n");
            strInfo.Append("5. 内容: " + logMessage.Content + "\r\n");
            strInfo.Append("-----------------------------------------------------------------------------------------------------------------------------\r\n");
            return strInfo.ToString();
        }

        /// <summary>
        /// ExceptionFormat。
        /// </summary>
        /// <param name="logMessage">logMessage。</param>
        /// <returns>string。</returns>
        public string ExceptionFormat(LogMessage logMessage)
        {
            StringBuilder strInfo = new StringBuilder();
            strInfo.Append("1. 调试: >> 操作时间: " + logMessage.OperationTime + "   操作人: " + logMessage.UserName + " \r\n");
            strInfo.Append("2. 地址: " + logMessage.Url + "    \r\n");
            strInfo.Append("3. 类名: " + logMessage.Class + " \r\n");
            strInfo.Append("4. 主机: " + logMessage.Host + "   Ip  : " + logMessage.Ip + "   浏览器: " + logMessage.Browser + "    \r\n");
            strInfo.Append("5. 异常: " + logMessage.ExceptionInfo + "\r\n");
            strInfo.Append("-----------------------------------------------------------------------------------------------------------------------------\r\n");
            return strInfo.ToString();
        }
    }
}
