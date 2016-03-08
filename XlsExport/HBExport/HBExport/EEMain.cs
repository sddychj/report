using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Data.OracleClient;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;


namespace XBExport
{
    public partial class EEMain : Form
    {
        public EEMain()
        {
            InitializeComponent();
        }


        //退出的菜单
        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_Quit_Click(sender, e);
        }

        /// <summary>
        /// 退出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_Quit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        //关于
        private void ToolStripMenuItem_about_Click(object sender, EventArgs e)
        {
            AboutForm aboutFrm = new AboutForm();
            aboutFrm.ShowDialog(this);
        }



        /// <summary>
        /// 显示主窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_Show_Click(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
        }


        /// <summary>
        /// 主窗体退出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EEMain_Load(object sender, EventArgs e)
        {
            //1=样式
            string skinFile = Application.StartupPath + "\\Skin\\" + ConfigurationManager.AppSettings["APPS_MyFormSkin"].ToString();
            if (System.IO.File.Exists(skinFile))
            {
                //窗体皮肤
                this.skinEngine1.SkinFile = skinFile;
            }

            //2=基础参数设置
            setLoadData();

            //3=定时器启动
            btnStart_Click(sender, e);
        }


        /// <summary>
        /// 加载基础参数
        /// </summary>
        private void setLoadData()
        {
            //定时器间隔
            txtTimerInterval.Text = ConfigurationManager.AppSettings["APPS_TimerInterval"].ToString();
                                    
            
            //导出文件存放路径
            txtSaveDocPath.Text = ConfigurationManager.AppSettings["APPS_SaveDocPath"].ToString();

            
        }

        

        /// <summary>
        /// 清空显示记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearLstBox_Click(object sender, EventArgs e)
        {
            lstBoxReport.Items.Clear();
        }


        /// <summary>
        /// 保存时间间隔设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimerInterval.Text))
            {
                MessageBox.Show("定时器间隔值均不能为空!");
                return;
            }

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //定时器间隔
            cfa.AppSettings.Settings["APPS_TimerInterval"].Value = txtTimerInterval.Text;

            //保存
            cfa.Save(ConfigurationSaveMode.Modified);
            //强制重新载入AppSettings配置节
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("保存成功！");
        }


        /// <summary>
        /// 定时器启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer_Task.Interval = Convert.ToInt32(
                ConfigurationManager.AppSettings["APPS_TimerInterval"].ToString());//5分钟=5*60*1000
            timer_Task.Enabled = true;
            btnStart.Visible = false;
            btnStop.Visible = true;
            lblShowMsg.Text = "定时器已启动，执行中。。。";
            SSEC.Tools.Debug.GetInstance().log(lblShowMsg.Text);
        }


        /// <summary>
        /// 定时器关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer_Task.Enabled = false;
            btnStart.Visible = true;
            btnStop.Visible = false;
            lblShowMsg.Text = "定时器已关闭";
        }

        /// <summary>
        /// 保存导出参数到配置文件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveCfg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSaveDocPath.Text))
            {
                MessageBox.Show("配置文件名称、文件导出路径均不能为空!");
                return;
            }

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            
            //Word导出路径
            cfa.AppSettings.Settings["APPS_SaveDocPath"].Value = txtSaveDocPath.Text;

            //保存
            cfa.Save(ConfigurationSaveMode.Modified);
            //强制重新载入AppSettings配置节
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("保存成功！");
        }

        
        /// <summary>
        /// 文件路径选择对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = txtSaveDocPath.Text;
            folderDlg.ShowDialog();
            txtSaveDocPath.Text = folderDlg.SelectedPath;
            //MessageBox.Show(folderDlg.SelectedPath);
        }

       
        /// <summary>
        /// 打开指定的目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtSaveDocPath.Text);
        }

        
        /// <summary>
        /// 任务栏图标双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
        }

       

        /// <summary>
        /// 定时器执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Task_Tick(object sender, EventArgs e)
        {
            timer_Task.Enabled = false;

            //1==超过设定就清空
            if (lstBoxReport.Items.Count > 100)
            {
                lstBoxReport.Items.Clear();
            }

            //2==启动一个后台线程进行处理，优化性能
            if (!bgWorkerReport.IsBusy)
            {
                //进度条
                progressBarReport.Value = 0;
                //开启异步线程
                bgWorkerReport.RunWorkerAsync();
            }

            timer_Task.Enabled = true;
        }


        /// <summary>
        /// 执行定时器设定的任务,由后台线程调用
        /// </summary>
        private void doBackgroundTask()
        {
            try
            {
                string[] sArray;

                string sql = "select * from EXCELEXPORT where STATUS = 0 ";
                DataSet ds = Xiaovcn.DB.PPADBHelper.ExecuteDataSet(sql.ToString());


                XBExport.App_Code.EXCELEXPORT tempM = new App_Code.EXCELEXPORT();

                string snf, syf, sdwbm;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    long i = 0;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        i++;
                        sArray = dr["BBBMLIST"].ToString().Split(',');
                        snf = dr["NF"].ToString();
                        syf = dr["YF"].ToString();
                        sdwbm = dr["DWBM"].ToString();
                        tempM = App_Code.EXCELEXPORT.GetModel(sdwbm.ToString(), Convert.ToInt32(snf.ToString()), Convert.ToInt32(syf.ToString()));
                        tempM.STATUS = 1;
                        tempM.FINISHTIME = DateTime.Now.ToString();
                        App_Code.EXCELEXPORT.Update(tempM);
                        App_Code.EEHelper.DataTableToExcel(System.Windows.Forms.Application.StartupPath + @"\ExcelTemplate\ExcelInfo.xml", sArray, snf.ToString(), syf.ToString(), sdwbm.ToString(), txtSaveDocPath.Text.ToString().Trim());
                        
                        string reportResult = string.Format("单位编码：{0},年份：{1},月份{2}.时间：{3}",
                                sdwbm, snf, syf, DateTime.Now);
                        //进度条显示一下当前进度
                        bgWorkerReport.ReportProgress(Convert.ToInt32(((i * 1.0) / (ds.Tables[0].Rows.Count * 1.0) * 100)), reportResult);

                        
                    }
                    
                }

            }
            catch (Exception ex)
            {
                SSEC.Tools.Debug.GetInstance().log(this, "执行doBackgroundTask方法出现错误！", ex);
            }
            finally
            {
                App_Code.EEHelper.Quit();
            }
               
        }


        /// <summary>
        /// 后台线程启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgWorkerReport_DoWork(object sender, DoWorkEventArgs e)
        {
            //执行业务逻辑
            doBackgroundTask();
        }

        /// <summary>
        /// 后台线程进度监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgWorkerReport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //进度显示
            progressBarReport.Value = e.ProgressPercentage;
            //记入日志
            lstBoxReport.Items.Insert(0, e.UserState);
        }

        /// <summary>
        /// 后台线程完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgWorkerReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarReport.Value = 100;
        }

        private void btnPathSelect_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = txtSaveDocPath.Text;
            folderDlg.ShowDialog();
            txtSaveDocPath.Text = folderDlg.SelectedPath;
        }

        private void btnSaveCfg_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSaveDocPath.Text))
            {
                MessageBox.Show("配置文件名称、文件导出路径均不能为空!");
                return;
            }

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            //Word导出路径
            cfa.AppSettings.Settings["APPS_SaveDocPath"].Value = txtSaveDocPath.Text;

            //保存
            cfa.Save(ConfigurationSaveMode.Modified);
            //强制重新载入AppSettings配置节
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("保存成功！");
        }

        private void btnOpenDirectory_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtSaveDocPath.Text);
        }

    }
}
