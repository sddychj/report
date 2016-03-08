using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Common.DDL
{
  public class CreateDDLSql
  {
    public static string CreateTableSql(string tableName, string[] columnList, string[] typeList)
    {
      StringBuilder createTableSql = new StringBuilder();
      createTableSql.Append("create table ");
      createTableSql.Append(tableName);
      createTableSql.Append("(");
      for (int i = 0; i < columnList.Length; i++)
      {
        createTableSql.Append(columnList[i]);
        createTableSql.Append(" ");
        createTableSql.Append(typeList[i]);
        createTableSql.Append(",");
      }
      string resultStr = createTableSql.ToString().Trim(new char[] { ',' }) + ")";
      //createTableSql.Append(")");
      return resultStr;
    }

    public static string AddPKSql(string tableName, string[] pkNameList)
    {
      StringBuilder pk = new StringBuilder();
      pk.Append("alter table ");
      pk.Append(tableName);
      pk.Append(" add constraint PK_");
      pk.Append(tableName);
      pk.Append(" primary key (");
      pk.Append(string.Join(",", pkNameList));
      pk.Append(")");
      return pk.ToString();
    }

    public static string DropPKSql(string tableName)
    {
      string pk = "alter table " + tableName + " drop constraint PK_" + tableName;

      return pk;
    }

    public static string DropTableSql(string tableName)
    {
      string dropTableSql = "drop table " + tableName;

      return dropTableSql;
    }

    public static bool ExistTable(string tableName)
    {
      bool existTable = false;
      string sql = "select table_name from user_tables where table_name=:0";
      OracleParameter[] cmdParams = new OracleParameter[] { new OracleParameter(":0", OracleDbType.Varchar2, 20) };
      cmdParams[0].Value = tableName;
      OracleDataReader dr = DBUtilityOdp.DbHelperOra.ExecuteReader(sql, cmdParams);
      if (dr.Read())
      {
        existTable = true;
      }
      dr.Close();
      return existTable;
    }

    public static string AddTableComment(string tableName, string comment)
    {
      string str = "";
      if (tableName == "" || comment == "")
        return str;
      str = "comment on table " + tableName + " is '" + comment + "'";
      return str;
    }

    public static string AddColumnComment(string tableName, string columnName, string comment)
    {
      string str = "";
      if (tableName == "" || columnName == "")
        return str;
      str = "comment on column " + tableName + "." + columnName + " is '" + comment + "'";
      return str;
    }

    public static bool ExistColumn(string tableName, string columnName)
    {
      bool existTable = false;
      string sql = "select column_name from user_tab_columns where table_name=:0 and column_name=:1";
      OracleParameter[] cmdParams = new OracleParameter[] { new OracleParameter(":0", OracleDbType.Varchar2, 20),
       new OracleParameter(":1", OracleDbType.Varchar2, 20)};
      cmdParams[0].Value = tableName;
      cmdParams[1].Value = columnName;
      OracleDataReader dr = DBUtilityOdp.DbHelperOra.ExecuteReader(sql, cmdParams);
      if (dr.Read())
      {
        existTable = true;
      }
      dr.Close();
      return existTable;
    }

    public static string RenameTableSql(string oldTableName, string newTableName)
    {
      string renameTableSql = "rename " + oldTableName + " to " + newTableName;

      return renameTableSql;
    }

    public static string AddColumnSql(string tableName, string columnName, string type)
    {
      string addColumnSql = "alter table " + tableName + " add " + columnName + " " + type;

      return addColumnSql;
    }

    public static string DropColumnSql(string tableName, string columnName)
    {
      string dropColumnSql = "alter table " + tableName + " drop column " + columnName;

      return dropColumnSql;
    }

    public static string RenameColumnSql(string tableName, string oldColumnName, string newColumnName)
    {
      string renameColumnSql = "alter table " + tableName + " rename column " + oldColumnName + " to " + newColumnName;

      return renameColumnSql;
    }

    public static string AlterColumnTypeSql(string tableName, string columnName, string type)
    {
      string addColumnSql = "alter table " + tableName + " modify " + columnName + " " + type;

      return addColumnSql;
    }
  }
}
