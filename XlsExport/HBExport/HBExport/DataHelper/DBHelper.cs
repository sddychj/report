﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Reflection;

namespace Xiaovcn.DB
{
    public class DBHelper
    {
        private string connectionString = string.Empty;
        private DbProviderFactory factory;
        private DbConnection _connection;
        public DbConnection connection
        {
            get { return _connection; }
            set { _connection = value; }
        }
        private DbTransaction _transaction;
        private DbParameter _parameter;
        public DbTransaction transaction
        {
            get { return _transaction; }
            set { _transaction = value; ;}
        }

        public DBHelper(string connectionString, string dbProviderName)
        {
            this.connectionString = connectionString;
            factory = DbProviderFactories.GetFactory(dbProviderName);
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (connection == null)
            {
                connection = factory.CreateConnection();
                connection.ConnectionString = connectionString;
            }
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        /// <summary>
        /// 开启事务
        /// </summary>
        public void BeginTransaction()
        {
            OpenConnection();
            if (transaction == null)
                transaction = connection.BeginTransaction();
        }

        /// <summary>
        /// 提交事务 并且 释放并关闭资源
        /// </summary>
        public void CommitTransaction()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction.Dispose();
                transaction = null;
                Dispose();
            }
        }

        /// <summary>
        /// 回滚事务 并且 释放并关闭资源
        /// </summary>
        public void RollbackTransaction()
        {
            if (transaction != null)
            {
                transaction.Rollback();
                transaction.Dispose();
                transaction = null;
                Dispose();
            }
        }

        /// <summary>
        /// 如果没有开启事务就自动释放资源，关闭连接，否则在提交或回滚事务的时候释放
        /// </summary>
        public void Dispose()
        {
            if (transaction == null)
            {
                if (connection != null)
                {
                    connection.Dispose();
                    connection.Close();
                    connection = null;
                }
            }
        }        

        private DbCommand CreateCommand(CommandType cmdType, string cmdText, params DbParameter[] cmdParas)
        {
            DbCommand mand = connection.CreateCommand();
            mand.CommandText = cmdText;
            mand.CommandType = cmdType;
            mand.Parameters.AddRange(cmdParas);
            if (transaction != null) mand.Transaction = transaction;
            return mand;
        }

        /// <summary>
        /// 返回一个数据集
        /// </summary>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParas"></param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(CommandType cmdType, string cmdText, params DbParameter[] cmdParas)
        {
            try
            {
                OpenConnection();
                DbCommand mand = CreateCommand(cmdType, cmdText, cmdParas);
                DbDataAdapter data = factory.CreateDataAdapter();
                data.SelectCommand = mand;
                DataSet ds = new DataSet();
                data.Fill(ds);
                return ds;
            }
            finally { Dispose(); }
        }

        /// <summary>
        /// 返回受影响的行数
        /// </summary>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParas"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(CommandType cmdType, string cmdText, params DbParameter[] cmdParas)
        {
            try
            {
                OpenConnection();
                DbCommand mand = CreateCommand(cmdType, cmdText, cmdParas);
                return mand.ExecuteNonQuery();
            }
            finally { Dispose(); }
        }

        /// <summary>
        /// 返回结果集中第一行第一列
        /// </summary>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParas"></param>
        /// <returns></returns>
        public object ExecuteScalar(CommandType cmdType, string cmdText, params DbParameter[] cmdParas)
        {
            try
            {
                OpenConnection();
                DbCommand mand = CreateCommand(cmdType, cmdText, cmdParas);
                return mand.ExecuteScalar();
            }
            finally { Dispose(); }
        }

        /// <summary>
        /// 返回泛型集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParas"></param>
        /// <returns></returns>
        public IList<T> ExecuteReaderList<T>(CommandType cmdType, string cmdText, params DbParameter[] cmdParas)
        {
            try
            {
                OpenConnection();
                DbCommand mand = CreateCommand(cmdType, cmdText, cmdParas);
                DbDataReader reader = mand.ExecuteReader();
                IList<T> list = ToList<T>(reader);
                return list;
            }
            finally { Dispose(); }
        }

        /// <summary>
        /// 调用存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="param"></param>
        public void ExcuteProcedure(string procName, DbParameter[] param)
        {
            OpenConnection();
            DbCommand mand = CreateCommand(CommandType.StoredProcedure, procName, param);
            mand.ExecuteNonQuery();
        }

        /// <summary>
        /// 返回一个DbReader
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public DbDataReader ExcuteReader(string cmdText)
        {
            OpenConnection();
            DbCommand mand = CreateCommand(CommandType.Text,cmdText);
            DbDataReader reader = mand.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        /// <summary>
        /// 返回一个对象 如数据库无结果返回将抛出异常
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParas"></param>
        /// <returns></returns>
        public T ExecuteReaderObject<T>(CommandType cmdType, string cmdText, params DbParameter[] cmdParas)
        {
            try
            {
                return ExecuteReaderList<T>(cmdType, cmdText, cmdParas)[0];
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 反射创建泛型集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        private IList<T> ToList<T>(DbDataReader reader)
        {
            Type type = typeof(T);
            IList<T> list = null;
            if (type.IsValueType || type == typeof(string))
                list = CreateValue<T>(reader, type);
            else
                list = CreateObject<T>(reader, type);
            reader.Dispose();
            reader.Close();
            return list;
        }

        private IList<T> CreateObject<T>(DbDataReader reader, Type type)
        {
            IList<T> list = new List<T>();
            PropertyInfo[] properties = type.GetProperties();
            string name = string.Empty;
            while (reader.Read())
            {
                T local = Activator.CreateInstance<T>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    name = reader.GetName(i);
                    foreach (PropertyInfo info in properties)
                    {
                        if (name.ToLower().Equals(info.Name.ToLower()))
                        {                             
                            //某些时候手工修改数据库可能发生不可转换的数据类型
                            if (reader[info.Name] != DBNull.Value)
                            {
                                info.SetValue(local, Convert.ChangeType(reader[info.Name], info.PropertyType), null);
                            }
                            break; 
                        }
                    }
                }
                list.Add(local);
            }
            return list;
        }

        private IList<T> CreateValue<T>(DbDataReader reader, Type type)
        {
            IList<T> list = new List<T>();
            while (reader.Read())
            {
                T local = (T)Convert.ChangeType(reader[0], type, null);
                list.Add(local);
            }
            return list;
        }        
    }
}
