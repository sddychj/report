using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.WordExport
{
  public partial class WordConfigForm : Form
  {
    BLL.ZN_DOCBM bll = new BLL.ZN_DOCBM();
    BLL.ZN_DOCDYTBDW bll_dw = new BLL.ZN_DOCDYTBDW();
    public WordConfigForm()
    {
      InitializeComponent();
      BindGrid();
    }

    private void BindGrid()
    {
      DataSet ds = bll.GetList("");
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = ds.Tables[0];
      BindDW();
    }

    private void BindDW()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList("");
      DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dataGridView1.Columns[4];
      col.DataSource = ds.Tables[0];
      col.ValueMember = "DWBM";
      col.DisplayMember = "DWMC";
      col.DataPropertyName = "DWBM";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
      {
        string id = dataGridView1.Rows[i].Cells[0].Value.ToString();
        if (id == "")
        {
          MessageBox.Show("编码不能为空");
          break;
        }
        DataGridViewComboBoxCell DgvCell = this.dataGridView1.Rows[i].Cells[4] as DataGridViewComboBoxCell;
        string dwbm = DgvCell.Value == null ? "" : DgvCell.Value.ToString();
        //if (string.IsNullOrEmpty(dwbm))
        //{
        //  MessageBox.Show("请选择单位");
        //  break;
        //}
        if (!bll.Exists(id))
        {
          Model.ZN_DOCBM model = new Model.ZN_DOCBM();
          model.DOCBM = id;
          model.DOCMC = dataGridView1.Rows[i].Cells[1].Value.ToString();
          model.DOTMC = dataGridView1.Rows[i].Cells[2].Value.ToString();
          model.DOCZQ = dataGridView1.Rows[i].Cells[3].Value.ToString();
          bll.Add(model);
          //if (!string.IsNullOrEmpty(dwbm))
          //{
          //  Model.ZN_DOCDYTBDW model_dw = new Model.ZN_DOCDYTBDW();
          //  model_dw.DOCBM = id;
          //  model_dw.DWBM = DgvCell.Value.ToString();
          //  bll_dw.Add(model_dw);
          //}
        }
        else
        {
          Model.ZN_DOCBM model = new Model.ZN_DOCBM();
          model.DOCBM = id;
          model.DOCMC = dataGridView1.Rows[i].Cells[1].Value.ToString();
          model.DOTMC = dataGridView1.Rows[i].Cells[2].Value.ToString();
          model.DOCZQ = dataGridView1.Rows[i].Cells[3].Value.ToString();
          bll.Update(model);
          //if (!string.IsNullOrEmpty(dwbm))
          //{
          //  Model.ZN_DOCDYTBDW model_dw = new Model.ZN_DOCDYTBDW();
          //  model_dw.DOCBM = id;
          //  model_dw.DWBM = DgvCell.Value == null ? "" : DgvCell.Value.ToString();
          //  bll_dw.Update(model_dw);
          //}
          //else
          //{
          //  bll_dw.Delete(id, dwbm);
          //}
        }
      }
      BindGrid();
      MessageBox.Show("保存成功");
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TableTypeConfigForm_FormClosing(object sender, FormClosingEventArgs e)
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

    private void btnDelete_Click(object sender, EventArgs e)
    {
      DialogResult result;
      result = MessageBox.Show("确定要删除吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (result == DialogResult.OK)
      {
        string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        if (!string.IsNullOrEmpty(id))
        {
          bll.Delete(id);
          BindGrid();
        }
      }
      else
      {
      }

    }

  }
}
