using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StatisticsSystem.SystemConfig
{
  public partial class ExportExcelForm : Form
  {
    string nf = "";
    string yf = "";
    string tableNamePro = "";
    public ExportExcelForm()
    {
      InitializeComponent();
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      if (cobMonth.SelectedIndex < 0)
      {
        MessageBox.Show("月份格式不正确");
        return;
      }
      if (cobYear.SelectedIndex < 0)
      {
        MessageBox.Show("年份格式不正确");
        return;
      }
      //OpenFileDialog openFileDialog = new OpenFileDialog();
      //openFileDialog.InitialDirectory = "d:\\华北工程公司统计";//注意这里写路径时要用c:\\而不是c:\
      openFileDialog.Filter = "Excel文件|*.xls";
      //openFileDialog.RestoreDirectory = false;
      nf = cobYear.SelectedItem.ToString();
      yf = cobMonth.SelectedItem.ToString();
      openFileDialog.FilterIndex = 1;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        //MessageBox.Show("保存成功");
        string fName = openFileDialog.FileName;
        lbPath.Text = fName;
        string conn = GetConn(fName);
        string[] sheets = GetSheets(conn);
        progressBar1.Maximum = sheets.Length;
        btnExport.Enabled = false;
        worker.RunWorkerAsync();
      }
    }

    public string isDouble(string value)
    {
      string flag = "";
      try
      {
        flag = double.Parse(value).ToString("f4");
      }
      catch { flag = ""; }
      return flag;
    }

    public string GetConn(string filePath)
    {
      string connString = "Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " +
        filePath + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1;\"";
      return connString;
    }

    public DataTable GetExcelTables(string sheetName, string conn)
    {
      DataSet thisDataSet = new DataSet();
      try
      {
        OleDbConnection myConn = new OleDbConnection(conn);
        myConn.Open();
        OleDbDataAdapter thisAdapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "]", myConn);
        //OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
        thisAdapter.Fill(thisDataSet, "ExcelInfo");
        myConn.Close();
      }
      catch (OleDbException ex)
      {
        MessageBox.Show(ex.Message);
      }
      return thisDataSet.Tables[0];
    }

    public string[] GetSheets(string conn)
    {
      OleDbConnection myConn = new OleDbConnection(conn);
      myConn.Open();
      //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等
      DataTable dtSheetName = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
      //包含excel中表名的字符串数组
      string[] strTableNames = new string[dtSheetName.Rows.Count];
      for (int k = 0; k < dtSheetName.Rows.Count; k++)
      {
        strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
      }
      return strTableNames;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      worker.RunWorkerAsync();
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      e.Result = ComputeFibonacci(worker, e);
      //获取异步操作结果的值，当ComputeFibonacci(worker, e)返回时，异步过程结束
    }

    private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.progressBar1.Value = e.ProgressPercentage;
      //将异步任务进度的百分比赋给进度条
      this.lbPro.Text = "正在导入:" + tableNamePro;
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      MessageBox.Show("完成！");
      btnExport.Enabled = true;
      lbPro.Text = "";
    }

    private int ComputeFibonacci(object sender, DoWorkEventArgs e)
    {
      #region
      //for (int i = 0; i < 100; i++)
      //{
      //  //判断应用程序是否取消后台操作
      //  if (worker.CancellationPending)
      //  {
      //    e.Cancel = true;
      //  }
      //  else
      //  {
      //    worker.ReportProgress(i);
      //  }

      //  System.Threading.Thread.Sleep(100);
      //}
      #endregion

      string fName = openFileDialog.FileName;
      string conn = GetConn(fName);
      string[] sheets = GetSheets(conn);
      StringBuilder sql = new StringBuilder();
      string cell = "", zbbm = "";
      //string nf = cobYear.SelectedValue.ToString();
      //string yf = cobMonth.SelectedValue.ToString();

      BLL.ExcelExport bllExport = new BLL.ExcelExport();
      BLL.DWBMB bllDWBMB = new BLL.DWBMB();
      Dictionary<string, string> dicDWBM = bllDWBMB.GetDic();
      BLL.ENCO_BBZD bllBBZD = new BLL.ENCO_BBZD();
      BLL.CODE_BBBMB bllBBBMB = new BLL.CODE_BBBMB();
      Dictionary<string, string> dicBBBM = bllBBBMB.GetDic();
      BLL.ENCO_ZBBMB bllZBBMB = new BLL.ENCO_ZBBMB();

      for (int i = 0; i < sheets.Length; i++)
      {
        string sheetName = sheets[i].Trim(new char[] { '\'' });
        string[] tableNameList = sheetName.Split(new char[] { '_' });
        if (tableNameList.Length == 3)
        {
          this.tableNamePro = sheetName;
          string dwbm = dicDWBM[tableNameList[0]];
          string tableName = dicBBBM[tableNameList[1]];
          Dictionary<int, string> dicBBZD = bllBBZD.GetDic(tableName);
          Dictionary<int, string> dicZBBMB = bllZBBMB.GetZBBMB_hc(tableName);
          if (bllExport.Insert(tableName, dwbm, nf, yf))
          { }
          sql.Append("begin ");

          DataTable dt = GetExcelTables(sheetName, conn);
          try
          {
            for (int row = 6; row < dt.Rows.Count; row++)
            {
              cell = dt.Rows[row][0].ToString();
              if (!string.IsNullOrEmpty(cell))
              {
                string updatevalue = "";
                for (int col = 2; col < dt.Columns.Count; col++)
                {
                  cell = dt.Rows[row][col].ToString();
                  cell = isDouble(cell);
                  if (!string.IsNullOrEmpty(cell))
                  {
                    updatevalue += dicBBZD[col - 2] + " =" + cell + ",";
                  }
                }
                if (updatevalue != "")
                {
                  updatevalue = updatevalue.Trim(new char[] { ',' });
                  sql.Append("update " + tableName + " set ");
                  sql.Append(updatevalue);
                  sql.Append(" where dwbm='" + dwbm + "' ");
                  zbbm = dicZBBMB[row - 5];
                  sql.Append(" and zbbm='" + zbbm + "' ");
                  sql.Append(" and nf=" + nf + " and yf=" + yf + " ;");
                }
              }
            }
            sql.Append("null;");
            sql.Append("end;");
            bllExport.Update(sql.ToString());
            sql.Clear();
          }
          catch
          {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //记录错误日志
            log.Info(sheetName);
            MessageBox.Show("错误：" + sheetName);
            break;
          }
        }

        worker.ReportProgress(i);
      }
      return -1;
    }
  }
}
