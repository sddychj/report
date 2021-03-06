﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.Formula
{
  public partial class FormulaEditFormCol : Form
  {
    StatisticsSystem.BLL.INFO_YYBB bll_yybb = new BLL.INFO_YYBB();
    StatisticsSystem.BLL.ENCO_BBZD bll_zd = new BLL.ENCO_BBZD();
    BLL.ENCO_JSXX_COL bll_jsxx = new BLL.ENCO_JSXX_COL();
    BLL.ENCO_JSXXYSJ_COL bll_jsxxysj = new BLL.ENCO_JSXXYSJ_COL();
    //BLL.ENCO_SJJDJJBL bll_jsjd = new BLL.ENCO_SJJDJJBL();
    Model.ENCO_JSXX_COL model_jsxx = new Model.ENCO_JSXX_COL();
    Model.ENCO_JSXXYSJ_COL model_jsxxysj = new Model.ENCO_JSXXYSJ_COL();
    Model.XMLVERSION model_xml = new Model.XMLVERSION();
    //Model.ENCO_SJJDJJBL model_jsjd = new Model.ENCO_SJJDJJBL();
    //int cellHeaderRowCount = 0;//表头行数
    string[] columnNameList;//字段名列表
    int oldRow = 0, oldCol = 0;//存放上一次选择元素位置
    string oldTableName = "";//上次表

    #region 初始化
    public FormulaEditFormCol()
    {
      InitializeComponent();
    }

    public FormulaEditFormCol(Model.ENCO_JSXX_COL _model_jsxx)
    {
      InitializeComponent();

      model_jsxx = _model_jsxx;
      //model_jsjd = bll_jsjd.GetModel(model_jsxx.BBBM, model_jsxx.ZBBM, model_jsxx.ZD);
      //InitTargetListView();
      BindDW();
      InitListBox(model_jsxx.JSMS);
      //if (model_jsjd != null)
      //{
      //  txtComputePre.Text = model_jsjd.SJJD.ToString();
      //}
    }

    private void BindDW()
    {
      BLL.DWBMB bll = new BLL.DWBMB();
      DataSet ds = bll.GetList_xssx("");
      //DataRow dr = ds.Tables[0].NewRow();
      //dr["dwbm"] = "ALL";
      //dr["dwmc"] = "所有单位";
      //ds.Tables[0].Rows.InsertAt(dr, 1);
      cobDW.DisplayMember = "DS.DWMC";
      cobDW.ValueMember = "DS.DWBM";
      cobDW.DataSource = ds;
      if (!string.IsNullOrEmpty(model_jsxx.DWBM))
      {
        cobDW.SelectedValue = model_jsxx.DWBM;
      }
    }

    private void InitListBox(string formula)
    {
      formula = formula.ToUpper();
      for (int i = 0; i < formula.Length; i++)
      {
        char c = formula[i];
        if (Classes.CharList.HashChar.Contains(c))
        {
          if (!listBoxNum.Items.Contains(c.ToString()))
          {
            listBoxNum.Items.Add(c.ToString());
          }
        }
      }
      if (listBoxNum.Items.Count > 0)
      {
        listBoxNum.SelectedIndex = 0;
      }
    }

    private void InitTargetListView()
    {
      listViewQuoteTable.Clear();
      listViewQuoteTable.Columns.Add("报表编码");
      listViewQuoteTable.Columns.Add("报表类型");
      listViewQuoteTable.Columns.Add("报表表号");
      listViewQuoteTable.Columns.Add("报表名称");
      listViewQuoteTable.Columns[0].Width = 0;
      listViewQuoteTable.Columns[1].Width = 120;
      listViewQuoteTable.Columns[2].Width = 60;
      listViewQuoteTable.Columns[3].Width = 500;

      DataSet ds = bll_yybb.GetList_BBBM(model_jsxx.BBBM);
      DataTable dt = ds.Tables[0];
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        ListViewItem item = new ListViewItem();
        item.SubItems.Clear();
        item.SubItems[0].Text = dt.Rows[i]["yybbbm"].ToString();
        item.SubItems.Add(dt.Rows[i]["lbmc"].ToString());
        item.SubItems.Add(dt.Rows[i]["bbwh"].ToString());
        item.SubItems.Add(dt.Rows[i]["bbmc"].ToString());
        listViewQuoteTable.Items.Add(item);
      }
      listViewQuoteTable.Focus();
      //Model.ENCO_JSXXYSJ model_jsxxysj = bll_jsxxysj.GetModel(model_jsxx.JSXXID, listBoxNum.SelectedItem.ToString());
      //if (model_jsxxysj == null)
      //{
      //  listViewQuoteTable.Items[0].Selected = true;
      //}
      //else
      //{
      //  InitTargetListViewSelect(model_jsxxysj.OBBBM);
      //}
      //if (listViewQuoteTable.Items.Count > 0)
      //{
      //  listViewQuoteTable.Items[0].Selected = true;
      //}
    }

    private void InitTargetListViewSelect(string tableNum)
    {
      if (listViewQuoteTable.Items.Count == 0)
      {
        return;
      }
      listViewQuoteTable.Focus();
      foreach (ListViewItem li in listViewQuoteTable.Items)
      {
        if (li.SubItems[0].Text == tableNum)
        {
          li.Selected = true;
          break;
        }
      }
    }

    private void InitModel_YSJ()
    {
      if (listBoxNum.Items.Count == 0)
      { return; }
      model_jsxxysj = bll_jsxxysj.GetModel(model_jsxx.JSXXID, listBoxNum.SelectedItem.ToString());
      if (model_jsxxysj == null)
      { return; }
      cobDW.SelectedValue = model_jsxxysj.ODWBM;
      if (model_jsxxysj.ONF.ToString().Length > 0)
      {
        if (model_jsxxysj.ONF.Substring(0, 1) == "[")
        {
          txtYear.Text = model_jsxxysj.ONF.Substring(1, model_jsxxysj.ONF.Length - 2);
        }
        else
        {
          upDownYear.Value = int.Parse(model_jsxxysj.ONF);
        }
      }
      else
      { upDownYear.Value = 0; txtYear.Text = ""; }
      if (model_jsxxysj.OYF.ToString().Length > 0)
      {
        if (model_jsxxysj.OYF.Substring(0, 1) == "[")
        {
          txtMonth.Text = model_jsxxysj.OYF.Substring(1, model_jsxxysj.OYF.Length - 2);
        }
        else
        {
          upDownMonth.Value = int.Parse(model_jsxxysj.OYF);
        }
      }
      else
      { upDownMonth.Value = 0; txtMonth.Text = ""; }
    }

    private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
        e.Handled = false;
      else
        e.Handled = true;
    }
    #endregion

    #region 初始化报表
    private void InitCell()
    {
      axCellQuoteTable.ResetContent();
      ListView.SelectedListViewItemCollection list = listViewQuoteTable.SelectedItems;
      string selectTableNum = list[0].Text;
      //oldTableName = selectTableNum;
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      model_xml = bll.GetModel(MainForm.Current.Version, selectTableNum);
      //表头及指标
      axCellQuoteTable.SetCols(model_xml.COLUMNCOUNT + 2, 0);
      Classes.InitCell.InitCellHeader(axCellQuoteTable, model_xml);
      Classes.InitCell.InitCellIndex(axCellQuoteTable, selectTableNum, model_xml.ROWCOUNT);
      columnNameList = bll_zd.GetColumnName(selectTableNum);
      InitCellReadOnly(selectTableNum);
      InitTableHeaderColor(axCellQuoteTable);
      axCellQuoteTable.SetColHidden(1, 1);
      axCellQuoteTable.SetColHidden(2, 2);
      axCellQuoteTable.SetColHidden(3, 3);
      axCellQuoteTable.SetColHidden(4, 4);
      axCellQuoteTable.SetColHidden(6, 6);
      axCellQuoteTable.SetColHidden(7, 7);
      axCellQuoteTable.SetColHidden(10, 10);
      axCellQuoteTable.SetColHidden(11, 11);
      axCellQuoteTable.SetColHidden(12, 12);
      axCellQuoteTable.SetColHidden(13, 13);
      axCellQuoteTable.SetColHidden(axCellQuoteTable.GetCols(0) - 2, axCellQuoteTable.GetCols(0) - 2);
      axCellQuoteTable.SetFixedCol(1, 13);
    }

    private void InitCellReadOnly(string tableNum)
    {
      BLL.ENCO_BBZD bll = new BLL.ENCO_BBZD();
      List<Model.ENCO_BBZD> modelList = bll.GetModelList_BBBM(tableNum);
      for (int i = 0; i < modelList.Count; i++)
      {
        Model.ENCO_BBZD model = modelList[i];
        if (model.SJLX == "字符型")
        {
          axCellQuoteTable.SetCellInput(i + 1, -1, 0, 5);
        }
      }
      //禁用指标不可编辑
      BLL.ENCO_ZBBMB bll_zbbmb = new BLL.ENCO_ZBBMB();
      Dictionary<string, string> dicJY = bll_zbbmb.GetZBBMB_jy(tableNum);
      for (int i = 0; i < axCellQuoteTable.GetRows(0); i++)
      {
        if (dicJY.ContainsKey(axCellQuoteTable.GetCellString(axCellQuoteTable.GetCols(0) - 1, i, 0)))
        {
          for (int col = 13; col < axCellQuoteTable.GetCols(0); col++)
          {
            axCellQuoteTable.SetCellInput(col, i, 0, 5);
          }
        }
      }
    }

    private void InitCellSelect()
    {
      //Model.ENCO_JSXXYSJ model_jsxxysj = bll_jsxxysj.GetModel(model_jsxx.JSXXID, listBoxNum.SelectedItem.ToString());
      if (model_jsxxysj == null)
        return;
      ListViewItem item = listViewQuoteTable.SelectedItems[0];
      string currentTableName = item.SubItems[0].Text;
      if (model_jsxxysj.OBBBM != currentTableName)
        return;
      //单元格内显示元素
      for (int i = 0; i < columnNameList.Length; i++)
      {
        if (columnNameList[i] == model_jsxxysj.OZD)
        {
          oldCol = i + 1;
          break;
        }
      }
      for (int i = model_xml.ROWCOUNT + 1; i < axCellQuoteTable.GetRows(0); i++)
      {
        //if (axCellQuoteTable.GetCellString(axCellQuoteTable.GetCols(0) - 1, i, 0) == model_jsxxysj.OZBBM)
        //{
        //}
        oldRow = i;
        oldTableName = model_jsxxysj.OBBBM;
        axCellQuoteTable.SetCellString(oldCol, oldRow, 0, model_jsxxysj.ONAME);
        string s = Classes.InitCell.GetChar(oldCol);
        axCellQuoteTable.GoTo(s + oldRow, 0);
        axCellQuoteTable.SetCellTextColor(oldCol, oldRow, 0, axCellQuoteTable.FindColorIndex(255 * 65536, 1));
        break;
      }
    }

    private void InitTableHeaderColor(AxCELL50Lib.AxCell grid)
    {
      int color = 0 + 255 * 256 + 255 * 65536;
      for (int i = 1; i < model_xml.ROWCOUNT + 1; i++)
      {
        grid.SetCellBackColor(-1, i, 0, grid.FindColorIndex(color, 1));
      }
      for (int i = 0; i < grid.GetCols(0); i++)
      {
        int width = grid.GetColBestWidth(i);
        grid.SetColWidth(1, width, i, 0);
      }
      grid.SetCellInput(grid.GetCols(0) - 1, -1, 0, 5);
      grid.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
    }

    private void listViewQuoteTable_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listViewQuoteTable.SelectedItems.Count > 0)
      {
        InitCell();
        InitCellSelect();
      }
    }

    private void listBoxNum_SelectedIndexChanged(object sender, EventArgs e)
    {
      InitModel_YSJ();
      InitTargetListView();
      if (model_jsxxysj != null)
      {
        InitTargetListViewSelect(model_jsxxysj.OBBBM);
      }
      else
      {
        if (listViewQuoteTable.Items.Count > 0)
        {
          listViewQuoteTable.Focus();
          listViewQuoteTable.Items[0].Selected = true;
          //InitCell();
          //InitCellSelect();
        }
      }
      //InitCellSelect();
    }
    #endregion

    #region 右键
    private bool SaveJSXXYSJ()
    {
      bool flag = false;

      Model.ENCO_JSXXYSJ_COL model_jsxxysj = new Model.ENCO_JSXXYSJ_COL();
      model_jsxxysj.JSXXID = model_jsxx.JSXXID;
      model_jsxxysj.ODWBM = cobDW.SelectedValue.ToString();
      model_jsxxysj.ONAME = listBoxNum.SelectedItem.ToString();
      int currentCol = axCellQuoteTable.GetCurrentCol();
      int currentRow = axCellQuoteTable.GetCurrentRow();
      //model_jsxxysj.OZBBM = axCellQuoteTable.GetCellString(axCellQuoteTable.GetCols(0) - 1, currentRow, 0);
      model_jsxxysj.OZD = columnNameList[currentCol - 1];
      ListViewItem item = listViewQuoteTable.SelectedItems[0];
      model_jsxxysj.OBBBM = item.SubItems[0].Text;
      if (upDownYear.Value != 0)
      {
        model_jsxxysj.ONF = upDownYear.Value.ToString();
      }
      else
      {
        if (txtYear.Text != "")
        {
          if (!IsInt(txtYear.Text))
          {
            MessageBox.Show("年份必须为整数");
            return false;
          }
          model_jsxxysj.ONF = "[" + txtYear.Text + "]";
        }
      }
      if (upDownMonth.Value != 0)
      {
        model_jsxxysj.OYF = upDownMonth.Value.ToString();
      }
      else
      {
        if (txtMonth.Text != "")
        {
          if (!IsInt(txtMonth.Text))
          {
            MessageBox.Show("月份必须为整数");
            return false;
          }
          model_jsxxysj.OYF = "[" + txtMonth.Text + "]";
        }
      }
      //if (!string.IsNullOrEmpty(txtComputePre.Text))
      //{
      //  if (IsInt(txtComputePre.Text))
      //  {
      //    if (model_jsjd == null)
      //    {
      //      model_jsjd = new Model.ENCO_SJJDJJBL();
      //      model_jsjd.BBBM = model_jsxx.BBBM;
      //      model_jsjd.ZBBM = model_jsxx.ZBBM;
      //      model_jsjd.ZD = model_jsxx.ZD;
      //      model_jsjd.SJJD = int.Parse(txtComputePre.Text);
      //      bll_jsjd.Add(model_jsjd);
      //    }
      //    else
      //    {
      //      model_jsjd.SJJD = int.Parse(txtComputePre.Text);
      //      bll_jsjd.Update(model_jsjd);
      //    }
      //  }
      //  else
      //  {
      //    MessageBox.Show("计算精度必须为整数");
      //    return false;
      //  }
      //}
      bll_jsxxysj.Delete(model_jsxxysj.JSXXID, model_jsxxysj.ONAME);
      flag = bll_jsxxysj.Add(model_jsxxysj);
      //更新状态，为计算用
      BLL.JSXX_State bll = new BLL.JSXX_State();
      bll.Update();
      this.model_jsxxysj = model_jsxxysj;
      string cross = bll_jsxx.CrossQuote(model_jsxxysj);
      if (cross != "")
      {
        MessageBox.Show("存在交叉引用：" + cross);
        bll_jsxxysj.Delete(model_jsxxysj.JSXXID, model_jsxxysj.ONAME);
        return false;
      }
      return flag;
    }

    private bool IsInt(string s)
    {
      bool flag = true;
      int i = 0;
      try
      { i = int.Parse(s); }
      catch
      { flag = false; }
      return flag;
    }

    private void axCellQuoteTable_MenuStart(object sender, AxCELL50Lib._DCell2000Events_MenuStartEvent e)
    {
      if (e.section == 1)//表格范围内
      {
        axCellQuoteTable.AddPopMenu(1100, "加入", 0);
      }
    }

    private void axCellQuoteTable_MenuCommand(object sender, AxCELL50Lib._DCell2000Events_MenuCommandEvent e)
    {
      switch (e.itemid)
      {
        case 1100://加入
          if (listBoxNum.SelectedIndex < 0)
          {
            MessageBox.Show("请选择公式元素");
            return;
          }
          if (listViewQuoteTable.SelectedItems.Count == 0)
          {
            MessageBox.Show("请选择报表");
            return;
          }
          //dwbm为xb01时，odwbm为空时，所有单位数据变化都会影响xb01，不对
          if (!string.IsNullOrEmpty(model_jsxx.DWBM))
          {
            if (string.IsNullOrEmpty(cobDW.SelectedValue.ToString()))
            {
              MessageBox.Show("请选择单位");
              return;
            }
          }
          //dwbm为空，odwbm为xb01时，只能更新xb01的dwbm数据，不对
          if (!string.IsNullOrEmpty(cobDW.SelectedValue.ToString()))
          {
            if (string.IsNullOrEmpty(model_jsxx.DWBM))
            {
              MessageBox.Show("请在打开公式编辑前选择单位");
              return;
            }
          }
          if (!string.IsNullOrEmpty(model_jsxx.NF))
          {
            if (string.IsNullOrEmpty(txtYear.Text))
            {
              MessageBox.Show("请输入年份");
              return;
            }
          }
          if (!string.IsNullOrEmpty(model_jsxx.YF))
          {
            if (string.IsNullOrEmpty(txtMonth.Text))
            {
              MessageBox.Show("请输入年份");
              return;
            }
          }

          if (SaveJSXXYSJ())
          {
            int currentCol = axCellQuoteTable.GetCurrentCol();
            int currentRow = axCellQuoteTable.GetCurrentRow();
            ListViewItem item = listViewQuoteTable.SelectedItems[0];
            string currentTableName = item.SubItems[0].Text;
            if (oldCol != currentCol || oldRow != currentRow || oldTableName != currentTableName)
            {

            }
            axCellQuoteTable.SetCellTextColor(currentCol, currentRow, 0, axCellQuoteTable.FindColorIndex(255 * 65536, 1));
            axCellQuoteTable.ClearArea(oldCol, oldRow, oldCol, oldRow, 0, 1);
            axCellQuoteTable.SetCellString(currentCol, currentRow, 0, listBoxNum.SelectedItem.ToString());
            oldCol = currentCol;
            oldRow = currentRow;
            oldTableName = currentTableName;
            MessageBox.Show("保存成功");
          }
          break;
      }
    }
    #endregion
  }
}
