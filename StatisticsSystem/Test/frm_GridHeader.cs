using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Common.Control;
using StatisticsSystem.BLL;
//using StatisticsSystem.Calculate;

namespace StatisticsSystem
{
  public partial class frm_GridHeader : Form
  {
    public frm_GridHeader()
    {
      InitializeComponent();
    }

    private void btn_Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_Excel_Click(object sender, EventArgs e)
    {
      //if (txt_SheetName.Text == "")
      //{
      //  MessageBox.Show("文本框不能为空");
      //  return;
      //}
      ////string s_soursepath = "d:\\华北工程公司统计\\a.xml";
      //string s_savepath = Application.StartupPath;
      //string s = Classes.InitCell.ExcelToXml(txt_SheetName.Text, "TG02", s_savepath);
      ////MessageBox.Show(s);
      ////FormCommon.ShowSingleWindow(typeof(frm_Grid), MainForm.Current, "");
      ////this.Hide();
      //this.Close();
    }
  }
}
