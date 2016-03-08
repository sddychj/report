using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace StatisticsSystem.WordExport
{
  public partial class WordFormulaConfigForm : Form
  {
    BLL.ZN_DOCJSXX bll_jsxx = new BLL.ZN_DOCJSXX();
    BLL.ZN_DOCJSXXYSJ bll_ysj = new BLL.ZN_DOCJSXXYSJ();
    public WordFormulaConfigForm()
    {
      InitializeComponent();
      BindDW();
      BindGrid();
    }

    private void BindGrid()
    {
      DataSet ds = bll_jsxx.GetList(" docbm='" + cobMB.SelectedValue.ToString() + "' and SQMC like '%" + txtMC.Text + "%'");
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = ds.Tables[0];
    }

    private void BindDW()
    {
      DataSet dsDOC = new DataSet();
      BLL.ZN_DOCBM bll = new BLL.ZN_DOCBM();
      dsDOC = bll.GetList("");
      cobMB.DataSource = dsDOC.Tables[0];
      cobMB.DisplayMember = "DOCMC";
      cobMB.ValueMember = "DOCBM";
      //DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dataGridView1.Columns[1];
      //col.DataSource = dsDOC.Tables[0];
      //col.ValueMember = "DOCBM";
      //col.DisplayMember = "DOCMC";
      //col.DataPropertyName = "DOCBM";
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (cobMB.Items.Count == 0)
      { return; }
      if (e.RowIndex < 0)
      { return; }
      //if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "")
      //{
      //  MessageBox.Show("请选择模板名称");
      //  return;
      //}

      if (e.ColumnIndex == dataGridView1.Columns["colEdit"].Index)
      {
        string sqmc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        if (sqmc == "")
        {
          MessageBox.Show("书签名称不能为空");
          return;
        }
        string charword = ConfigurationManager.AppSettings["wordchar"].ToString();
        string start = sqmc.Substring(0, charword.Length);
        string end = sqmc.Substring(sqmc.Length - charword.Length, charword.Length);
        if (start != charword || end != charword)
        {
          MessageBox.Show("书签名称必须以" + charword + "开头结尾");
          return;
        }
        Classes.FormulaCheck check = new Classes.FormulaCheck();
        string formula = dataGridView1.CurrentRow.Cells[3].Value.ToString().ToUpper();
        if (string.IsNullOrEmpty(formula))
        {
          MessageBox.Show("请录入公式");
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
        string jyxxid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        Model.ZN_DOCJSXX model = new Model.ZN_DOCJSXX();
        model.JSMS = formula.ToUpper();
        //DataGridViewComboBoxCell DgvCell = this.dataGridView1.CurrentRow.Cells[1] as DataGridViewComboBoxCell;
        //model.DOCBM = DgvCell.Value.ToString();
        model.DOCBM = cobMB.SelectedValue.ToString();
        model.SQMC = sqmc;
        if (jyxxid == "")
        {
          model.DOCJSXXID = bll_jsxx.GetMaxID();
          bll_jsxx.Add(model); ;
        }
        else
        {
          model.DOCJSXXID = int.Parse(jyxxid);
          bll_jsxx.Update(model);
        }
        WordEditForm form = new WordEditForm(model);
        form.ShowDialog();
        //BindGrid();
      }
      else if (e.ColumnIndex == dataGridView1.Columns["colDel"].Index)
      {
        string jyxxid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        DialogResult result;
        result = MessageBox.Show("确定要删除" + jyxxid + "吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        if (result == DialogResult.OK)
        {
          if (!string.IsNullOrEmpty(jyxxid))
          {
            Delete(int.Parse(jyxxid));
          }
        }
      }

    }

    private void Delete(int jyxxid)
    {
      bll_jsxx.Delete(jyxxid);
      if (bll_ysj.Delete(jyxxid))
        MessageBox.Show("删除成功！");
      BindGrid();
    }

    private void cobMB_SelectedIndexChanged(object sender, EventArgs e)
    {
      BindGrid();
    }

    private void btnQuote_Click(object sender, EventArgs e)
    {
      string bbbm = cobMB.SelectedValue.ToString();
      if (string.IsNullOrEmpty(bbbm))
        return;
      WordTableQuoteForm form = new WordTableQuoteForm(bbbm);
      form.ShowDialog();
    }

    private void btnQuery_Click(object sender, EventArgs e)
    {
      BindGrid();
    }
  }
}
