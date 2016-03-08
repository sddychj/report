using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem
{
  public partial class frm_RowMergerView : Form
  {
    public frm_RowMergerView()
    {
      InitializeComponent();
      DataTable dt = new DataTable();
      dt.Columns.Add("1");
      dt.Columns.Add("2");
      dt.Columns.Add("3");
      dt.Columns.Add("4");
      dt.Rows.Add("中国", "上海", "5000", "7000");
      dt.Rows.Add("中国", "北京", "3000", "5600");
      dt.Rows.Add("美国", "纽约", "6000", "8600");
      dt.Rows.Add("美国", "华劢顿", "8000", "9000");
      dt.Rows.Add("英国", "伦敦", "7000", "8800");
      this.rowMergeView1.DataSource = dt;
      this.rowMergeView1.ColumnHeadersHeight = 40;
      this.rowMergeView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.rowMergeView1.MergeColumnNames.Add("Column1");
      this.rowMergeView1.AddSpanHeader(2, 2, "XXXX");
      addc();
    }
    private void addc()
    {
      dataGridView1.Columns.Add("aa","aa");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
      int index = this.dataGridView1.Rows.Add();
      this.dataGridView1.Rows[index].Cells[0].Value = "1";
      //this.dataGridView1.Rows[index].Cells[1].Value = "2";
      //this.dataGridView1.Rows[index].Cells[2].Value = "监听";

    }
  }
}
