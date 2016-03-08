using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Control;
using StatisticsSystem.WordExport;
using StatisticsSystem.TableConfig;
using StatisticsSystem.SystemConfig;
using StatisticsSystem.Fetch;
using StatisticsSystem.Check;

namespace StatisticsSystem
{
  public partial class MainForm : Form
  {
    #region 初始化
    public interface ICipherInputForm
    {
      ToolStrip CipherToolStrip
      {
        get;
      }
    }

    private void MainForm_MdiChildActivate(object sender, EventArgs e)
    {
      //CTools为MDI窗体工具栏
      ToolStripManager.RevertMerge(CTools);
      if (this.ActiveMdiChild != null)
      {
        if ((ActiveMdiChild as ICipherInputForm).CipherToolStrip != null)
        {
          ToolStripManager.Merge((ActiveMdiChild as ICipherInputForm).CipherToolStrip, CTools);
        }
      }
      //若子窗体无工具栏时,隐藏该工具栏
      if (CTools.Items.Count > 0)
        CTools.Visible = true;
      else
        CTools.Visible = false;

    }

    private int _version = 0;

    public int Version
    {
      get { return _version; }
      set { _version = value; }
    }
    private string _loginname = "";

    public string Loginname
    {
      get { return _loginname; }
      set { _loginname = value; }
    }

    private static MainForm m_Current;

    public static MainForm Current
    {
      get
      {
        if (m_Current == null)
        {
          m_Current = new MainForm();
        }

        return m_Current;
      }
    }

    public MainForm()
    {
      InitializeComponent();
      //Common.Control.FormCommon.ShowSingleWindow(typeof(NewForm), Current, "");
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult result;
      result = MessageBox.Show("确定要退出吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (result == DialogResult.OK)
      {
        //关闭连接
      }
      else
      {

        e.Cancel = true;
      }
    }
    #endregion

    #region 窗口
    private void m_Horizontal_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void m_Vertical_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }

    private void m_Cascade_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }
    #endregion

    #region 公式配置

