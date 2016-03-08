using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace StatisticsSystem.Formula
{
  public partial class TableQuoteForm : Form
  {
    StatisticsSystem.BLL.CODE_BBBMB bll_bbbm = new BLL.CODE_BBBMB();
    StatisticsSystem.BLL.INFO_YYBB_List bll_yybb_list = new BLL.INFO_YYBB_List();
    StatisticsSystem.BLL.INFO_YYBB bll_yybb = new BLL.INFO_YYBB();
    string tableNum = "";

    #region 初始化
    public TableQuoteForm()
    {
      InitializeComponent();
    }

    public TableQuoteForm(string _tableNum)
    {
      InitializeComponent();
      this.tableNum = _tableNum;
      Model.CODE_BBBMB model = bll_bbbm.GetModel(_tableNum);
      this.Text = "报表引用：" + model.BBWH + model.BBMC;
      InitTargetListView();
      InitSourceListView();
    }

    private void InitTargetListView()
    {
      listViewTarget.Columns.Add("报表编码");
      listViewTarget.Columns.Add("报表类型");
      listViewTarget.Columns.Add("报表表号");
      listViewTarget.Columns.Add("报表名称");
      listViewTarget.Columns[0].Width = 0;
      listViewTarget.Columns[1].Width = 120;
      listViewTarget.Columns[2].Width = 60;
      listViewTarget.Columns[3].Width = 500;

      DataSet ds = bll_yybb.GetList_BBBM(tableNum);
      DataTable dt = ds.Tables[0];
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        ListViewItem item = new ListViewItem();
        item.SubItems.Clear();
        item.SubItems[0].Text = dt.Rows[i]["yybbbm"].ToString();
        item.SubItems.Add(dt.Rows[i]["lbmc"].ToString());
        item.SubItems.Add(dt.Rows[i]["bbwh"].ToString());
        item.SubItems.Add(dt.Rows[i]["bbmc"].ToString());
        listViewTarget.Items.Add(item);
      }
      if (listViewTarget.Items.Count > 0)
      {
        listViewTarget.Items[0].Selected = true;
      }
    }

    private void InitSourceListView()
    {
      listViewSourse.Columns.Add("报表编码");
      listViewSourse.Columns.Add("报表类型");
      listViewSourse.Columns.Add("报表表号");
      listViewSourse.Columns.Add("报表名称");
      listViewSourse.Columns[0].Width = 0;
      listViewSourse.Columns[1].Width = 120;
      listViewSourse.Columns[2].Width = 60;
      listViewSourse.Columns[3].Width = 500;

      DataSet ds = bll_bbbm.GetList_BBLX("");
      DataTable dt = ds.Tables[0];
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        ListViewItem item = new ListViewItem();
        item.SubItems.Clear();
        item.SubItems[0].Text = dt.Rows[i]["bbbm"].ToString();
        item.SubItems.Add(dt.Rows[i]["lbmc"].ToString());
        item.SubItems.Add(dt.Rows[i]["bbwh"].ToString());
        item.SubItems.Add(dt.Rows[i]["bbmc"].ToString());
        listViewSourse.Items.Add(item);
      }
      //从source中移除target的项目
      ListView.ListViewItemCollection items_target = listViewTarget.Items;
      foreach (ListViewItem item in listViewSourse.Items)
      {
        foreach (ListViewItem item_target in items_target)
        {
          if (item.SubItems[0].Text == item_target.SubItems[0].Text)
          {
            listViewSourse.Items.Remove(item);
            //break;
          }
        }
      }
      if (listViewSourse.Items.Count > 0)
      {
        listViewSourse.Items[0].Selected = true;
      }
    }
    #endregion

    #region 左移右移
    private void btnRight_Click(object sender, EventArgs e)
    {
      ListViewItemMove(listViewSourse.SelectedItems, listViewSourse, listViewTarget);
    }

    private void btnRightAll_Click(object sender, EventArgs e)
    {
      ListViewItemMove(listViewSourse.Items, listViewSourse, listViewTarget);
    }

    private void btnLeft_Click(object sender, EventArgs e)
    {
      ListViewItemMove(listViewTarget.SelectedItems, listViewTarget, listViewSourse);
    }

    private void btnLeftAll_Click(object sender, EventArgs e)
    {
      ListViewItemMove(listViewTarget.Items, listViewTarget, listViewSourse);
    }

    private void listViewSourse_DoubleClick(object sender, EventArgs e)
    {
      ListViewItemMove(listViewSourse.SelectedItems, listViewSourse, listViewTarget);
    }

    private void listViewTarget_DoubleClick(object sender, EventArgs e)
    {
      ListViewItemMove(listViewTarget.SelectedItems, listViewTarget, listViewSourse);
    }

    private void ListViewItemMove(IEnumerable items, ListView source, ListView target)
    {
      foreach (ListViewItem item in items)
      {
        source.Items.Remove(item);
        target.Items.Add(item);
      }
      if (target.Items.Count > 0)
      {
        target.Items[0].Selected = true;
      }
    }
    #endregion

    #region 完成 关闭
    private void btnFinish_Click(object sender, EventArgs e)
    {
      Model.INFO_YYBB_List model = new Model.INFO_YYBB_List(listViewTarget.Items.Count);
      for (int i = 0; i < listViewTarget.Items.Count; i++)
      {
        model.BBBM[i] = tableNum;
        model.YYBBBM[i] = listViewTarget.Items[i].SubItems[0].Text;
      }
      bll_yybb.Delete(tableNum);
      if (listViewTarget.Items.Count == 0)
      {
        MessageBox.Show("保存成功");
        return;
      }
      if (bll_yybb_list.Add(model))
      {
        MessageBox.Show("保存成功");
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TableQuoteForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult result;
      result = MessageBox.Show("确定要退出吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (result == DialogResult.OK)
      {
      }
      else
      {
        e.Cancel = true;
      }
    }
    #endregion
  }
}
