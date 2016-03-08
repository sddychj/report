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
  public partial class TableTypeConfigForm : Form
  {
    BLL.ENCO_BBLX bll = new BLL.ENCO_BBLX();
    public TableTypeConfigForm()
    {
      InitializeComponent();
      BindGrid();
    }

    private void BindGrid()
    {
      DataSet ds = bll.GetList("");
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = ds.Tables[0];
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
      {
        string id = dataGridView1.Rows[i].Cells[0].Value.ToString();
        if (string.IsNullOrEmpty(id))
        {
          Model.ENCO_BBLX model = new Model.ENCO_BBLX();
          model.ID = bll.GetMaxID("");
          model.LBMC = dataGridView1.Rows[i].Cells[1].Value.ToString();
          bll.Add(model);
        }
        else
        {
          Model.ENCO_BBLX model = new Model.ENCO_BBLX();
          model.ID = int.Parse(id);
          model.LBMC = dataGridView1.Rows[i].Cells[1].Value.ToString();
          bll.Update(model);
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
          bll.Delete(int.Parse(id));
          BindGrid();
        }
      }
      else
      {
      }

    }
  }
}
