using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.DWPersonConfig
{
  public partial class DW_ZBBBMConfigForm : Form, MainForm.ICipherInputForm
  {
    public ToolStrip CipherToolStrip
    {
      get
      {
        return Tools;
      }
    }
    public string tableNum = "";
    public string dwmc = "", zbbm = "";
    public DW_ZBBBMConfigForm()
    {
      InitializeComponent();
    }
    public DW_ZBBBMConfigForm(string _tableNum)
    {
      InitializeComponent();
      tableNum = _tableNum;
      BindDW();
      BindGrid();
    }

    private void BindDW()
    {
      BLL.XMLVERSION_DW_HIDEROW bll = new BLL.XMLVERSION_DW_HIDEROW();
      DataSet ds = bll.GetListDWMC(tableNum, MainForm.Current.Version.ToString());
      //DataRow dr = ds.Tables[0].NewRow();
      //dr["DWBM"] = "";
      //dr["DWMC"] = "";
      //ds.Tables[0].Rows.InsertAt(dr, 0);
      cobDW.DataSource = ds.Tables[0];
      cobDW.ValueMember = "DWBM";
      cobDW.DisplayMember = "DWMC";
    }

    protected void BindGrid()
    {
      if (cobDW.SelectedIndex < 0)
        return;
      BLL.XMLVERSION_DW_HIDEROW bll = new BLL.XMLVERSION_DW_HIDEROW();
      Model.XMLVERSION_DW_HIDEROW model = bll.GetModel(MainForm.Current.Version, tableNum, cobDW.SelectedValue.ToString());
      if (model == null)
      {
        return;
      }
      BLL.ENCO_ZBBMB bll_zbbm = new BLL.ENCO_ZBBMB();
      DataSet ds = bll_zbbm.GetList("  bbbm='" + tableNum + "'");

      string[] hideRow = model.HIDDENROW.Split(new char[] { ',' });
      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        if (hideRow.Contains(ds.Tables[0].Rows[i]["zbbm"].ToString()))
        { ds.Tables[0].Rows[i]["xsyc"] = "隐藏"; }
        else
        { ds.Tables[0].Rows[i]["xsyc"] = "显示"; }
      }
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = ds.Tables[0];
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      BLL.XMLVERSION_DW_HIDEROW bll = new BLL.XMLVERSION_DW_HIDEROW();
      Model.XMLVERSION_DW_HIDEROW model = bll.GetModel(MainForm.Current.Version, tableNum, cobDW.SelectedValue.ToString());
      //string[] hideList = model.HIDDENROW.Split(new char[] { ',' });
      model.HIDDENROW = "";
      for (int i = 0; i < dataGridView1.Rows.Count; i++)
      {
        string xsyc = dataGridView1.Rows[i].Cells[2].Value.ToString();
        if (xsyc == "隐藏")
        {
          string zbbm = dataGridView1.Rows[i].Cells[0].Value.ToString();
          //if (!hideList.Contains(zbbm))
          //{
          model.HIDDENROW += "," + zbbm;
          //}
        }
      }
      model.HIDDENROW = model.HIDDENROW.Trim(new char[] { ',' });
      bll.Update(model);
      MessageBox.Show("保存成功");
    }

    private void cobDW_SelectedIndexChanged(object sender, EventArgs e)
    {
      BindGrid();
    }
  }
}
