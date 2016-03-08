using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Xiaovcn.DB
{
    /// <summary>
    /// 数据库操作类
    /// </summary>
    public class DBManager
    {
        /// <summary>
        /// 默认的数据库连接
        /// </summary>
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        /// <summary>
        /// 数据库类型 默认支持sqlserver数据库
        /// </summary>
        public static readonly string dbProviderName = string.IsNullOrEmpty(ConfigurationManager.AppSettings["dbProviderName"])
                                                    ? "System.Data.SqlClient" : ConfigurationManager.AppSettings["dbProviderName"];
        [ThreadStatic]
        static DBHelper helper;

        /// <summary>
        /// 创建默认的数据库访问类
        /// </summary>
        /// <returns></returns>
        public static DBHelper Instance()
        {
            if (helper == null)
            {
                helper = new DBHelper(connectionString, dbProviderName);
                return helper;
            }
            return helper;
        }
    }
}
