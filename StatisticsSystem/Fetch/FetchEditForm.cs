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
  public partial class FetchEditForm : Form
  {
    private string tableNum;
    public FetchEditForm()
    {
      InitializeComponent();
    }

    public FetchEditForm(string tablenum)
    {
      InitializeComponent();
      this.tableNum = tablenum;
      BindTargetDW();
      BindSourDW();
      BindBBLX();
      BindSourTable();
      Init();
    }

    private void Init()
    {
      BLL.TIQU bll = new BLL.TIQU();
      DataSet ds = bll.Get_tq(tableNum);
      if (ds.Tables[0].Rows.Count > 0)
      {
        lbTableNum.Text = ds.Tables[0].Rows[0]["targetbbbh"].ToString() + ds.Tables[0].Rows[0]["targetbbmc"].ToString();
        if (ds.Tables[0].Rows[0]["targetdwbm"].ToString() != "")
        {
          cobTargetDW.SelectedValue = ds.Tables[0].Rows[0]["targetdwbm"].ToString();
          cobSourseDW.SelectedValue = ds.Tables[0].Rows[0]["soursedwbm"].ToString();
          cobTableType.SelectedValue = ds.Tables[0].Rows[0]["soursebblx"].ToString();
          cobTableNum.SelectedValue = ds.Tables[0].Rows[0]["soursetable"].ToString();
        }
      }
    }

    private void BindTargetDW()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList_xssx("");

      cobTargetDW.DisplayMember = "DS.DWMC";
      cobTargetDW.ValueMember = "DS.DWBM";
      cobTargetDW.DataSource = ds;
    }

    private void BindSourDW()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList("");

      cobSourseDW.DisplayMember = "DS.DWMC";
      cobSourseDW.ValueMember = "DS.DWBM";
      cobSourseDW.DataSource = ds;
    }

    private void BindBBLX()
    {
      BLL.ENCO_BBLX bll = new BLL.ENCO_BBLX();
      DataSet ds = bll.GetList("");
      DataRow dr = ds.Tables[0].NewRow();
      dr["ID"] = DBNull.Value;
      dr["LBMC"] = "";
      ds.Tables[0].Rows.InsertAt(dr, 0);
      cobTableType.DataSource = ds;
      cobTableType.DisplayMember = "DS.LBMC";
      cobTableType.ValueMember = "DS.ID";
    }

    private void BindSourTable()
    {
      string bblx = cobTableType.SelectedValue.ToString();
      BLL.CODE_BBBMB bll = new BLL.CODE_BBBMB();
      DataSet ds = bll.GetList(" bblx='" + bblx + "'");
      DataRow dr = ds.Tables[0].NewRow();
      dr["BBBM"] = "";
      dr["BBWHMC"] = "";
      ds.Tables[0].Rows.InsertAt(dr, 0);
      cobTableNum.DataSource = ds;
      cobTableNum.DisplayMember = "DS.BBWHMC";
      cobTableNum.ValueMember = "DS.BBBM";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (cobSourseDW.SelectedValue.ToString() == "")
      {
        MessageBox.Show("请选择目标单位");
        return;
      }
      if (cobTargetDW.SelectedValue.ToString() == "")
      {
        MessageBox.Show("请选择源单位");
        return;
      }
      if (cobTableType.SelectedValue.ToString() == "")
      {
        MessageBox.Show("请选择报表类型");
        return;
      }
      if (cobTableNum.SelectedValue.ToString() == "")
      {
        MessageBox.Show("请选择报表");
        return;
      }
      Model.TIQU model = new Model.TIQU();
      model.TARGETDWBM = cobTargetDW.SelectedValue.ToString();
      model.TARGETTABLE = tableNum;
      model.SOURSETABLE = cobTableNum.SelectedValue.ToString();
      model.SORSEDWBM = cobSourseDW.SelectedValue.ToString();
      BLL.TIQU bll = new BLL.TIQU();
      bll.Delete(tableNum);
      bll.Add(model);
      MessageBox.Show("保存成功");
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cobTableType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cobTableType.SelectedIndex >= 0) { BindSourTable(); }

    }

    private void FetchEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
        BLL.TIQU bll = new BLL.TIQU();
        bll.Delete(tableNum);
        MessageBox.Show("删除成功");
        cobSourseDW.SelectedIndex = 0;
        cobTableNum.SelectedIndex = 0;
        cobTableType.SelectedIndex = 0;
        cobTargetDW.SelectedIndex = 0;
      }
    }
  }
}
