using System;
using System.Data;
using System.Configuration;
using log4net;
using log4net.Appender;

/// <summary>
/// Debug 的摘要说明
/// </summary>
namespace SSEC.Tools
{
    public class Debug
    {
        //Debug
        //public static Debug debug = null;
        private static Debug _instance;
        //logger
        private ILog logger = LogManager.GetLogger(typeof(Debug));
        //同步
        private static object _synRoot = new Object();

        public Debug()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        //得到唯一实例
        public static Debug GetInstance()
        {
            if (_instance == null)
            {
                lock (_synRoot)
                {
                    _instance = new Debug();
                }
            }
            return _instance;
        }

        //清除对象
        public static void Reset(object obj)
        {
            _instance = null;
        }


        ///日志记录器1
        ///日志等级：Info
        public void log(String s)
        {
            lock (_synRoot)
            {
                logger.Info("Message=<<" + s + ">>");
            }
        }


        ///日志记录器2
        ///日志等级：Info
        public void log(Object obj, String s)
        {
            lock (_synRoot)
            {
                logger.Info("Type Name=<<" + obj.GetType() + ">>  Message=<<" + s + ">>");
            }
        }

        ///日志记录器3
        ///日志等级：Error
        public void log(Object obj, String s, Exception ex)
        {
            lock (_synRoot)
            {
                logger.Error("Type Name=<<" + obj.GetType() + ">>  Message=<<" + s + ">>", ex);
            }
        }

    }

}
