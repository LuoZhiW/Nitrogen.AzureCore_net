using System.Configuration;
using System.Web;

namespace Nitrogen.Foundation.Util
{
    /// <summary>
    /// Config。
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 根据key获取Value。
        /// </summary>
        /// <param name="key">key。</param>
        /// <returns>value。</returns>
        public static string GetValue(string key)
        {
            var appsettingValue = ConfigurationManager.AppSettings[key];
            return appsettingValue.IsEmpty() ? "" : appsettingValue.ToString();
        }

        /// <summary>
        /// 根据Key修改Value。
        /// </summary>
        /// <param name="key">key。</param>
        /// <param name="value">Value。</param>
        public static void SetValue(string key, string value)
        {
            var xDoc = new System.Xml.XmlDocument();
            xDoc.Load(HttpContext.Current.Server.MapPath("~/XmlConfig/system.config"));
            System.Xml.XmlNode xNode;
            System.Xml.XmlElement xElem1;
            System.Xml.XmlElement xElem2;
            xNode = xDoc.SelectSingleNode("//appSettings");
            xElem1 = (System.Xml.XmlElement)xNode.SelectSingleNode("//add[@key='" + key + "']");
            if (xElem1 != null) xElem1.SetAttribute("value", value);
            else
            {
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", key);
                xElem2.SetAttribute("value", value);
                xNode.AppendChild(xElem2);
            }
            xDoc.Save(HttpContext.Current.Server.MapPath("~/XmlConfig/system.config"));
        }
    }
}
