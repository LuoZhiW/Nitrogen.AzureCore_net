using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace Nitrogen.DataBase
{
    /// <summary>
    /// 数据库操作基接口。
    /// </summary>
    public interface IDataBase
    {
        /// <summary>
        /// 获取连接上下文。
        /// </summary>
        /// <returns></returns>
        DbConnection GetDbConnection();

        /// <summary>
        /// 开启事务。
        /// </summary>
        /// <returns>IDataBase。</returns>
        IDataBase BeginTrans();

        /// <summary>
        /// 提交事务。
        /// </summary>
        /// <returns>int。</returns>
        int Commit();

        /// <summary>
        /// 回滚事务。
        /// </summary>
        void Rollback();

        /// <summary>
        /// 关闭。
        /// </summary>
        void Close();

        /// <summary>
        /// 执行Sql语句。
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        int ExecuteBySql(string strSql);

        /// <summary>
        /// 执行Sql(带参数)
        /// </summary>
        /// <param name="strSql">sql语句。</param>
        /// <param name="dbParameter">sql参数。</param>
        /// <returns>int。</returns>
        int ExecuteBySql(string strSql, object dbParameter);

        /// <summary>
        /// 执行存储过程。
        /// </summary>
        /// <param name="procName">存储过程名。</param>
        /// <returns></returns>
        int ExecuteByProc(string procName);

        /// <summary>
        /// 执行存储过程(带参数)。
        /// </summary>
        /// <param name="procName">存储过程名。</param>
        /// <param name="dbParameter">参数。</param>
        /// <returns>int。</returns>
        int ExecuteByProc(string procName, object dbParameter);

        /// <summary>
        /// 执行存储过程(泛型)
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="procName">存储过程名。</param>
        /// <returns>T。</returns>
        T ExecuteByProc<T>(string procName) where T : class;

        /// <summary>
        /// 执行存储过程(泛型+参数)。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="procName">存储过程名。</param>
        /// <param name="dbParameter">参数。</param>
        /// <returns>T。</returns>
        T ExecuteByProc<T>(string procName, object dbParameter) where T : class;

        /// <summary>
        /// 执行存储过程返回List。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="procName">存储过程名。</param>
        /// <returns>IEnumerable<T>。</returns>
        IEnumerable<T> QueryByProc<T>(string procName) where T : class;

        /// <summary>
        /// 执行存储过程(返回List+参数)
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="procName">存储过程名。</param>
        /// <param name="dbParameter">参数。</param>
        /// <returns>IEnumerable<T>。</returns>
        IEnumerable<T> QueryByProc<T>(string procName, object dbParameter) where T : class;

        /// <summary>
        /// 插入实体数据。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="entity">实体数据。</param>
        /// <returns>T。</returns>
        int Insert<T>(T entity) where T : class;

        /// <summary>
        /// 批量插入实体数据。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="entities">实体数据List。</param>
        /// <returns>int。</returns>
        int BatchInsert<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// 删除数据。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="entity">实体数据。</param>
        /// <returns>int。</returns>
        int Delete<T>(T entity) where T : class;

        /// <summary>
        /// 批量删除数据。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entities"></param>
        /// <returns></returns>
        int BatchDelete<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// 删除数据(lamada表达式)。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="expression">表达式。</param>
        /// <returns>int。</returns>
        int Delete<T>(Expression<Func<T, bool>> expression) where T : class, new();

        /// <summary>
        /// 更新实体。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="entity">实体数据。</param>
        /// <returns>int。</returns>
        int Update<T>(T entity) where T : class;

        /// <summary>
        /// 批量更新实体。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="entities">实体数据。</param>
        /// <returns>int。</returns>
        int BatchUpdate<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// 根据主键查找数据。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="keyValue">主键。</param>
        /// <returns>T。</returns>
        T FindEntity<T>(object keyValue) where T : class;

        /// <summary>
        /// 根据表达式查找数据。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="expression">表达式。</param>
        /// <returns>T。</returns>
        T FindEntity<T>(Expression<Func<T, bool>> expression) where T : class,new();

        /// <summary>
        /// 查找一个实体(根据Sql)。
        /// </summary>
        /// <typeparam name="T">T。</typeparam>
        /// <param name="strSql">strSql</param>
        /// <param name="dbParameter">参数</param>
        /// <returns></returns>
        T FindEntity<T>(string strSql, object dbParameter = null) where T : class, new();

        /// <summary>
        /// 获取IQueryable表达式。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> IQueryable<T>() where T : class, new();

        /// <summary>
        /// 获取IQueryable表达式(根据表达式)
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="condition">表达式</param>
        /// <returns></returns>
        IQueryable<T> IQueryable<T>(Expression<Func<T, bool>> condition) where T : class, new();

        /// <summary>
        /// 查询列表（获取表所有数据）
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        IEnumerable<T> FindList<T>() where T : class, new();

        /// <summary>
        /// 查询列表（获取表所有数据）
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="orderby">排序</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(Func<T, object> orderby) where T : class, new();

        /// <summary>
        /// 查询列表根据表达式
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="condition">表达式</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(Expression<Func<T, bool>> condition) where T : class, new();

        /// <summary>
        /// 查询列表根据sql语句
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="strSql">sql语句</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(string strSql) where T : class;

        /// <summary>
        /// 查询列表根据sql语句(带参数)
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="strSql">sql语句</param>
        /// <param name="dbParameter">参数</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(string strSql, object dbParameter) where T : class;

        /// <summary>
        /// 查询列表(分页)
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="orderField">排序字段</param>
        /// <param name="isAsc">排序类型</param>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="total">总共数据条数</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(string orderField, bool isAsc, int pageSize, int pageIndex, out int total) where T : class, new();

        /// <summary>
        /// 查询列表(分页)带表达式条件
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="condition">表达式</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isAsc">排序类型</param>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="total">总共数据条数</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(Expression<Func<T, bool>> condition, string orderField, bool isAsc, int pageSize, int pageIndex, out int total) where T : class, new();

        /// <summary>
        /// 查询列表(分页)根据sql语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql">sql语句</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isAsc">排序类型</param>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="total">总共数据条数</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(string strSql, string orderField, bool isAsc, int pageSize, int pageIndex, out int total) where T : class;

        /// <summary>
        /// 查询列表(分页)根据sql语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql">sql语句</param>
        /// <param name="dbParameter">参数</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isAsc">排序类型</param>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="total">总共数据条数</param>
        /// <returns></returns>
        IEnumerable<T> FindList<T>(string strSql, object dbParameter, string orderField, bool isAsc, int pageSize, int pageIndex, out int total) where T : class;

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <returns></returns>
        DataTable FindTable(string strSql);

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="dbParameter">参数</param>
        /// <returns></returns>
        DataTable FindTable(string strSql, object dbParameter);

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isAsc">排序类型</param>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="total">总共数据条数</param>
        /// <returns></returns>
        DataTable FindTable(string strSql, string orderField, bool isAsc, int pageSize, int pageIndex, out int total);

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="dbParameter">参数</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isAsc">排序类型</param>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="total">总共数据条数</param>
        /// <returns></returns>
        DataTable FindTable(string strSql, object dbParameter, string orderField, bool isAsc, int pageSize, int pageIndex, out int total);

        /// <summary>
        /// 获取查询对象
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <returns></returns>
        object FindObject(string strSql);

        /// <summary>
        /// 获取查询对象
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="dbParameter">参数</param>
        /// <returns></returns>
        object FindObject(string strSql, object dbParameter);
  
        /// <summary>
        /// 获取数据库表数据
        /// </summary>
        /// <typeparam name="T">反序列化类型</typeparam>
        /// <returns></returns>
        IEnumerable<T> GetDBTable<T>() where T : class, new();

        /// <summary>
        /// 获取数据库表字段数据
        /// </summary>
        /// <typeparam name="T">反序列化类型</typeparam>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        IEnumerable<T> GetDBTableFields<T>(string tableName) where T : class, new();

    }
}
