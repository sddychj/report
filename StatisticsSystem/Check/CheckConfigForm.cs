using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace StatisticsSystem.Check
{
  public partial class CheckConfigForm : Form
  {
    BLL.JYXX bll_jyxx = new BLL.JYXX();
    BLL.JYXXYSJ bll_ysj = new BLL.JYXXYSJ();
    #region
    public CheckConfigForm()
    {
      InitializeComponent();
      this.Text = "报表校验配置";
      BindBBLX();
      BindBB(cobBBLX.SelectedValue.ToString());
      BindGrid(cobTable.SelectedValue.ToString());
    }

    private void BindBBLX()
    {
      BLL.ENCO_BBLX bll = new BLL.ENCO_BBLX();
      DataSet ds = bll.GetList("");
      cobBBLX.DisplayMember = "DS.LBMC";
      cobBBLX.ValueMember = "DS.ID";
      cobBBLX.DataSource = ds;
    }

    private void BindBB(string bblx)
    {
      if (string.IsNullOrEmpty(bblx))
      { return; }
      BLL.CODE_BBBMB bll = new BLL.CODE_BBBMB();
      DataSet ds = bll.GetList(" bblx=" + bblx);
      cobTable.DisplayMember = "DS.BBWHMC";
      cobTable.ValueMember = "DS.BBBM";
      cobTable.DataSource = ds;
    }

    private void BindGrid(string bb)
    {
      if (string.IsNullOrEmpty(bb))
      { return; }
      DataSet ds = bll_jyxx.GetList_DW(" bbbm='" + bb + "'");
      openTableGrid.AutoGenerateColumns = false;
      openTableGrid.DataSource = ds.Tables[0];

    }
    #endregion

    private void btnTableQuote_Click(object sender, EventArgs e)
    {
      string bbbm = cobTable.SelectedValue.ToString();
      if (string.IsNullOrEmpty(bbbm))
        return;
      CheckTableQuote form = new CheckTableQuote(bbbm);
      form.ShowDialog();
    }

    private void cobBBLX_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cobBBLX.SelectedIndex > -1)
      {
        string bblx = cobBBLX.SelectedValue.ToString();
        BindBB(bblx);
      }
    }

    private void cobTable_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cobTable.SelectedIndex > -1)
      {
        string table = cobTable.SelectedValue.ToString();
        string bblx = cobTable.SelectedValue.ToString();
        BindGrid(table);
      }
    }

    private void btnCheck_Click(object sender, EventArgs e)
    {

    }

    private void openTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == openTableGrid.Columns["colEdit"].Index)
      {
        Classes.FormulaCheck check = new Classes.FormulaCheck();
        string formula = openTableGrid.CurrentRow.Cells[2].Value.ToString().ToUpper();
        if (string.IsNullOrEmpty(formula))
        {
          MessageBox.Show("请录入校验公式");
          return;
        }
        string formulaNum = check.ConvertCharToNum(formula);
        //if (check.IsRepeat(formula))
        //{
        //  MessageBox.Show("存在重复字符");
        //  return;
        //}
        if (check.CheckFormula(formulaNum))
        {
          MessageBox.Show("公式格式有误");
          return;
        }
        string jyxxid = openTableGrid.CurrentRow.Cells[0].Value.ToString();
        string jymc = openTableGrid.CurrentRow.Cells[1].Value.ToString();
        if (jyxxid == "")
        { Add(formula, 0, jymc); }
        else
        { Update(formula, int.Parse(jyxxid), jymc); }
      }
      else if (e.ColumnIndex == openTableGrid.Columns["colDelete"].Index)
      {
        DialogResult result;
        result = MessageBox.Show("确定要删除吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        if (result == DialogResult.OK)
        {
          string jyxxid = openTableGrid.CurrentRow.Cells[0].Value.ToString();
          if (!string.IsNullOrEmpty(jyxxid))
          {
            Delete(int.Parse(jyxxid));
          }
        }
      }
      else if (e.ColumnIndex == openTableGrid.Columns["colSave"].Index)
      {
        Classes.FormulaCheck check = new Classes.FormulaCheck();
        string formula = openTableGrid.CurrentRow.Cells[2].Value.ToString().ToUpper();
        if (string.IsNullOrEmpty(formula))
        {
          MessageBox.Show("请录入校验公式");
          return;
        }
        string formulaNum = check.ConvertCharToNum(formula);
        //if (check.IsRepeat(formula))
        //{
        //  MessageBox.Show("存在重复字符");
        //  return;
        //}
        if (check.CheckFormula(formulaNum))
        {
          MessageBox.Show("公式格式有误");
          return;
        }
        string jyxxid = openTableGrid.CurrentRow.Cells[0].Value.ToString();
        string jymc = openTableGrid.CurrentRow.Cells[1].Value.ToString();
        Update_xx(formula, int.Parse(jyxxid), jymc);
        MessageBox.Show("保存成功");
      }
    }

    private void Add(string formula, int jyxxid, string jymc)
    {
      Model.JYXX model = new Model.JYXX();
      model.JYXXID = bll_jyxx.GetMaxID();
      model.JYMS = formula.ToUpper();
      model.JYMC = jymc;
      model.BBBM = cobTable.SelectedValue.ToString();
      bll_jyxx.Add(model);
      CheckEditForm form = new CheckEditForm(model);
      form.ShowDialog();
      //BindGrid(cobTable.SelectedValue.ToString());
    }

    private void Update(string formula, int jyxxid, string jymc)
    {
      Model.JYXX model = bll_jyxx.GetModel(jyxxid);
      model.JYXXID = jyxxid;
      model.JYMS = formula.ToUpper();
      model.JYMC = jymc;
      bll_jyxx.Update(model);
      CheckEditForm form = new CheckEditForm(model);
      form.ShowDialog();
      //BindGrid(cobTable.SelectedValue.ToString());
    }

    private void Update_xx(string formula, int jyxxid, string jymc)
    {
      Model.JYXX model = bll_jyxx.GetModel(jyxxid);
      model.JYXXID = jyxxid;
      model.JYMS = formula.ToUpper();
      model.JYMC = jymc;
      bll_jyxx.Update(model);
    }

    private void Delete(int jyxxid)
    {
      bll_jyxx.Delete(jyxxid);
      if (bll_ysj.Delete(jyxxid))
        MessageBox.Show("删除成功！");
      BindGrid(cobTable.SelectedValue.ToString());
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < openTableGrid.Rows.Count; i++)
      {
        string jymc = openTableGrid.Rows[i].Cells[1].Value.ToString();
        string jyid = openTableGrid.Rows[i].Cells[0].Value.ToString();
        Model.JYXX model = bll_jyxx.GetModel(int.Parse(jyid));
        model.JYXXID = int.Parse(jyid);
        //model.JYMS = formula.ToUpper();
        bll_jyxx.Update(model);
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {

      string table = cobTable.SelectedValue.ToString();
      string bblx = cobTable.SelectedValue.ToString();
      BindGrid(table);
    }
  }
}
