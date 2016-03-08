using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace XBExport
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string name = Process.GetCurrentProcess().ProcessName;
            int id = Process.GetCurrentProcess().Id;
            Process[] prc = Process.GetProcesses();
            foreach (Process pr in prc)
            {
                if ((name == pr.ProcessName) && (pr.Id != id))
                {
                    MessageBox.Show("程序已经有一个实例正在运行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    System.Environment.Exit(0);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EEMain());
        }
    }
}
