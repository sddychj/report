using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.DDL
{
  public class DDLExecute
  {
    public static string CreateTable(string tableName, string[] columnList, string[] typeList)
    {
      string resultStr = "";
      if (!CreateDDLSql.ExistTable(tableName))
      {
        string sql = CreateDDLSql.CreateTableSql(tableName, columnList, typeList);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "表" + tableName + "创建成功";
      }
      else
      {
        resultStr = "表" + tableName + "不存在";
      }

      return resultStr;
    }

    public static string AddPK(string tableName, string[] pkNameList)
    {
      string resultStr = "";
      if (CreateDDLSql.ExistTable(tableName))
      {
        string sql = CreateDDLSql.AddPKSql(tableName, pkNameList);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "主键" + tableName + "创建成功";
      }
      else
      {
        resultStr = "表" + tableName + "不存在";
      }

      return resultStr;
    }

    public static string DropTable(string tableName)
    {
      string resultStr = "";
      if (CreateDDLSql.ExistTable(tableName))
      {
        string sql = CreateDDLSql.DropTableSql(tableName);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "表" + tableName + "删除成功";
      }
      else
      {
        resultStr = "表" + tableName + "不存在";
      }
      return resultStr;
    }

    public static string RenameTable(string oldTableName, string newTableName)
    {
      string resultStr = "";
      if (CreateDDLSql.ExistTable(oldTableName))
      {
        string sql = CreateDDLSql.RenameTableSql(oldTableName, newTableName);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "表" + oldTableName + "重命名成功";
      }
      else
      {
        resultStr = "表" + oldTableName + "不存在";
      }
      return resultStr;
    }

    public static string AddTableComment(string tableName, string comment)
    {
      string str = "";
      if (CreateDDLSql.ExistTable(tableName))
      {
        string sql = CreateDDLSql.AddTableComment(tableName, comment);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        str = "注释添加成功";
      }
      return str;
    }

    public static string AddColumnComment(string tableName, string columnName, string comment)
    {
      string str = "";
      if (CreateDDLSql.ExistColumn(tableName, columnName))
      {
        string sql = CreateDDLSql.AddColumnComment(tableName, columnName, comment);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        str = "注释添加成功";
      }
      return str;
    }

    public static string AddColumn(string tableName, string columnName, string type)
    {
      string resultStr = "";
      if (CreateDDLSql.ExistTable(tableName))
      {
        string sql = CreateDDLSql.AddColumnSql(tableName, columnName, type);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "列" + columnName + "添加成功";
      }
      else
      {
        resultStr = "表" + tableName + "不存在";
      }
      return resultStr;
    }

    public static string DropColumn(string tableName, string columnName)
    {
      string resultStr = "";
      if (CreateDDLSql.ExistColumn(tableName, columnName))
      {
        string sql = CreateDDLSql.DropColumnSql(tableName, columnName);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "列" + columnName + "删除成功";
      }
      else
      {
        resultStr = "列" + columnName + "不存在";
      }

      return resultStr;
    }

    public static string RenameColumn(string tableName, string oldColumnName, string newColumnName)
    {
      string resultStr = "";
      if (CreateDDLSql.ExistColumn(tableName, oldColumnName))
      {
        string sql = CreateDDLSql.RenameColumnSql(tableName, oldColumnName, newColumnName);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "列" + oldColumnName + "重命名成功";
      }
      else
      {
        resultStr = "列" + oldColumnName + "不存在";
      }

      return resultStr;
    }

    public static string AlterColumnType(string tableName, string columnName, string type)
    {
      string resultStr = "";
      if (CreateDDLSql.ExistColumn(tableName, columnName))
      {
        string sql = CreateDDLSql.AlterColumnTypeSql(tableName, columnName, type);
        DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
        resultStr = "列" + columnName + "修改成功";
      }
      else
      {
        resultStr = "表" + tableName + "不存在";
      }
      return resultStr;
    }
  }
}
