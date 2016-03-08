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
  public partial class DWChoiceForm : Form
  {
    public DWChoiceForm()
    {
      InitializeComponent();
    }

    protected void BindCh()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList("");
      ds.Tables[0].Rows.RemoveAt(0);
      this.checkedListBox1.DataSource = ds.Tables[0];
      checkedListBox1.ValueMember = "DWBM";
      checkedListBox1.DisplayMember = "DWMC";

      BLL.XMLVERSION_DW_HIDEROW bll_dw = new BLL.XMLVERSION_DW_HIDEROW();
      DW_ZBBBMConfigForm formO = (DW_ZBBBMConfigForm)this.Owner;
      for (int i = 0; i < checkedListBox1.Items.Count; i++)
      {
        DataRowView dv = (DataRowView)checkedListBox1.Items[i];
        Model.XMLVERSION_DW_HIDEROW model_dw = bll_dw.GetModel(MainForm.Current.Version, dv["dwbm"].ToString(), formO.tableNum);
        if (model_dw != null)
        {
          string[] hideRow = model_dw.HIDDENROW.Split(new char[] { ',' });
          if (!hideRow.Contains(formO.zbbm))
          {
            checkedListBox1.SetItemChecked(i, true);
          }
        }
        else
        { checkedListBox1.SetItemChecked(i, true); }
      }
      //当全选时，设置为全部选
      if (checkedListBox1.CheckedItems.Count == checkedListBox1.Items.Count)
      {
        for (int i = 0; i < checkedListBox1.Items.Count; i++)
        {
          checkedListBox1.SetItemChecked(i, false);
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      BLL.XMLVERSION_DW_HIDEROW bll_dw = new BLL.XMLVERSION_DW_HIDEROW();
      DW_ZBBBMConfigForm formO = (DW_ZBBBMConfigForm)this.Owner;
      Model.XMLVERSION_DW_HIDEROW model_dw = new Model.XMLVERSION_DW_HIDEROW();
      if (checkedListBox1.CheckedItems.Count != 0)  //
      {
        for (int i = 0; i < checkedListBox1.Items.Count; i++)
        {
          if (!checkedListBox1.GetItemChecked(i))
          {
            DataRowView dv = (DataRowView)checkedListBox1.Items[i];
            model_dw = bll_dw.GetModel(MainForm.Current.Version, dv["dwbm"].ToString(), formO.tableNum);
            if (model_dw == null)
            {
              model_dw = GetModelDw();
              model_dw.DWBM = dv["dwbm"].ToString();
            }
            string[] hideRow = model_dw.HIDDENROW.Split(new char[] { ',' });
            if (!hideRow.Contains(formO.zbbm))
            {
              model_dw.HIDDENROW += "," + formO.zbbm;
              bll_dw.Delete(MainForm.Current.Version, dv["dwbm"].ToString(), formO.tableNum);
              bll_dw.Add(model_dw);
            }
          }
        }
      }
      this.Close();
    }
    private Model.XMLVERSION_DW_HIDEROW GetModelDw()
    {
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      DW_ZBBBMConfigForm formO = (DW_ZBBBMConfigForm)this.Owner;
      Model.XMLVERSION model = bll.GetModel(MainForm.Current.Version, formO.tableNum);
      Model.XMLVERSION_DW_HIDEROW modelDW = new Model.XMLVERSION_DW_HIDEROW();

      modelDW.YEAR = model.YEAR;
      modelDW.BBBM = model.BBBM;
      //modelDW.CAPTION = model.CAPTION;
      //modelDW.COORDINATES = model.COORDINATES;
      //modelDW.HIDDENCOLUMN = model.HIDDENCOLUMN;
      modelDW.HIDDENROW = model.HIDDENROW;
      //modelDW.NOTALLOWEDITROW = model.NOTALLOWEDITROW;
      //modelDW.LOCKCELL = model.LOCKCELL;
      //modelDW.COLUMNWIDTH = model.COLUMNWIDTH;
      //modelDW.NAMEHIERARCHY = model.NAMEHIERARCHY;
      //modelDW.SELECTFIELD = model.SELECTFIELD;
      //modelDW.ORDERBY = model.ORDERBY;
      //modelDW.ROWCOUNT = model.ROWCOUNT;
      //modelDW.COLUMNCOUNT = model.COLUMNCOUNT;
      //modelDW.TITLE = model.Title;
      //modelDW.NOTALLOWEDITCOLUMN = model.NotAllowEditColumn;
      return modelDW;
    }

    private void DWChoiceForm_Load(object sender, EventArgs e)
    {
      BindCh();

    }

    private void DWChoiceForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      string dwmc = "";
      DW_ZBBBMConfigForm formO = (DW_ZBBBMConfigForm)this.Owner;

      for (int i = 0; i < checkedListBox1.Items.Count; i++)
      {
        if (checkedListBox1.GetItemChecked(i))
        {
          DataRowView dv = (DataRowView)checkedListBox1.Items[i];
          dwmc += dv["dwmc"].ToString() + ",";
        }
      }
      dwmc = dwmc.Trim(new char[] { ',' });
      formO.dwmc = dwmc;
    }
  }
}
