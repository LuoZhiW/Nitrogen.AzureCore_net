﻿using System.Collections.Generic;

namespace Nitrogen.Foundation.Util.DataBase
{
    /// <summary>
    /// 数据库查询拼接数据模型。
    /// </summary>
    public class DbWhere
    {
        /// <summary>
        /// sql语句。
        /// </summary>
        public string sql { get; set; }
        /// <summary>
        /// 查询参数。
        /// </summary>
        public List<FieldValueParam> dbParameters { get; set; }
    }
}
