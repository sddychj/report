using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StatisticsSystem.TableConfig
{
  public partial class EditForm : Form
  {
    private int rowCount = 0;//cell表头行数
    private bool isEdit = false;//是否修改窗体还是新建窗体

    #region 窗体
    public EditForm()
    {
      InitializeComponent();
    }

    public EditForm(string caption)
    {
      InitializeComponent();
      this.Text = "打开报表" + caption;
      tableNumTxt.Text = caption;
      isEdit = true;

      initTableBasicConfg();
      initTableHeaderCell();
      initTableCoulumnCell();
      initTableIndexCell();
      initTableCellCell();
    }

    private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
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

    private void tableConfigTabList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void tableNumTxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void tableNumTxt_KeyPress(object sender, KeyPressEventArgs e)
    {

    }
    #endregion

    #region 下方四个按钮

    private void cancelBtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {

    }

    private void preBtn_Click(object sender, EventArgs e)
    {

    }

    private void finishBtn_Click(object sender, EventArgs e)
    {

    }

    private string CreateTable()
    {
      string returnStr = "";
      string tableName = tableNumTxt.Text;
      string[] columnList = new string[tableColumnCell.GetCols(0) - 1 + 4];
      string[] typeList = new string[tableColumnCell.GetCols(0) - 1 + 4];
      columnList[0] = "DWBM";
      columnList[1] = "ZBBM";
      columnList[2] = "NF";
      columnList[3] = "YF";
      typeList[0] = "varchar2(20)";
      typeList[1] = "varchar2(20)";
      typeList[2] = "number(4)";
      typeList[3] = "number(4)";

      for (int i = 1; i < tableColumnCell.GetCols(0); i++)
      {
        columnList[i - 1 + 4] = "col" + i.ToString();
        if (tableColumnCell.GetCellString(i, rowCount + 3, 0) == "字符型")
        {
          typeList[i - 1 + 4] = "varchar2(200)";
        }
        else
        {
          typeList[i - 1 + 4] = "number(18,4)";
        }
      }
      Common.DDL.DDLExecute.DropTable(tableName);
      returnStr = Common.DDL.DDLExecute.CreateTable(tableName, columnList, typeList);
      string[] pkNameList = new string[] { "DWBM", "ZBBM", "NF", "YF" };
      Common.DDL.DDLExecute.AddPK(tableName, pkNameList);
      return returnStr;
    }
    #endregion

    #region 报表基础配置
    private void initTableBasicConfg()
    {
      tableNumTxt.Enabled = false;
      BLL.CODE_BBBMB bll = new BLL.CODE_BBBMB();
      Model.CODE_BBBMB model = bll.GetModel(tableNumTxt.Text);
      if (model == null)
        return;
      tableNumTxt.Text = model.BBBM;
      tableHeaderTxt.Text = model.BBMC;
      tableNoTxt.Text = model.BBWH;
      tableCycleDrop.SelectedText = model.BBZQ;
      tableDateDrop.SelectedText = model.YQSBSJ;
      tableNoTxt.SelectedText = model.BBLX;
      tableStateDrop.SelectedText = model.DQZT;
      tableCycleDrop.SelectedText = model.BBZQ;

      tableArrangeDrop.SelectedText = model.PLFX;

    }

    private bool saveTableBasic()
    {
      bool flag = false;
      BLL.CODE_BBBMB bll = new BLL.CODE_BBBMB();
      bll.Delete(tableNumTxt.Text);
      Model.CODE_BBBMB model = new Model.CODE_BBBMB();
      model.BBBM = tableNumTxt.Text;
      model.BBMC = tableHeaderTxt.Text;
      model.BBWH = tableNoTxt.Text;
      model.BBZQ = tableCycleDrop.SelectedText;
      model.YQSBSJ = tableDateDrop.SelectedText;
      model.BBLX = tableNoTxt.SelectedText;
      model.DQZT = tableStateDrop.SelectedText;
      model.BBZQ = tableCycleDrop.SelectedText;

      model.PLFX = tableArrangeDrop.SelectedText;
      flag = bll.Add(model);
      return flag;
    }
    #endregion

    #region 报表表头配置
    private void choiceExcelBtn_Click(object sender, EventArgs e)
    {

    }

    private void initTableHeader(AxCELL50Lib.AxCell grid)
    {
      //Classes.InitCell.InitCellHeader(grid, "TG02", ref rowCount);
      grid.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
    }

    private void initTableHeaderCell()
    {
      initTableHeader(tableHeaderCell);

      tableHeaderCell.SetRows(rowCount + 1, 0);
    }
    #endregion

    #region 报表列配置
    private void initTableCoulumnCell()
    {
      initTableHeader(tableColumnCell);

      tableColumnCell.AllowPaste = false;
      tableColumnCell.SetRows(rowCount + 7, 0);
      tableColumnCell.SetColWidth(1, 100, 0, 0);
      tableColumnCell.SetCellString(0, rowCount + 1, 0, "是否只读");
      tableColumnCell.SetCellString(0, rowCount + 2, 0, "是否隐藏");
      tableColumnCell.SetCellString(0, rowCount + 3, 0, "字段类型");
      //tableColumnCell.SetCellString(0, rowCount + 4, 0, "字段长度");
      //tableColumnCell.SetCellString(0, rowCount + 5, 0, "字段精度");
      tableColumnCell.SetCellString(0, rowCount + 4, 0, "非零隐藏");

      BLL.ENCO_BBZD bll = new BLL.ENCO_BBZD();
      List<StatisticsSystem.Model.ENCO_BBZD> modelList = bll.GetModelList(" bbbm='" + tableNumTxt.Text + "'");
      for (int i = 1; i < tableColumnCell.GetCols(0); i++)
      {
        tableColumnCell.SetDroplistCell(i, rowCount + 1, 0, "是\t是\r\n否\t否", 4);
        tableColumnCell.SetDroplistCell(i, rowCount + 2, 0, "是\t是\r\n否\t否", 4);
        tableColumnCell.SetDroplistCell(i, rowCount + 3, 0, "字符型\t字符型\r\n数字型\t数字型", 4);
        tableColumnCell.SetDroplistCell(i, rowCount + 4, 0, "是\t是\r\n否\t否", 4);
        tableColumnCell.SetCellInput(i, rowCount + 4, 0, 3);
        tableColumnCell.SetCellInput(i, rowCount + 5, 0, 3);

        if (isEdit)
        {
          Model.ENCO_BBZD model = modelList[i - 1];
          if (model == null)
            return;
          //tableColumnCell.SetDroplistCellKey(i, rowCount + 1, 0, "是");
          //tableColumnCell.SetDroplistCellKey(i, rowCount + 2, 0, "否");
          tableColumnCell.SetDroplistCellKey(i, rowCount + 3, 0, model.SJLX);
          //tableColumnCell.SetCellString(i, rowCount + 4, 0, model.SJCD.ToString());
          //tableColumnCell.SetCellString(i, rowCount + 5, 0, model.SJJD.ToString());
          tableColumnCell.SetDroplistCellKey(i, rowCount + 4, 0, model.FLYC);
        }
        else
        {
          tableColumnCell.SetDroplistCellKey(i, rowCount + 1, 0, "否");
          tableColumnCell.SetDroplistCellKey(i, rowCount + 2, 0, "否");
          tableColumnCell.SetDroplistCellKey(i, rowCount + 3, 0, "字符型");
          tableColumnCell.SetDroplistCellKey(i, rowCount + 4, 0, "否");
        }
      }
    }

    private bool saveTableColumn()
    {
      bool flag = false;
      BLL.ENCO_BBZD_List bll = new BLL.ENCO_BBZD_List();
      bll.Delete(tableNumTxt.Text);
      Model.ENCO_BBZD_List model = new Model.ENCO_BBZD_List(tableColumnCell.GetCols(0) - 1);
      for (int i = 1; i < tableColumnCell.GetCols(0); i++)
      {
        model.BBBM[i - 1] = tableNumTxt.Text;
        model.ZD[i - 1] = "col" + i.ToString();
        model.SJLX[i - 1] = tableColumnCell.GetCellString(i, rowCount + 3, 0);
        //model.SJCD[i - 1] = (decimal)tableColumnCell.GetCellDouble(i, rowCount + 4, 0);
        model.FLYC[i - 1] = tableColumnCell.GetCellString(i, rowCount + 4, 0);
      }
      flag = bll.Add(model);
      return flag;
    }
    #endregion

    #region 报表指标配置
    private void initTableIndexCell()
    {
      //int rowCount = 0;
      //initTableHeader(tableIndexCell, ref rowCount);
      //tableIndexCell.SetRows(7, 0);
      tableIndexCell.SetCellString(1, 0, 0, "指标名称");
      tableIndexCell.SetCellString(2, 0, 0, "计量单位");
      tableIndexCell.SetCellString(3, 0, 0, "是否可编辑");
      tableIndexCell.SetCellString(4, 0, 0, "启用禁用");
      tableIndexCell.SetCellString(5, 0, 0, "层级");
      tableIndexCell.SetCellString(6, 0, 0, "显示隐藏");
      tableIndexCell.SetCellString(7, 0, 0, "备用1");
      tableIndexCell.SetCols(8, 0);
      tableIndexCell.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
      if (isEdit)
      {
        BLL.ENCO_ZBBMB bll = new BLL.ENCO_ZBBMB();
        List<Model.ENCO_ZBBMB> modelList = bll.GetModelList(" bbbm='" + tableNumTxt.Text + "'");
        for (int i = 0; i < modelList.Count; i++)
        {
          tableIndexCell.SetRows(modelList.Count + 1, 0);
          Model.ENCO_ZBBMB model = modelList[i];
          if (model == null)
            return;
          tableIndexCell.SetCellString(1, i + 1, 0, model.ZBMC);
          //tableIndexCell.SetDroplistCell(3, i + 1, 0, "是\t是\r\n否\t否", 4);
          //tableIndexCell.SetDroplistCellKey(3, i + 1, 0, );
          tableIndexCell.SetDroplistCell(4, i + 1, 0, "启用\t启用\r\n禁用\t禁用", 4);
          tableIndexCell.SetDroplistCellKey(4, i + 1, 0, model.QYJY);
          tableIndexCell.SetDroplistCell(6, i + 1, 0, "显示\t显示\r\n隐藏\t隐藏", 4);
          tableIndexCell.SetDroplistCellKey(6, i + 1, 0, model.XSYC);
        }
      }
      else
      {
        tableIndexCell.SetRows(2, 0);
      }
    }

    private void tableIndexCell_MenuStart(object sender, AxCELL50Lib._DCell2000Events_MenuStartEvent e)
    {

    }

    private void tableIndexCell_MenuCommand(object sender, AxCELL50Lib._DCell2000Events_MenuCommandEvent e)
    {

    }

    private bool saveTableIndex()
    {
      bool flag = false;
      BLL.ENCO_ZBBMB_List bll = new BLL.ENCO_ZBBMB_List();
      bll.Delete(tableNumTxt.Text);
      Model.ENCO_ZBBMB_List model = new Model.ENCO_ZBBMB_List(tableIndexCell.GetRows(0) - 1);
      for (int i = 1; i < tableIndexCell.GetRows(0); i++)
      {
        model.BBBM[i - 1] = tableNumTxt.Text;
        model.ZBBM[i - 1] = tableNumTxt.Text + string.Format("{0:D4}", i);
        model.ZBMC[i - 1] = tableIndexCell.GetCellString(1, i, 0);
        model.QYJY[i - 1] = tableIndexCell.GetCellString(4, i, 0);
        model.XSYC[i - 1] = tableIndexCell.GetCellString(6, i, 0);
      }
      flag = bll.Add(model);
      return flag;
    }
    #endregion

    #region 报表单元格配置
    private void initTableCellCell()
    {
      initTableHeader(tableCellCell);
      //int v = tableIndexCell.GetRows(0);
      tableCellCell.SetRows(rowCount + tableIndexCell.GetRows(0), 0);
      //初始化，使本表指标名称等于指标配置tab 
      for (int i = 1; i < tableIndexCell.GetRows(0); i++)
      {
        tableCellCell.SetCellString(1, rowCount + i, 0, tableIndexCell.GetCellString(1, i, 0));
        int width = tableCellCell.GetColBestWidth(1);
        tableCellCell.SetColWidth(1, width, 1, 0);
      }
      //只能输入数字
      BLL.ENCO_SJJDJJBL bll = new BLL.ENCO_SJJDJJBL();
      List<Model.ENCO_SJJDJJBL> modelList = bll.GetModelList(" bbbm='" + tableNumTxt.Text + "'");
      for (int j = 1; j < tableCellCell.GetCols(0); j++)
      {
        string type = tableColumnCell.GetCellString(j, rowCount + 3, 0);
        if (type == "数字型")
        {
          for (int i = rowCount + 1; i < tableCellCell.GetRows(0); i++)
          {
            tableCellCell.SetCellInput(j, i, 0, 3);
            if (isEdit)
            {
              int index = (i - rowCount - 1) * (tableCellCell.GetCols(0) - 1) + (j - 1);
              Model.ENCO_SJJDJJBL model = modelList[index];
              if (model == null)
                return;
              tableCellCell.SetCellDouble(j, i, 0, (double)model.SJJD);
            }
            else
            {
              tableCellCell.SetCellDouble(j, i, 0, 4);
            }
          }
        }
      }
    }

    private bool saveTableCell()
    {
      bool flag = false;
      BLL.ENCO_SJJDJJBL_List bll = new BLL.ENCO_SJJDJJBL_List();
      bll.Delete(tableNumTxt.Text);
      int length = (tableCellCell.GetRows(0) - rowCount - 1) * (tableCellCell.GetCols(0) - 1);
      Model.ENCO_SJJDJJBL_List model = new Model.ENCO_SJJDJJBL_List(length);
      for (int i = 1; i < tableCellCell.GetRows(0) - rowCount; i++)
      {
        for (int j = 1; j < tableCellCell.GetCols(0); j++)
        {
          int index = (i - 1) * (tableCellCell.GetCols(0) - 1) + j - 1;
          model.BBBM[index] = tableNumTxt.Text;
          model.ZBBM[index] = tableNumTxt.Text + string.Format("{0:D4}", i);
          model.ZD[index] = "col" + j.ToString();
          model.SJJD[index] = (decimal)tableCellCell.GetCellDouble(j, i + rowCount, 0);
        }
      }
      flag = bll.Add(model);
      return flag;
    }
    #endregion
  }
}
