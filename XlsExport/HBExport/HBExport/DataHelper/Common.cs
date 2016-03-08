using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.OleDb;

namespace Xiaovcn.DB
{
    public class Common
    {
        /// <summary>
        /// 判断数据表是否存在记录
        /// </summary>
        /// <param name="sTable">数据表名称</param>
        /// <param name="sColumn">数据列</param>
        /// <param name="sText">数据列查询条件=</param>
        /// <returns></returns>
        public static bool ExistID(string sTable, string sColumn, string sText)
        {
            bool flag = false;
            string sSql = "select " + sColumn + " from " + sTable + " where " + sColumn + "=:0";
            OleDbParameter[] cmdParams = { new OleDbParameter(":0", OleDbType.VarChar, 20) };
            cmdParams[0].Value = sText;
            object o = DBManager.Instance().ExecuteScalar(System.Data.CommandType.Text, sSql, cmdParams);
            if (o!=null)
            {
                flag = true;
            }            
            return flag;
        }

        public static string GetID(string sTable, string sColumn)
        {
            string sID = "1";
            string sSql = "select IIf(max(" + sColumn + ")=null,'1',max(" + sColumn + ")+1) id from " + sTable;
            object o = DBManager.Instance().ExecuteScalar(System.Data.CommandType.Text, sSql);
            if (o!=null)
            {
                sID = o.ToString();
            }
            return sID;
        }
    }
}
