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
  public partial class DWPersonConfig : Form
  {
    public DWPersonConfig()
    {
      InitializeComponent();
      BindDw();
      BindCob();
    }

    private void BindCob()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList("");
      cobDW.DataSource = ds.Tables[0];
      cobDW.ValueMember = "DWBM";
      cobDW.DisplayMember = "DWMC";
    }

    private void BindDw()
    {
      //BLL.XMLVERSION_DW bll = new BLL.XMLVERSION_DW();
      //DataSet ds = bll.GetListDWMC();
      //dataGridView1.AutoGenerateColumns = false;
      //dataGridView1.DataSource = ds.Tables[0];
    }

    private void btnSave_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
