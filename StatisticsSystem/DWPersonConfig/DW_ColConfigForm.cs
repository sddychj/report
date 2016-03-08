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
  public partial class DW_ColConfigForm : Form, MainForm.ICipherInputForm
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
    public DW_ColConfigForm()
    {
      InitializeComponent();
    }

    public DW_ColConfigForm(string _tableNum)
    {
      InitializeComponent();
      tableNum = _tableNum;
      BindDW();
      BindGrid();
    }

    private void BindDW()
    {
      BLL.XMLVERSION_DW_HideCol bll = new BLL.XMLVERSION_DW_HideCol();
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
      BLL.XMLVERSION_DW_HideCol bll = new BLL.XMLVERSION_DW_HideCol();
      Model.XMLVERSION_DW_HideCol model = bll.GetModel(MainForm.Current.Version, cobDW.SelectedValue.ToString(), tableNum);
      if (model == null)
      {
        return;
      }
      BLL.ENCO_BBZD bll_zd = new BLL.ENCO_BBZD();
      DataSet ds = bll_zd.GetList("  bbbm='" + tableNum + "'and zdsx>13 ");
      string[] nameList = model.HIDDENCOLUMN.Split(new char[] { ',' });

      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        //string[] nameList = GetHideColName(model.HIDDENCOLUMN.Split(new char[] { ',' }), model.SELECTFIELD.Split(new char[] { ',' }));
        if (nameList.Contains(ds.Tables[0].Rows[i]["zd"].ToString()))
        { ds.Tables[0].Rows[i]["sfyc"] = "是"; }
        else
        { ds.Tables[0].Rows[i]["sfyc"] = "否"; }
      }
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = ds.Tables[0];
    }
    //字段顺序转为列名，为解决之前hidecol用数字的缺点
    private string[] GetHideColName(string[] hideColList, string[] fieldList)
    {
      string[] nameList = new string[hideColList.Length];
      for (int i = 0; i < hideColList.Length; i++)
      {
        nameList[i] = fieldList[int.Parse(hideColList[i])];
      }
      return nameList;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void cobDW_SelectedIndexChanged(object sender, EventArgs e)
    {
      BindGrid();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      BLL.XMLVERSION_DW_HideCol bll = new BLL.XMLVERSION_DW_HideCol();
      Model.XMLVERSION_DW_HideCol model = bll.GetModel(MainForm.Current.Version, cobDW.SelectedValue.ToString(), tableNum);
      //string[] hideList = model.HIDDENCOLUMN.Split(new char[] { ',' });
      //int rowid = dataGridView1.Rows.Count + 13;
      model.HIDDENCOLUMN = "DWBM,ZBBM,NF,YF,CJ,HC,ZBDM,QYJY,XSYC,SFKBJ,SFMJ,rowid";
      for (int i = 0; i < dataGridView1.Rows.Count; i++)
      {
        string xsyc = dataGridView1.Rows[i].Cells[2].Value.ToString();
        if (xsyc == "是")
        {
          //string zbbm = dataGridView1.Rows[i].Cells[0].Value.ToString();
          //if (!hideList.Contains((i + 13).ToString()))
          //{
          model.HIDDENCOLUMN += "," + dataGridView1.Rows[i].Cells[0].Value.ToString();
          //}
        }
      }

      bll.Update(model);
      MessageBox.Show("保存成功");
    }
  }
}
