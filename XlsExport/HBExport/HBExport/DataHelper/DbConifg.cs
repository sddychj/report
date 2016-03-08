using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Xiaovcn.DB
{
    /// <summary>
    /// 数据库配置(单件模式)
    /// Xiaov.cn@SSEC 2011/12/3 
    /// 仅为单一数据库程序提供
    /// @@--已抛弃--@@
    /// </summary>
    public sealed class DbConifg
    {
        //private static readonly DbConifg _instance=new DbConifg();

        ///// <summary>
        ///// 数据库连接字符串
        ///// </summary>
        //public string _connectionString;

        ///// <summary>
        ///// 数据库类型
        ///// </summary>
        //public DbType _dbType;

        ///// <summary>
        ///// 私有构造函数
        ///// </summary>
        //private DbConifg()
        //{
        //    #region 获取连接数据库信息 ConnString DbType
        //    try
        //    {
        //        _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        //        string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
        //        if (ConStringEncrypt == "true")
        //        {
        //            _connectionString = DESEncrypt.Decrypt(_connectionString);
        //        }
        //        string systemDbType = ConfigurationManager.AppSettings["DbType"];
        //        switch (systemDbType)
        //        {
        //            case "Oracle":
        //                _dbType = DbType.Oracle;
        //                break;
        //            case "SqlServer":
        //                _dbType = DbType.SqlServer;
        //                break;
        //            case "OleDb":
        //                _dbType = DbType.OleDb;
        //                break;
        //            case "Odbc":
        //                _dbType = DbType.Odbc;
        //                break;
        //            default:
        //                _dbType = DbType.Odbc;
        //                break;
        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("Web.Config参数配置错误，请检查");
        //    }
        //    #endregion
        //}
        ///// <summary>
        ///// 获取实例
        ///// </summary>
        ///// <returns></returns>
        //public static DbConifg GetInstance()
        //{
        //    return _instance;
        //}
    }
}
