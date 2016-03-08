using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.Fetch
{
  public partial class FetchConfigForm : Form
  {
    public FetchConfigForm()
    {
      InitializeComponent();
      BindBBLX();
      BindGrid();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;

    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      string tablenum=dataGridView1.CurrentRow.Cells[0].Value.ToString();
      FetchEditForm form = new FetchEditForm(tablenum);
      form.ShowDialog();
      BindGrid();
    }

    private void BindBBLX()
    {
      BLL.ENCO_BBLX bll = new BLL.ENCO_BBLX();
      DataSet ds = bll.GetList("");
      cobBBLX.DisplayMember = "DS.LBMC";
      cobBBLX.ValueMember = "DS.ID";
      cobBBLX.DataSource = ds;
    }

    private void BindGrid()
    {
      string bblx = cobBBLX.SelectedValue.ToString();
      BLL.TIQU bll = new BLL.TIQU();
      DataTable dt = bll.GetList_tq(bblx).Tables[0];
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = dt;

    }

    private void cobBBLX_SelectedValueChanged(object sender, EventArgs e)
    {
      if (cobBBLX.SelectedIndex >= 0)
        BindGrid();
    }
  }
}