    private void menuTableFormulaCconfig_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(2);
      form.ShowDialog();
    }

    private void menuFetch_Click(object sender, EventArgs e)
    {
      FetchConfigForm form = new FetchConfigForm();
      form.ShowDialog();
    }

    private void menuCheckConfig_Click(object sender, EventArgs e)
    {
      CheckConfigForm form = new CheckConfigForm();
      form.ShowDialog();

    }

    private void menuWord_Click(object sender, EventArgs e)
    {
      WordFormulaConfigForm form = new WordFormulaConfigForm();
      form.ShowDialog();
    }


    private void menuTableFormulaCconfigCol_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(9);
      form.ShowDialog();

    }

    private void menuCheckConfigCOL_Click(object sender, EventArgs e)
    {

      CheckConfigFormCol form = new CheckConfigFormCol();
      form.ShowDialog();
    }
    #endregion

    #region 报表
    private void menuQuit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void menuNewForm_Click(object sender, EventArgs e)
    {
      Common.Control.FormCommon.ShowSingleWindow(typeof(NewForm), Current, "");
      //NewForm form = new NewForm();
      //form.ShowDialog();
      //Form1 form = new Form1();
      //form.MdiParent = Current;
      //form.Show();
    }

    private void menuOpenForm_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(1);
      form.ShowDialog();
    }

    private void menuitemInherit_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(3);
      form.ShowDialog();
    }

    private void menuZBBMDWConfig_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(6);
      form.ShowDialog();
    }

    private void menuColDWConfig_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(7);
      form.ShowDialog();

    }

    private void menuDWPerson_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(5);
      form.ShowDialog();
    }

    private void menuColChoice_Click(object sender, EventArgs e)
    {
      OpenForm form = new OpenForm(8);
      form.ShowDialog();

    }
    #endregion

    #region 帮助
    private void menuAbout_Click(object sender, EventArgs e)
    {
      AboutBox1 form = new AboutBox1();
      form.ShowDialog();
    }

    private void menuHelp_Click(object sender, EventArgs e)
    {
      string str = System.IO.Directory.GetCurrentDirectory() + "\\统计系统cs用户手册.doc";
      //System.IO.File.Open(str, System.IO.FileMode.Open);
      System.Diagnostics.Process.Start(str);
    }
    #endregion

    #region 常用工具
    private void menuCalculate_Click(object sender, EventArgs e)
    {
      OpenTool("calc.exe");
    }

    private void OpenTool(string exe)
    {
      System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
      System.Diagnostics.Process proc = new System.Diagnostics.Process();

      //设置外部程序名(记事本用 notepad.exe 计算器用 calc.exe) 
      info.FileName = exe;

      //设置外部程序的启动参数

      info.Arguments = "";

      //设置外部程序工作目录为c:\windows

      info.WorkingDirectory = "c:/windows/";

      try
      {
        // 
        //启动外部程序 
        // 
        proc = System.Diagnostics.Process.Start(info);
      }
      catch
      {
        MessageBox.Show("系统找不到指定的程序文件", "错误提示！");
        return;
      }
    }

    private void menuNotebook_Click(object sender, EventArgs e)
    {
      OpenTool("notepad.exe");
    }

    private void menuExplore_Click(object sender, EventArgs e)
    {
      OpenTool("iexplore.exe");
    }
    #endregion

    #region 系统管理

    private void menuWordConfig_Click(object sender, EventArgs e)
    {
      WordConfigForm form = new WordConfigForm();
      form.ShowDialog();
    }
    private void menuDatebase_Click(object sender, EventArgs e)
    {
      DatabaseConfigForm form = new DatabaseConfigForm();
      form.ShowDialog();
    }

    private void menuExport_Click(object sender, EventArgs e)
    {
      ExportExcelForm form = new ExportExcelForm();
      form.ShowDialog();
    }

    private void menuItemVersion_Click(object sender, EventArgs e)
    {
      DialogResult result;
      result = MessageBox.Show("确定要生成吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (result == DialogResult.OK)
      {
        BLL.XMLVERSION bll = new BLL.XMLVERSION();
        string version = DateTime.Now.Year.ToString();
        DataSet ds = bll.GetListVersion();
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
          if (dr[0].ToString() == version)
          {
            MessageBox.Show("本年度已有版本");
            return;
          }
        }
        if (bll.CreateNewVersion(version))
        {
          List<Model.XMLVERSION> modelXMl = bll.GetModelList(" year=" + version);
          for (int i = 0; i < modelXMl.Count; i++)
          {
            Classes.SaveCell.SaveXML(modelXMl[i], version);
          }
          MessageBox.Show("保存成功");
        }
      }
      #region
      //string localFilePath = "", fileNameExt = "", newFileName = "", FilePath = "";
      //saveFileDialog.Filter = "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
      //设置默认文件名（可以不设置）
      //saveFileDialog.FileName = "webgridheader_" + DateTime.Now.Year.ToString();
      ////主设置默认文件extension（可以不设置）
      //saveFileDialog.DefaultExt = "xml";
      // Show save file dialog box
      //DialogResult result = saveFileDialog.ShowDialog();
      //点了保存按钮进入
      //if (result == DialogResult.OK)
      //{
      //获得文件路径
      //localFilePath = saveFileDialog.FileName.ToString();

      //获取文件名，不带路径
      //fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);

      //获取文件路径，不带文件名
      //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

      //给文件名前加上时间
      //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt;

      //在文件名里加字符
      //saveFileDialog.FileName.Insert(1,"dameng");
      //为用户使用 SaveFileDialog 选定的文件名创建读/写文件流。
      //System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();//输出文件

      //fs可以用于其他要写入的操作

      //MessageBox.Show(localFilePath);
      //System.IO.File.Copy(Classes.Path.GetPath(), localFilePath);
      //}
      #endregion
    }

    private void menuCurrentVersion_Click(object sender, EventArgs e)
    {
      DialogResult result;
      result = MessageBox.Show("确定要生成吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (result == DialogResult.OK)
      {
        //关闭连接
        BLL.XMLVERSION bll = new BLL.XMLVERSION();
        List<Model.XMLVERSION> modelXMl = bll.GetModelList(" year=" + Version);
        for (int i = 0; i < modelXMl.Count; i++)
        {
          Classes.SaveCell.SaveXML(modelXMl[i], MainForm.Current.Version.ToString());
        }
        MessageBox.Show("保存成功");
      }
    }

    private void mennuTableTypeConfig_Click(object sender, EventArgs e)
    {
      TableTypeConfigForm form = new TableTypeConfigForm();
      form.ShowDialog();
    }

    private void menuChangePwd_Click(object sender, EventArgs e)
    {
      ChangePwdForm form = new ChangePwdForm();
      form.ShowDialog();
    }
    #endregion


  }
}
