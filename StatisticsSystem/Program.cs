using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using log4net;
using System.Reflection;

namespace StatisticsSystem
{
  static class Program
  {
    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    static void Main()
    {
      try
      {
        //设置应用程序处理异常方式：ThreadException处理 
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        //处理UI线程异常 
        Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        //处理非UI线程异常 
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LoginForm());
        Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
      }
      catch (Exception ex)
      {
        log(ex, string.Empty);
        //string str = GetExceptionMsg(ex, string.Empty);
        //MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
      log(e.Exception, e.ToString());
      //string str = GetExceptionMsg(e.Exception, e.ToString());
      //MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
      //LogManager.WriteLog(str); 
    }
    static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      log(e.ExceptionObject as Exception, e.ToString());
      //string str = GetExceptionMsg(e.ExceptionObject as Exception, e.ToString());
      //MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    /// <summary> 
    /// 生成自定义异常消息 
    /// </summary> 
    /// <param name="ex">异常对象</param> 
    /// <param name="backStr">备用异常消息：当ex为null时有效</param> 
    /// <returns>异常字符串文本</returns> 
    static string GetExceptionMsg(Exception ex, string backStr)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("****************************异常文本****************************");
      sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
      if (ex != null)
      {
        sb.AppendLine("【异常类型】：" + ex.GetType().Name);
        sb.AppendLine("【异常信息】：" + ex.Message);
        sb.AppendLine("【堆栈调用】：" + ex.StackTrace);
      }
      else
      {
        sb.AppendLine("【未处理异常】：" + backStr);
      }
      sb.AppendLine("***************************************************************");
      return sb.ToString();
    }
    public static void log(Exception ex, string backStr)
    {
      //Application.Run(new MainForm());
      //创建日志记录组件实例
      ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
      //记录错误日志
      log.Error("error", new Exception(ex.Message));
      //记录严重错误
      //log.Fatal("fatal", new Exception("发生了一个致命错误"));
      //记录一般信息
      //log.Info("info");
      //记录调试信息
      //log.Debug("debug");
      //记录警告信息
      //log.Warn("warn");
      //Console.WriteLine("日志记录完毕。");
      //Console.Read();
      MessageBox.Show(ex.Message);
    }
  }
}
