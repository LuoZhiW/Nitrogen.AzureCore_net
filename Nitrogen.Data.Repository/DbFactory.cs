using Nitrogen.DataBase;
using Nitrogen.Foundation;
using Nitrogen.IOC;
using System.Configuration;
using Unity.Resolution;

namespace Nitrogen.Data.Repository
{
    public class DbFactory
    {
        /// <summary>
        /// 获取连接数据库类型。
        /// </summary>
        /// <returns>DataBaseType。</returns>
        public static DataBaseType GetIDatabaseType()
        {
            string providerName = ConfigurationManager.ConnectionStrings[ConstantName.DbConnctStr].ProviderName;
            return GetDbType(providerName);
        }

        /// <summary>
        /// 获取IDatabase实现。
        /// </summary>
        /// <returns>IDataBase</returns>
        public static IDataBase GetIDatabase()
        {
            return GetIDatabaseByIoc(GetIDatabaseType().ToString(), ConstantName.DbConnctStr);
        }

        /// <summary>
        /// 获取IDatabase实现(重载)。
        /// </summary>
        /// <param name="connString">连接名。</param>
        /// <param name="dbType">数据库类型。</param>
        /// <returns>IDataBase。</returns>
        public static IDataBase GetIDatabase(string connString, DataBaseType dbType)
        {
            return GetIDatabaseByIoc(dbType.ToString(), connString);
        }

        /// <summary>
        /// 获取IDatabase实现(重载)。
        /// </summary>
        /// <param name="connString">连接字符串。</param>
        /// <param name="dbType">数据库类型字符串。</param>
        /// <returns>IDataBase。</returns>
        public static IDataBase GetIDatabase(string connString, string dbType)
        {
            return GetIDatabaseByIoc(dbType, connString);
        }

        /// <summary>
        /// 获取IDatabase实现(重载)。
        /// </summary>
        /// <param name="name">连接配置名称。</param>
        /// <returns>IDataBase。</returns>
        public static IDataBase GetIDatabase(string name)
        {
            string providerName = ConfigurationManager.ConnectionStrings[name].ProviderName;
            return GetIDatabaseByIoc(GetDbType(providerName).ToString(), name);
        }

        private static IDataBase GetIDatabaseByIoc(string name, string connString)
        {
            return UnityIocHelper.Instance.GetService<IDataBase>(name, new ParameterOverride(
                "connString", connString));
        }

        /// <summary>
        /// 解析数据库类型。
        /// </summary>
        /// <param name="providerName">providerName。</param>
        /// <returns>DataBaseType。</returns>
        private static DataBaseType GetDbType(string providerName)
        {
            DataBaseType dbType;
            switch (providerName)
            {
                case "System.Data.SqlClient":
                    dbType = DataBaseType.SqlServer;
                    break;
                case "MySql.Data.MySqlClient":
                    dbType = DataBaseType.MySql;
                    break;
                case "Oracle.ManagedDataAccess.Client":
                    dbType = DataBaseType.Oracle;
                    break;
                default:
                    dbType = DataBaseType.SqlServer;
                    break;
            }
            return dbType;
        }
    }
}
