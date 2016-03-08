using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StatisticsSystem
{

  public partial class frm_Cell : Form
  {
    public frm_Cell()
    {
      InitializeComponent();
      //axCell1.SetRows(6, 0);
      //axCell1.SetCols(8, 0);
      //axCell1.MergeCells(1, 1, 2, 2);
      //axCell1.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
      //string path = Application.StartupPath + "\\GridHeader.xml";
      //StatisticsSystem_BLL.TableColumnCreate.CreateTable_cell(axCell1, path, "TG02");
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      string s = "\"我的函数\"  String txInterFace(double n)";
      s = s + "\r\n" + "BEGIN_HELP";
      s = s + "\r\n" + " String txInterFace(double n)";
      s = s + "\r\n" + "函数返回字符串 n为数字";
      s = s + "\r\n" + "END_HELP";
      axCell1.DefineFunctions(s);
    }

    private void axCell1_CalcFunc(object sender, AxCELL50Lib._DCell2000Events_CalcFuncEvent e)
    {
      if (e.name == "txInterFace")
      {
        int a = 0;
        double d = axCell1.GetFuncDoublePara(0, ref a);
        MessageBox.Show(d.ToString());
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string path = Application.StartupPath + "\\GridHeader.xml";
      //StatisticsSystem_BLL.TableColumnCreate.CreateTable_cell(axCell1, path, "TG02");

      //Form f;
      //((Form2)f).ShowSingleWindow(typeof(Form2));
      //int a = axCell1.OpenFile(@"D:\a.cll", "");
      //string s = axCell1.SaveToExcelXML();
      //MessageBox.Show(s);
      //string strPath = @"D:\我的文档\a.xml";
      //string value = s;

      //if (!Directory.Exists(Path.GetDirectoryName(strPath)))
      //{
      //  Directory.CreateDirectory(Path.GetDirectoryName(strPath));
      //}

      //File.AppendAllText(strPath, value, Encoding.Default);
    }

    private void 报表ToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
