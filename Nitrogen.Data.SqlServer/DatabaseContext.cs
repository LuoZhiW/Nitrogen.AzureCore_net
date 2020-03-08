using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace Nitrogen.Data.SqlServer
{
    /// <summary>
    /// EF(SqlServer 数据上下文对象)
    /// </summary>
    public class DatabaseContext : DbContext, IDisposable, IObjectContextAdapter
    {
        #region 构造函数
        /// <summary>
        /// 初始化一个 使用指定数据连接名称或连接串 的数据访问上下文类 的新实例
        /// </summary>
        /// <param name="connString">连接字串</param>
        public DatabaseContext(string connString)
            : base(new SqlConnection(connString), true)
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        #endregion

        #region 重载
        /// <summary>
        /// 模型创建重载
        /// </summary>
        /// <param name="modelBuilder">模型创建器</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // 我把【某软】的一堆傻逼玩意Maping注释了 自定义了个批量变更Table 前缀。
            //System.Data.Entity.Database.SetInitializer<DatabaseContext>(null);

            //string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("Learun.DataBase.SqlServer.DLL", "Learun.Application.Mapping.DLL").Replace("file:///", "");
            //Assembly asm = Assembly.LoadFile(assembleFileName);
            //var typesToRegister = asm.GetTypes()
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            //.Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            //foreach (var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    modelBuilder.Configurations.Add(configurationInstance);
            //}
            base.OnModelCreating(modelBuilder);
            modelBuilder.Types().Configure(t =>
            {
                var tableName = t.ClrType.Name;
                tableName = "T_" + tableName;
                t.ToTable(tableName);
            });
        }
        #endregion
    }
}
