using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.Formula
{
  public partial class FormulaConditionChoice : Form
  {
    private string tableNum;
    private int mode = 0;//2计算公式配置，9整列公式配置
    public FormulaConditionChoice()
    {
      InitializeComponent();
    }
    public FormulaConditionChoice(string _tableNum, int flag)
    {
      InitializeComponent();
      tableNum = _tableNum;
      BindDW();
      this.mode = flag;
      if (mode == 2)
      {
        BindYear();
      }
      else if (mode == 9) { BindYearCol(); }
    }

    private void BindDW()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList("");
      cbbDW.DataSource = ds.Tables[0];
      cbbDW.ValueMember = "DWBM";
      cbbDW.DisplayMember = "DWMC";
    }

    private void BindYear()
    {
      BLL.ENCO_JSXX bll = new BLL.ENCO_JSXX();
      DataSet ds = bll.GetYear();
      cbbYear.DataSource = ds.Tables[0];
      cbbYear.ValueMember = "NF";
      cbbYear.DisplayMember = "NF";
      if (cbbYear.Items.Count > 0)
        cbbYear.SelectedIndex = 0;
    }

    private void BindYearCol()
    {
      BLL.ENCO_JSXX bll = new BLL.ENCO_JSXX();
      DataSet ds = bll.GetYear();
      cbbYear.DataSource = ds.Tables[0];
      cbbYear.ValueMember = "NF";
      cbbYear.DisplayMember = "NF";
      if (cbbYear.Items.Count > 0)
        cbbYear.SelectedIndex = 0;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
      string dw = cbbDW.SelectedValue.ToString();
      string year = cbbYear.Text;
      string month = cbbMonth.Text;
      if (mode == 2)
      {
        FormulaConfigForm form = new FormulaConfigForm(tableNum, dw, year, month);
        form.MdiParent = MainForm.Current;
        form.WindowState = FormWindowState.Maximized;
        form.Show();
      }
      else if (mode == 9)
      {
        FormulaConfigFormCol form = new FormulaConfigFormCol(tableNum, dw, year, month);
        form.MdiParent = MainForm.Current;
        form.WindowState = FormWindowState.Maximized;
        form.Show();
      }
      this.Hide();
      this.Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
