using System;
using System.Configuration;
using System.Data;
using System.Collections;
using System.Data.Common;

namespace Xiaovcn.DB
{
    /// <summary>
    /// 数据库访问类(支持SQLServer/Oracle/Acess/)
    /// </summary>
    public class PPADBHelper
    {
        private static readonly DBHelper instance = DBManager.Instance();

        public static bool Exists(string sqlString)
        {
            object obj = instance.ExecuteScalar(CommandType.Text,sqlString);
            int cmdresult;
            if (Object.Equals(obj, null))
            {
                return false;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
                if (cmdresult == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }                
                   
        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static bool ExecuteNonQuery(string sqlString)
        {
            int r = instance.ExecuteNonQuery(System.Data.CommandType.Text, sqlString);
            if (r > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 执行SQL语句返回DataReader 注意关闭
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static IDataReader ExecuterReader(string sqlString)
        {
            return instance.ExcuteReader(sqlString);    
        }

        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="sqlString">Sql语句</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string sqlString)
        {
                return instance.ExecuteDataSet(CommandType.Text, sqlString);
        }
        /// <summary>
        /// 获取一个值
        /// </summary>
        /// <param name="sqlString">sql语句</param>
        /// <returns>object</returns>
        public static object ExecuteScalar(string sqlString)
        {
            return instance.ExecuteScalar(CommandType.Text, sqlString);            
        }
        
        /// <summary>
        /// 调用存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="dataParameters"></param>
        public static void RunProc(string procName, DbParameter[] dataParameters)
        {
            instance.ExcuteProcedure(procName, dataParameters);
        }       
    }
}