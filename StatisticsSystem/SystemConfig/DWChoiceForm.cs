using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.SystemConfig
{
  public partial class DWChoiceForm : Form, MainForm.ICipherInputForm
  {
    public ToolStrip CipherToolStrip
    {
      get
      {
        return Tools;
      }
    }
    private string tableNum;
    public DWChoiceForm()
    {
      InitializeComponent();
    }

    public DWChoiceForm(string _tableNum)
    {
      InitializeComponent();
      tableNum = _tableNum;
      this.Text = GetMC() + "单位选择";
      BindCh();
    }

    private string GetMC()
    {
      BLL.CODE_BBBMB bll = new BLL.CODE_BBBMB();
      Model.CODE_BBBMB model = bll.GetModel(tableNum);
      return model.BBMC;
    }

    protected void BindCh()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList("");
      ds.Tables[0].Rows.RemoveAt(0);
      this.checkedListBox1.DataSource = ds.Tables[0];
      checkedListBox1.ValueMember = "DWBM";
      checkedListBox1.DisplayMember = "DWMC";

      BLL.XMLVERSION_DW_HideCol bll_dw = new BLL.XMLVERSION_DW_HideCol();
      for (int i = 0; i < checkedListBox1.Items.Count; i++)
      {
        DataRowView dv = (DataRowView)checkedListBox1.Items[i];
        Model.XMLVERSION_DW_HideCol model_dw = bll_dw.GetModel(MainForm.Current.Version, dv["dwbm"].ToString(), tableNum);
        if (model_dw != null)
        {
          checkedListBox1.SetItemChecked(i, true);
        }
        else
        { checkedListBox1.SetItemChecked(i, false); }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      DialogResult result;
      result = MessageBox.Show("确定要保存吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (result == DialogResult.Cancel)
      {
        return;
      }
      BLL.XMLVERSION_DW_HideCol bll_dw = new BLL.XMLVERSION_DW_HideCol();
      Model.XMLVERSION_DW_HideCol model_dw = new Model.XMLVERSION_DW_HideCol();
      for (int i = 0; i < checkedListBox1.Items.Count; i++)
      {
        DataRowView dv = (DataRowView)checkedListBox1.Items[i];
        if (checkedListBox1.GetItemChecked(i))
        {
          model_dw = bll_dw.GetModel(MainForm.Current.Version, dv["dwbm"].ToString(), tableNum);
          if (model_dw == null)
          {
            model_dw = GetModelDw();
            model_dw.DWBM = dv["dwbm"].ToString();
            bll_dw.Add(model_dw);
          }
        }
        else
        {
          bll_dw.Delete(MainForm.Current.Version, dv["dwbm"].ToString(), tableNum);
        }
      }
      MessageBox.Show("保存成功");
    }

    private Model.XMLVERSION_DW_HideCol GetModelDw()
    {
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      Model.XMLVERSION model = bll.GetModel(MainForm.Current.Version, tableNum);
      Model.XMLVERSION_DW_HideCol modelDW = new Model.XMLVERSION_DW_HideCol();

      modelDW.YEAR = model.YEAR;
      modelDW.BBBM = model.BBBM;
      //modelDW.CAPTION = model.CAPTION;
      //modelDW.COORDINATES = model.COORDINATES;
      modelDW.HIDDENCOLUMN = model.HIDDENCOLUMN;
      //modelDW.HIDDENROW = model.HIDDENROW;
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

    }

    private void DWChoiceForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
