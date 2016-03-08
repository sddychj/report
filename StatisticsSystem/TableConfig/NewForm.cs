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
  public partial class NewForm : Form, MainForm.ICipherInputForm
  {
    private bool isEdit = false;//是否修改窗体还是新建窗体
    private string _mode = "";//是否继承已有
    Model.XMLVERSION model_xml = new Model.XMLVERSION();
    public ToolStrip CipherToolStrip
    {
      get
      {
        return Tools;
      }
    }
    #region 窗体
    public NewForm()
    {
      InitializeComponent();

      BLL.CODE_BBBMB bll_bbbmb = new BLL.CODE_BBBMB();
      int count = bll_bbbmb.GetMaxXH();
      tableIndexUpDown.Value = count;
      BindBBLX();

      InitTableHeaderCell();
      InitTableHeaderColor(axcellTableHeader);
      InitTableColumnCell();
      //InitTableHeaderColor(axCellTableColumn);
      InitTableIndexCell();
      //InitTableCellPreCell();
      //this.Text = "新建报表";
    }

    public NewForm(string _tableNum)
    {
      InitializeComponent();
      txtTableNum.Text = _tableNum;
      isEdit = true;
      this.Text = "报表设置向导" + _tableNum;
      BindBBLX();
      InitTableBasicConfg();
      InitXml();
      InitTableHeaderCell();
      InitTableHeaderColor(axcellTableHeader);
      InitTableColumnCell();
      InitTableHeaderColor(axCellTableColumn);
      InitTableIndexCell();
      InitTableCellPreCell();
      InitTableCellPreNum();
    }

    public NewForm(string _tableNum, string mode)
    {
      InitializeComponent();
      txtTableNum.Text = _tableNum;
      isEdit = true;
      _mode = mode;
      this.Text = "报表设置向导" + _tableNum;
      BindBBLX();
      InitTableBasicConfg();
      InitXml();
      InitTableHeaderCell();
      InitTableHeaderColor(axcellTableHeader);
      InitTableColumnCell();
      InitTableHeaderColor(axCellTableColumn);
      InitTableIndexCell();
      InitTableCellPreCell();
      InitTableCellPreNum();
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

    private void tabListTableConfig_SelectedIndexChanged(object sender, EventArgs e)
    {
      //if (txtTableNum.Text == "")
      //{
      //  MessageBox.Show("报表编码不能为空");
      //}
      #region 下放四个按钮显示隐藏
      if (tabListTableConfig.SelectedIndex == tabListTableConfig.TabCount - 1)
      {
        btnFinish.Enabled = true;
        btnNext.Enabled = false;
        btnPre.Enabled = true;
      }
      else if (tabListTableConfig.SelectedIndex == 0)
      {
        btnFinish.Enabled = false;
        btnNext.Enabled = true;
        btnPre.Enabled = false;
      }
      else
      {
        btnFinish.Enabled = false;
        btnNext.Enabled = true;
        btnPre.Enabled = true;
      }
      #endregion
      //int isUpdate = axcellTableHeader.IsModified();
      #region 初始化报表列配置表头
      if (tabListTableConfig.SelectedTab == tabTableColumnConfig)
      {
        axcellTableHeader.CopyRange(1, 1, axcellTableHeader.GetCols(0) - 1, axcellTableHeader.GetRows(0) - 1);
        axCellTableColumn.Paste(1, 1, 0, 0, 0);
        InitTableHeaderColor(axCellTableColumn);
        for (int i = 0; i < axCellTableColumn.GetCols(0); i++)
        {
          int width = axCellTableColumn.GetColBestWidth(i);
          axCellTableColumn.SetColWidth(1, width, i, 0);
        }

        axCellTableColumn.SetColHidden(1, 1);
        axCellTableColumn.SetColHidden(2, 2);
        axCellTableColumn.SetColHidden(3, 3);
        axCellTableColumn.SetColHidden(4, 4);
        axCellTableColumn.SetColHidden(6, 6);
        axCellTableColumn.SetColHidden(7, 7);
        axCellTableColumn.SetColHidden(10, 10);
        axCellTableColumn.SetColHidden(11, 11);
        axCellTableColumn.SetColHidden(12, 12);
        axCellTableColumn.SetColHidden(13, 13);
        //axCellTableColumn.SetColHidden(axCellTableColumn.GetCols(0) - 1, axCellTableColumn.GetCols(0) - 1);
      }
      #endregion
      #region 指标配置
      if (tabListTableConfig.SelectedTab == tabTableIndexConfig)
      {
        //axCellTableIndex.SetColHidden(10, 10);
        //axCellTableIndex.SetColHidden(11, 11);
        //axCellTableIndex.SetColHidden(12, 12);
      }
      #endregion
      #region   初始化报表单元格设置表格
      if (tabListTableConfig.SelectedTab == tabTableCellPreConfig)
      {
        axcellTableHeader.CopyRange(1, 1, axcellTableHeader.GetCols(0) - 1, axcellTableHeader.GetRows(0) - 1);
        axCellTableCellPre.Paste(1, 1, 0, 0, 0);
        InitTableCellPreCell();
        InitTableHeaderColor(axCellTableCellPre);
      }
      #endregion
    }

    private void txtTableNum_TextChanged(object sender, EventArgs e)
    {
      string pattern = @"^[0-9a-zA-Z_]*$";
      string param1 = null;
      Match m = Regex.Match(txtTableNum.Text, pattern);   // 匹配正则表达式
      if (!m.Success)   // 输入的不是数字     
      {
        this.txtTableNum.Text = param1;   // textBox内容不变
        // 将光标定位到文本框的最后
        this.txtTableNum.SelectionStart = txtTableNum.Text.Length;
      }
      else   // 输入的是数字
      {
        param1 = this.txtTableNum.Text;   // 将现在textBox的值保存下来
      }
    }

    private void txtTableNum_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
        || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == (char)Keys.Back)
        e.Handled = false;
      else
        e.Handled = true;
    }
    #endregion

    #region 下方四个按钮
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      if (tabListTableConfig.SelectedIndex == tabListTableConfig.TabCount - 2)
      {
        btnFinish.Enabled = true;
        btnNext.Enabled = false;
      }
      tabListTableConfig.SelectedIndex++;
      btnPre.Enabled = true;
    }

    private void btnPre_Click(object sender, EventArgs e)
    {
      if (tabListTableConfig.SelectedIndex == 1)
      {
        btnPre.Enabled = false;
      }
      btnFinish.Enabled = false;
      btnNext.Enabled = true;
      tabListTableConfig.SelectedIndex--;
    }

    private void btnFinish_Click(object sender, EventArgs e)
    {
      //MessageBox.Show(axcellTableHeader.GetCellDouble(1, 1, 0).ToString());
      //if (txtTableNum.Text == "")
      //{
      //  MessageBox.Show("报表编号不能为空");
      //  return;
      //}
      if (axcellTableHeader.GetRows(0) == 1)
      {
        MessageBox.Show("表头未配置");
        return;
      }
      if (!Classes.SaveCell.IsCellLastRow(axcellTableHeader))
      {
        MessageBox.Show("最后一行不能有合并行");
        return;
      }
      txtTableNum.Text = txtTableNum.Text.ToUpper();
      BLL.CODE_BBBMB bll_bbbmb = new BLL.CODE_BBBMB();
      if (!isEdit)
      {
        if (bll_bbbmb.Exists(txtTableNum.Text))
        {
          MessageBox.Show("表名已存在");
          return;
        }
      }
      //InitTableCellPreCell();//防止没有点击单元格配置时没有同步初始化
      try
      {
        if (isEdit)
        {
          //DeleteTableBasic();
          //DeleteTableColumn();
          //DeleteTableIndex();
          //DeleteTableCell();
          //DeleteXml();
        }
        else
        {
          int count = bll_bbbmb.GetMaxBBBM();
          txtTableNum.Text = "CL" + string.Format("{0:D4}", count + 1);
        }

        if (SaveTableCell())
        {
          if (SaveTableIndex())
          {
            SaveZBDW();
            if (SaveTableColumn())
            {
              if (SaveTableBasic())
              {
                if (SaveXml())
                {
                  if (!isEdit || _mode == "3")//当继承已有或新建时，建立实际表
                  {
                    SaveBBDW();
                    //SaveCol();
                    string message = CreateTable();
                    if (message == "")
                    {
                      MessageBox.Show("保存失败");
                    }
                    else
                    {
                      AddComment();
                      MessageBox.Show(message);
                    }
                  }
                  else
                  {
                    AddComment();
                    MessageBox.Show("保存成功");
                  }
                }
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        if (!isEdit)
        {
          DeleteTableBasic();
          DeleteTableColumn();
          DeleteTableIndex();
          DeleteTableCell();
          DeleteXml();
        }
        throw ex;
      }
    }

    private string CreateTable()
    {
      string returnStr = "";
      string tableName = txtTableNum.Text;
      string[] columnList = new string[axCellTableColumn.GetCols(0) - 2];
      string[] typeList = new string[axCellTableColumn.GetCols(0) - 2];

      //columnList[0] = "DWBM";
      //columnList[1] = "ZBBM";
      //columnList[2] = "NF";
      //columnList[3] = "YF";
      //columnList[4] = "HC";
      //typeList[0] = "varchar2(20)";
      //typeList[1] = "varchar2(20)";
      //typeList[2] = "number(4)";
      //typeList[3] = "number(4)";
      //typeList[4] = "number(4)";

      for (int i = 1; i < axCellTableColumn.GetCols(0) - 1; i++)
      {
        columnList[i - 1] = axCellTableColumn.GetCellString(i, axcellTableHeader.GetRows(0) + 7, 0);
        if (axCellTableColumn.GetCellString(i, axcellTableHeader.GetRows(0) + 2, 0) == "字符型")
        {
          typeList[i - 1] = "varchar2(200)";
        }
        else
        {
          string pre = axCellTableColumn.GetCellString(i, axcellTableHeader.GetRows(0) + 3, 0);
          if (pre == "")
          {
            typeList[i - 1] = "number";
          }
          else
          {
            typeList[i - 1] = "number(18," + pre + ")";
          }
        }
      }
      //Common.DDL.DDLExecute.DropTable(tableName);
      returnStr = Common.DDL.DDLExecute.CreateTable(tableName, columnList, typeList);
      string[] pkNameList = new string[] { "DWBM", "ZBBM", "NF", "YF" };
      Common.DDL.DDLExecute.AddPK(tableName, pkNameList);
      return returnStr;
    }

    private void AddComment()
    {
      //表注释
      if (txtTableHeader.Text != "")
        Common.DDL.DDLExecute.AddTableComment(txtTableNum.Text, txtTableHeader.Text);
      //列注释
      for (int i = 1; i < axCellTableColumn.GetCols(0) - 1; i++)
      {
        string comment = axCellTableColumn.GetCellString(i, axcellTableHeader.GetRows(0) + 5, 0);
        if (comment != "")
        {
          Common.DDL.DDLExecute.AddColumnComment(txtTableNum.Text, axCellTableColumn.GetCellString(i, axcellTableHeader.GetRows(0) + 7, 0),
            comment);
        }
      }
    }
    #endregion

    #region 保存报表与指标对应单位信息
    private bool SaveBBDW()
    {
      BLL.BBDYTBDW blldw = new BLL.BBDYTBDW();
      Model.BBDYTBDW modeldw = new Model.BBDYTBDW();
      string dw = GetDW();
      modeldw.BBBM = txtTableNum.Text;
      modeldw.DWBM = dw;
      modeldw.SUMDW = "-1";
      modeldw.Isglzb = "1";
      bool flag = blldw.Add(modeldw);
      return flag;
    }
    private bool SaveZBDW()
    {
      BLL.BBDYTBDW blldw = new BLL.BBDYTBDW();
      Model.BBDYTBDW modeldw = new Model.BBDYTBDW();
      string dw = GetDW();
      BLL.login login = new BLL.login();
      //string userid = login.GetUserid(MainForm.Current.Loginname);
      bool flag = blldw.InsertZB(txtTableNum.Text, dw, "");
      return flag;
    }
    private bool SaveCol()
    {
      BLL.BBDYTBDW blldw = new BLL.BBDYTBDW();
      Model.BBDYTBDW modeldw = new Model.BBDYTBDW();
      string dw = GetDW();
      BLL.login login = new BLL.login();
      //string userid = login.GetUserid(MainForm.Current.Loginname);
      bool flag = blldw.InsertCol(txtTableNum.Text, dw, "");
      return flag;

    }
    private string GetDW()
    {
      BLL.DWBMB blldw = new BLL.DWBMB();
      string dw = blldw.GetDW(MainForm.Current.Loginname);
      return dw;
    }
    #endregion

    #region 报表基础配置
    private void InitTableBasicConfg()
    {
      txtTableNum.Enabled = false;
      BLL.CODE_BBBMB bll_bbbmb = new BLL.CODE_BBBMB();
      Model.CODE_BBBMB model_bbbmb = new Model.CODE_BBBMB();
      model_bbbmb = bll_bbbmb.GetModel(txtTableNum.Text);
      if (model_bbbmb == null)
        return;
      txtTableNum.Text = model_bbbmb.BBBM;
      txtTableHeader.Text = model_bbbmb.BBMC;
      txtTableNo.Text = model_bbbmb.BBWH;
      this.Text = "报表设置向导_" + model_bbbmb.BBWH;
      dropTableCycle.SelectedItem = model_bbbmb.BBZQ;
      //dropTableDate.SelectedItem = model_bbbmb.YQSBSJ;
      dropTableType.SelectedValue = model_bbbmb.BBLX;

      dropTableState.SelectedItem = model_bbbmb.DQZT;
      dropTableCycle.SelectedItem = model_bbbmb.BBZQ;
      //dropTableArrange.SelectedItem = model_bbbmb.PLFX;
      tableIndexUpDown.Value = model_bbbmb.PXXH;
      exportPre.Value = model_bbbmb.LS;
      isAddRow.Checked = model_bbbmb.CGZZSX == "1" ? true : false;
      isPreCompute.Checked = model_bbbmb.CAPTION == "1" ? true : false;
      cobIsMerge.Checked = model_bbbmb.COORDINATES == "1" ? true : false;
      cbISSpecia.Checked = model_bbbmb.PLFX == "1" ? true : false;
    }

    private void BindBBLX()
    {
      BLL.ENCO_BBLX bll = new BLL.ENCO_BBLX();
      DataSet ds = bll.GetList("");
      dropTableType.DataSource = ds;
      dropTableType.DisplayMember = "DS.LBMC";
      dropTableType.ValueMember = "DS.ID";
    }

    private bool SaveTableBasic()
    {
      if (isEdit)
      {
        DeleteTableBasic();
      }
      bool flag = false;
      BLL.CODE_BBBMB bll_bbbmb = new BLL.CODE_BBBMB();
      Model.CODE_BBBMB model = new Model.CODE_BBBMB();
      model.BBBM = txtTableNum.Text;
      model.BBMC = txtTableHeader.Text;
      model.BBWH = txtTableNo.Text;
      model.BBZQ = dropTableCycle.SelectedIndex >= 0 ? dropTableCycle.SelectedItem.ToString() : "";
      //model.YQSBSJ = dropTableDate.SelectedIndex >= 0 ? dropTableDate.SelectedItem.ToString() : "";
      model.BBLX = dropTableType.SelectedIndex >= 0 ? dropTableType.SelectedValue.ToString() : "";
      model.DQZT = dropTableState.SelectedIndex >= 0 ? dropTableState.SelectedItem.ToString() : "";
      //model.PLFX = dropTableArrange.SelectedIndex >= 0 ? dropTableArrange.SelectedItem.ToString() : "";
      model.PXXH = tableIndexUpDown.Value;
      model.LS = exportPre.Value;
      model.CGZZSX = isAddRow.Checked ? "1" : "0";
      model.CAPTION = isPreCompute.Checked ? "1" : "0";
      model.COORDINATES = cobIsMerge.Checked ? "1" : "0";
      model.PLFX = cbISSpecia.Checked ? "1" : "0";
      flag = bll_bbbmb.Add(model);
      return flag;
    }

    private bool DeleteTableBasic()
    {
      bool flag = false;
      BLL.CODE_BBBMB bll_bbbmb = new BLL.CODE_BBBMB();
      flag = bll_bbbmb.Delete(txtTableNum.Text);
      return flag;
    }
    #endregion

    #region 报表表头配置
    private void choiceExcelBtn_Click(object sender, EventArgs e)
    {
      //if (txtSheetName.Text == "")
      //{
      //  MessageBox.Show("文本框不能为空");
      //  return;
      //}
      //string s_soursepath = "d:\\华北工程公司统计\\a.xml";
      //if (dialogChoiceExcel.ShowDialog() == DialogResult.OK)
      //{
      //  s_soursepath = dialogChoiceExcel.FileName;
      //}
      //string s_savepath = Application.StartupPath;
      //string s = Classes.InitCell.ExcelToXml(txtSheetName.Text, "TG02", s_savepath);

      //InitTableHeaderCell();
      //InitTableCoulumnCell();
      //InitTableIndexCell();
      //InitTableCellCell();
    }

    private void InitTableHeader(AxCELL50Lib.AxCell grid)
    {
      Classes.InitCell.InitCellHeader(grid, model_xml);
      grid.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
      //grid.ShowHScroll(1, 0);
    }

    private void InitTableHeaderColor(AxCELL50Lib.AxCell grid)
    {
      int color = 0 + 255 * 256 + 255 * 65536;
      for (int i = 1; i < axcellTableHeader.GetRows(0); i++)
      {
        grid.SetCellBackColor(-1, i, 0, axcellTableHeader.FindColorIndex(color, 1));
      }

      //grid.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
    }

    private void InitTableHeaderCell()
    {
      if (isEdit)
      {
        axcellTableHeader.SetRows((int)model_xml.ROWCOUNT + 1, 0);
        axcellTableHeader.SetCols((int)model_xml.COLUMNCOUNT + 1, 0);
        InitTableHeader(axcellTableHeader);
      }
      else
      {
        axcellTableHeader.SetRows(4, 0);
        axcellTableHeader.SetCols(20, 0);

        axcellTableHeader.SetCellString(1, 1, 0, "单位编码");
        axcellTableHeader.SetCellString(2, 1, 0, "指标编码");
        axcellTableHeader.SetCellString(3, 1, 0, "年份");
        axcellTableHeader.SetCellString(4, 1, 0, "月份");
        axcellTableHeader.SetCellString(5, 1, 0, "指标名称");
        axcellTableHeader.SetCellString(6, 1, 0, "层级");
        axcellTableHeader.SetCellString(7, 1, 0, "行次");
        axcellTableHeader.SetCellString(8, 1, 0, "指标代码");
        axcellTableHeader.SetCellString(9, 1, 0, "计量单位");
        axcellTableHeader.SetCellString(10, 1, 0, "启用禁用");
        axcellTableHeader.SetCellString(11, 1, 0, "显示隐藏");
        axcellTableHeader.SetCellString(12, 1, 0, "是否可编辑");
        axcellTableHeader.SetCellString(13, 1, 0, "是否末级");
        axcellTableHeader.SetCellString(19, 1, 0, "Rowid");

        axcellTableHeader.MergeCells(1, 1, 1, 3);
        axcellTableHeader.MergeCells(2, 1, 2, 3);
        axcellTableHeader.MergeCells(3, 1, 3, 3);
        axcellTableHeader.MergeCells(4, 1, 4, 3);
        axcellTableHeader.MergeCells(5, 1, 5, 3);
        axcellTableHeader.MergeCells(6, 1, 6, 3);
        axcellTableHeader.MergeCells(7, 1, 7, 3);
        axcellTableHeader.MergeCells(8, 1, 8, 3);
        axcellTableHeader.MergeCells(9, 1, 9, 3);
        axcellTableHeader.MergeCells(10, 1, 10, 3);
        axcellTableHeader.MergeCells(11, 1, 11, 3);
        axcellTableHeader.MergeCells(12, 1, 12, 3);
        axcellTableHeader.MergeCells(13, 1, 13, 3);
        axcellTableHeader.MergeCells(19, 1, 19, 3);

        axcellTableHeader.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
      }

      axcellTableHeader.SetCellInput(1, 1, 0, 5);
      axcellTableHeader.SetCellInput(2, 1, 0, 5);
      axcellTableHeader.SetCellInput(3, 1, 0, 5);
      //axcellTableHeader.SetCellInput(5, 1, 0, 5);
      axcellTableHeader.SetCellInput(6, 1, 0, 5);
      axcellTableHeader.SetCellInput(7, 1, 0, 5);
      axcellTableHeader.SetCellInput(8, 1, 0, 5);
      axcellTableHeader.SetCellInput(9, 1, 0, 5);
      axcellTableHeader.SetCellInput(10, 1, 0, 5);
      axcellTableHeader.SetCellInput(11, 1, 0, 5);
      axcellTableHeader.SetCellInput(12, 1, 0, 5);
      axcellTableHeader.SetCellInput(13, 1, 0, 5);
      axcellTableHeader.SetColHidden(1, 1);
      axcellTableHeader.SetColHidden(2, 2);
      axcellTableHeader.SetColHidden(3, 3);
      axcellTableHeader.SetColHidden(4, 4);
      axcellTableHeader.SetColHidden(6, 6);
      axcellTableHeader.SetColHidden(7, 7);
      axcellTableHeader.SetColHidden(10, 10);
      axcellTableHeader.SetColHidden(11, 11);
      axcellTableHeader.SetColHidden(12, 12);
      axcellTableHeader.SetColHidden(13, 13);
      //axcellTableHeader.SetColHidden(axcellTableHeader.GetCols(0) - 1, axcellTableHeader.GetCols(0) - 1);
    }

    private void axcellTableHeader_MenuStart(object sender, AxCELL50Lib._DCell2000Events_MenuStartEvent e)
    {
      if (e.section == 1)//表格范围内
      {
        axcellTableHeader.AddPopMenu(1100, "组合单元格", 0);
        axcellTableHeader.AddPopMenu(1101, "取消组合", 0);
      }
      if (e.section == 2) //行标上
      {
        axcellTableHeader.AddPopMenu(1200, "添加行", 0);
        axcellTableHeader.AddPopMenu(1201, "删除行", 0);
      }
      if (e.section == 3)//列标上
      {
        axcellTableHeader.AddPopMenu(1300, "添加列", 0);
        if (!isEdit)
        {
          axcellTableHeader.AddPopMenu(1301, "删除列", 0);
        }
      }
    }

    private void axcellTableHeader_MenuCommand(object sender, AxCELL50Lib._DCell2000Events_MenuCommandEvent e)
    {
      int startRow = 0, startCol = 0, endRow = 0, endCol = 0;
      axcellTableHeader.GetSelectRange(ref startCol, ref startRow, ref endCol, ref endRow);
      int currentRow = 0, currentCol = 0;
      currentRow = axcellTableHeader.GetCurrentRow();
      currentCol = axcellTableHeader.GetCurrentCol();
      int cellHeaderRowCount = axcellTableHeader.GetRows(0);
      switch (e.itemid)
      {
        case 1100://组合单元格
          axcellTableHeader.MergeCells(startCol, startRow, endCol, endRow);
          break;
        case 1101://取消组合
          axcellTableHeader.UnmergeCells(startCol, startRow, endCol, endRow);
          break;
        case 1200://添加行          
          axcellTableHeader.InsertRow(currentRow + 1, 1, 0);
          InitTableHeaderColor(axcellTableHeader);
          axCellTableColumn.InsertRow(currentRow + 1, 1, 0);
          axCellTableCellPre.InsertRow(currentRow + 1, 1, 0);
          break;
        case 1201://删除行
          if (currentRow < 2)
            return;
          axcellTableHeader.DeleteRow(currentRow, 1, 0);
          axCellTableColumn.DeleteRow(currentRow, 1, 0);
          axCellTableCellPre.DeleteRow(currentRow, 1, 0);
          break;
        case 1300://添加列
          if (currentCol < 13)
          { return; }
          axcellTableHeader.InsertCol(currentCol, 1, 0);
          axcellTableHeader.SetCellInput(currentCol, 1, 0, 0);
          axCellTableColumn.InsertCol(currentCol, 1, 0);
          axCellTableColumn.SetDroplistCellKey(currentCol, cellHeaderRowCount + 0, 0, "否");
          axCellTableColumn.SetDroplistCellKey(currentCol, cellHeaderRowCount + 1, 0, "否");
          axCellTableColumn.SetCellInput(currentCol, cellHeaderRowCount + 2, 0, 0);
          axCellTableColumn.SetDroplistCellKey(currentCol, cellHeaderRowCount + 2, 0, "数字型");
          axCellTableColumn.SetCellInput(currentCol, cellHeaderRowCount + 3, 0, 3);
          axCellTableColumn.SetCellString(currentCol, cellHeaderRowCount + 3, 0, "4");
          axCellTableColumn.SetDroplistCellKey(currentCol, cellHeaderRowCount + 4, 0, "否");
          axCellTableColumn.SetDroplistCellKey(currentCol, cellHeaderRowCount + 8, 0, "是");
          axCellTableColumn.SetDroplistCellKey(currentCol, cellHeaderRowCount + 9, 0, "是");
          axCellTableCellPre.InsertCol(currentCol, 1, 0);
          //序号加1
          if (isEdit)
          {
            int startXH = int.Parse(axCellTableColumn.GetCellString(currentCol - 1, cellHeaderRowCount + 6, 0));
            //string endXH = axCellTableColumn.GetCellString(axcellTableHeader.GetCols(0) - 2, cellHeaderRowCount + 6, 0);
            for (int i = currentCol; i < axcellTableHeader.GetCols(0) - 1; i++)
            {
              axCellTableColumn.SetCellString(i, cellHeaderRowCount + 6, 0, (++startXH).ToString());
            }
          }
          break;
        case 1301://删除列
          //MessageBox.Show(currentCol.ToString());
          //MessageBox.Show(axcellTableHeader.GetCols(0).ToString());
          if (currentCol == axcellTableHeader.GetCols(0) - 1)
            return;
          axcellTableHeader.DeleteCol(currentCol, 1, 0);
          axCellTableColumn.DeleteCol(currentCol, 1, 0);
          axCellTableCellPre.DeleteCol(currentCol, 1, 0);
          break;
      }
    }
    #endregion

    #region 报表列配置
    private void InitTableColumnCell()
    {
      if (isEdit)
      {
        axCellTableColumn.SetCols((int)model_xml.COLUMNCOUNT + 1, 0);
        InitTableHeader(axCellTableColumn);
        //axCellTableColumn.SetRows((int)model_bbbmb.ROWCOUNT + 1, 0);
        //axCelltableColumn.AllowPaste = false;
      }
      else
      {
        axCellTableColumn.SetRows(4, 0);
        axCellTableColumn.SetCols(20, 0);
      }

      int cellHeaderRowCount = axcellTableHeader.GetRows(0);
      axCellTableColumn.SetRows(cellHeaderRowCount + 11, 0);
      //axCellTableColumn.SetColWidth(1, 100, 0, 0);
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 0, 0, "是否只读");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 1, 0, "是否隐藏");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 2, 0, "字段类型");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 3, 0, "字段精度");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 4, 0, "非零隐藏");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 5, 0, "字段注释");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 6, 0, "字段排序");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 7, 0, "字段名");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 8, 0, "子级是否汇总");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 9, 0, "本级是否合计");
      axCellTableColumn.SetCellString(0, cellHeaderRowCount + 10, 0, "宽度");

      BLL.ENCO_BBZD bll = new BLL.ENCO_BBZD();
      List<StatisticsSystem.Model.ENCO_BBZD> modelList = bll.GetModelList_BBBM(txtTableNum.Text);
      for (int i = 1; i < axCellTableColumn.GetCols(0) - 1; i++)
      {
        axCellTableColumn.SetDroplistCell(i, cellHeaderRowCount + 0, 0, "是\t是\r\n否\t否", 4);
        axCellTableColumn.SetDroplistCell(i, cellHeaderRowCount + 1, 0, "是\t是\r\n否\t否", 4);
        axCellTableColumn.SetDroplistCell(i, cellHeaderRowCount + 2, 0, "字符型\t字符型\r\n数字型\t数字型", 4);
        axCellTableColumn.SetCellInput(i, cellHeaderRowCount + 3, 0, 3);
        axCellTableColumn.SetDroplistCell(i, cellHeaderRowCount + 4, 0, "是\t是\r\n否\t否", 4);
        axCellTableColumn.SetCellInput(i, cellHeaderRowCount + 7, 0, 5);
        axCellTableColumn.SetCellInput(i, cellHeaderRowCount + 6, 0, 3);
        axCellTableColumn.SetDroplistCell(i, cellHeaderRowCount + 8, 0, "是\t是\r\n否\t否", 4);
        axCellTableColumn.SetDroplistCell(i, cellHeaderRowCount + 9, 0, "是\t是\r\n否\t否", 4);
        axCellTableColumn.SetCellInput(i, cellHeaderRowCount + 10, 0, 3);

        if (isEdit)
        {
          Model.ENCO_BBZD model = modelList[i - 1];
          if (model == null)
            return;
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 0, 0, model.Sfzd);
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 1, 0, model.Sfyc);
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 2, 0, model.SJLX);
          axCellTableColumn.SetCellInput(i, cellHeaderRowCount + 2, 0, 5);
          axCellTableColumn.SetCellString(i, cellHeaderRowCount + 3, 0, model.SJJD.ToString());
          axCellTableColumn.SetCellInput(i, cellHeaderRowCount + 3, 0, 5);
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 4, 0, model.FLYC);
          axCellTableColumn.SetCellString(i, cellHeaderRowCount + 5, 0, model.ZDZS.ToString());
          axCellTableColumn.SetCellString(i, cellHeaderRowCount + 6, 0, model.ZDSX.ToString());
          axCellTableColumn.SetCellString(i, cellHeaderRowCount + 7, 0, model.ZD.ToString());
          axCellTableColumn.SetCellString(i, cellHeaderRowCount + 8, 0, model.SJCD.ToString());
          axCellTableColumn.SetCellString(i, cellHeaderRowCount + 9, 0, model.Sfhz.ToString());
          axCellTableColumn.SetCellString(i, cellHeaderRowCount + 10, 0, model.Width1.ToString());
        }
        else
        {
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 0, 0, "否");
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 1, 0, "否");
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 2, 0, "数字型");
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 4, 0, "否");
          if (i > 12)
          { axCellTableColumn.SetCellString(i, cellHeaderRowCount + 3, 0, "4"); }
          axCellTableColumn.SetCellInput(i, cellHeaderRowCount + 6, 0, 5);
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 8, 0, "是");
          axCellTableColumn.SetDroplistCellKey(i, cellHeaderRowCount + 9, 0, "是");
        }
      }
      for (int i = 0; i < axCellTableColumn.GetCols(0); i++)
      {
        int width = axCellTableColumn.GetColBestWidth(i);
        axCellTableColumn.SetColWidth(1, width, i, 0);
      }
      axCellTableColumn.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
      #region
      axCellTableColumn.SetCellString(1, cellHeaderRowCount + 7, 0, "DWBM");
      axCellTableColumn.SetCellString(2, cellHeaderRowCount + 7, 0, "ZBBM");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 7, 0, "NF");
      axCellTableColumn.SetCellString(4, cellHeaderRowCount + 7, 0, "YF");
      axCellTableColumn.SetCellString(5, cellHeaderRowCount + 7, 0, "ZBMC");
      axCellTableColumn.SetCellString(6, cellHeaderRowCount + 7, 0, "CJ");
      axCellTableColumn.SetCellString(7, cellHeaderRowCount + 7, 0, "HC");
      axCellTableColumn.SetCellString(8, cellHeaderRowCount + 7, 0, "ZBDM");
      axCellTableColumn.SetCellString(9, cellHeaderRowCount + 7, 0, "JLDW");
      axCellTableColumn.SetCellString(10, cellHeaderRowCount + 7, 0, "QYJY");
      axCellTableColumn.SetCellString(11, cellHeaderRowCount + 7, 0, "XSYC");
      axCellTableColumn.SetCellString(12, cellHeaderRowCount + 7, 0, "SFKBJ");
      axCellTableColumn.SetCellString(13, cellHeaderRowCount + 7, 0, "SFMJ");
      axCellTableColumn.SetCellString(axCellTableColumn.GetCols(0) - 1, cellHeaderRowCount + 7, 0, "rowid");

      axCellTableColumn.SetCellString(1, cellHeaderRowCount + 5, 0, "单位编码");
      axCellTableColumn.SetCellString(2, cellHeaderRowCount + 5, 0, "指标编码");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 5, 0, "年份");
      axCellTableColumn.SetCellString(4, cellHeaderRowCount + 5, 0, "月份");
      axCellTableColumn.SetCellString(5, cellHeaderRowCount + 5, 0, "指标名称");
      axCellTableColumn.SetCellString(6, cellHeaderRowCount + 5, 0, "层级");
      axCellTableColumn.SetCellString(7, cellHeaderRowCount + 5, 0, "行次");
      axCellTableColumn.SetCellString(8, cellHeaderRowCount + 5, 0, "指标代码");
      axCellTableColumn.SetCellString(9, cellHeaderRowCount + 5, 0, "计量单位");
      axCellTableColumn.SetCellString(10, cellHeaderRowCount + 5, 0, "启用禁用");
      axCellTableColumn.SetCellString(11, cellHeaderRowCount + 5, 0, "显示隐藏");
      axCellTableColumn.SetCellString(12, cellHeaderRowCount + 5, 0, "是否可编辑");
      axCellTableColumn.SetCellString(13, cellHeaderRowCount + 5, 0, "是否末级");

      axCellTableColumn.SetCellString(1, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(2, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 2, 0, "数字型");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 2, 0, "数字型");
      axCellTableColumn.SetCellString(4, cellHeaderRowCount + 2, 0, "数字型");
      axCellTableColumn.SetCellString(5, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(6, cellHeaderRowCount + 2, 0, "数字型");
      axCellTableColumn.SetCellString(7, cellHeaderRowCount + 2, 0, "数字型");
      axCellTableColumn.SetCellString(8, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(9, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(10, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(11, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(12, cellHeaderRowCount + 2, 0, "字符型");
      axCellTableColumn.SetCellString(13, cellHeaderRowCount + 2, 0, "字符型");

      axCellTableColumn.SetCellString(1, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(2, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(4, cellHeaderRowCount + 1, 0, "是");
      //axCellTableColumn.SetCellString(5, cellHeaderRowCount + 1, 0, "否");
      axCellTableColumn.SetCellString(6, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(7, cellHeaderRowCount + 1, 0, "是");
      //axCellTableColumn.SetCellString(8, cellHeaderRowCount + 1, 0, "否");
      //axCellTableColumn.SetCellString(9, cellHeaderRowCount + 1, 0, "否");
      axCellTableColumn.SetCellString(10, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(11, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(12, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(13, cellHeaderRowCount + 1, 0, "是");
      axCellTableColumn.SetCellString(axCellTableColumn.GetCols(0) - 1, cellHeaderRowCount + 1, 0, "是");

      axCellTableColumn.SetCellString(1, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(2, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(3, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(4, cellHeaderRowCount + 0, 0, "是");
      //axCellTableColumn.SetCellString(5, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(6, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(7, cellHeaderRowCount + 0, 0, "是");
      //axCellTableColumn.SetCellString(8, cellHeaderRowCount + 0, 0, "是");
      //axCellTableColumn.SetCellString(9, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(10, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(11, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(12, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(13, cellHeaderRowCount + 0, 0, "是");
      axCellTableColumn.SetCellString(axCellTableColumn.GetCols(0) - 1, cellHeaderRowCount + 0, 0, "是");
      #endregion
      #region
      for (int row = cellHeaderRowCount + 2; row < axCellTableColumn.GetRows(0) - 1; row++)
      {
        for (int col = 5; col < 10; col++)
        {
          axCellTableColumn.SetCellInput(col, row, 0, 5);
        }
      }
      for (int row = cellHeaderRowCount + 2; row < axCellTableColumn.GetRows(0); row++)
      {
        axCellTableColumn.SetCellInput(axCellTableColumn.GetCols(0) - 1, row, 0, 5);
      }
      #endregion
    }

    private bool SaveTableColumn()
    {
      if (isEdit)
      {
        DeleteTableColumn();
      }
      bool flag = false;
      BLL.ENCO_BBZD_List bll = new BLL.ENCO_BBZD_List();
      int cols = axCellTableColumn.GetCols(0) - 14 + 50;
      int cellHeaderRowsCount = axcellTableHeader.GetRows(0);
      Model.ENCO_BBZD_List model = new Model.ENCO_BBZD_List(axCellTableColumn.GetCols(0) - 2);
      for (int i = axCellTableColumn.GetCols(0) - 2; i > 0; i--)
      {
        model.BBBM[i - 1] = txtTableNum.Text;
        //model.ZD[i - 1] = "COL" + i.ToString();
        model.Sfzd[i - 1] = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 0, 0);
        model.Sfyc[i - 1] = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 1, 0);
        model.SJLX[i - 1] = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 2, 0);
        model.FLYC[i - 1] = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 4, 0);
        //精度
        string pre = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 3, 0);
        if (pre != "")
        {
          model.SJJD[i - 1] = int.Parse(pre);
        }
        //字段注释
        model.ZDZS[i - 1] = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 5, 0);
        //排序号
        string sort = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 6, 0);
        if (sort == "")
        {
          model.ZDSX[i - 1] = i;
        }
        else
        {
          model.ZDSX[i - 1] = Convert.ToInt32(sort);
        }
        axCellTableColumn.SetCellString(i, cellHeaderRowsCount + 6, 0, model.ZDSX[i - 1].ToString());
        //字段名
        string columnName = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 7, 0);
        if (columnName == "")
        {
          model.ZD[i - 1] = "COL" + (--cols).ToString();
          AddColomn(model.ZD[i - 1], model.SJLX[i - 1], pre);//数据库增加一列
        }
        else
        {
          model.ZD[i - 1] = columnName;
        }
        axCellTableColumn.SetCellString(i, cellHeaderRowsCount + 7, 0, model.ZD[i - 1]);
        model.SJCD[i - 1] = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 8, 0);
        model.Sfhz[i - 1] = axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 9, 0);
        model.WIDTH1[i - 1] = Convert.ToDecimal(axCellTableColumn.GetCellString(i, cellHeaderRowsCount + 10, 0));
      }
      flag = bll.Add(model);
      return flag;
    }

    private bool AddColomn(string columnName, string type, string pre)
    {
      bool flag = false;
      string columnType = "";
      if (type == "字符型")
      {
        columnType = "varchar2(200)";
      }
      else
      {
        if (pre == "")
        {
          columnType = "number";
        }
        else
        {
          columnType = "number(18," + pre + ")";
        }
      }
      Common.DDL.DDLExecute.AddColumn(txtTableNum.Text, columnName, columnType);
      return flag;
    }

    private bool DeleteTableColumn()
    {
      bool flag = false;
      BLL.ENCO_BBZD bll = new BLL.ENCO_BBZD();
      flag = bll.Delete(txtTableNum.Text);
      return flag;
    }
    #endregion

    #region 报表指标配置
    private void InitTableIndexCell()
    {
      axCellTableIndex.SetCellString(1, 0, 0, "指标编码");
      axCellTableIndex.SetCellString(2, 0, 0, "指标名称");
      axCellTableIndex.SetCellString(3, 0, 0, "指标代码");
      axCellTableIndex.SetCellString(4, 0, 0, "计量单位");
      axCellTableIndex.SetCellString(5, 0, 0, "是否可编辑");
      axCellTableIndex.SetCellString(6, 0, 0, "启用禁用");
      axCellTableIndex.SetCellString(7, 0, 0, "层级");
      axCellTableIndex.SetCellString(8, 0, 0, "显示隐藏");
      axCellTableIndex.SetCellString(9, 0, 0, "是否末级");
      axCellTableIndex.SetCellString(10, 0, 0, "创建单位");
      axCellTableIndex.SetCellString(11, 0, 0, "创建时间");
      axCellTableIndex.SetCellString(12, 0, 0, "上级编码");
      axCellTableIndex.SetCellString(13, 0, 0, "上级汇总编码");
      axCellTableIndex.SetCols(14, 0);
      if (isEdit && _mode != "3") //编辑并且为继承状态时
      {
        BLL.ENCO_ZBBMB bll = new BLL.ENCO_ZBBMB();
        List<Model.ENCO_ZBBMB> modelList = bll.GetModelList(" bbbm='" + txtTableNum.Text + "'");
        axCellTableIndex.SetRows(modelList.Count + 1, 0);
        for (int i = 0; i < modelList.Count; i++)
        {
          Model.ENCO_ZBBMB model = modelList[i];
          if (model == null)
            return;
          axCellTableIndex.SetCellString(1, i + 1, 0, model.ZBBM);
          axCellTableIndex.SetCellString(2, i + 1, 0, model.ZBMC);
          axCellTableIndex.SetCellString(3, i + 1, 0, model.ZBDM);
          axCellTableIndex.SetCellString(4, i + 1, 0, model.JLDW1);
          axCellTableIndex.SetDroplistCell(5, i + 1, 0, "是\t是\r\n否\t否", 4);
          axCellTableIndex.SetDroplistCellKey(5, i + 1, 0, model.SFKBJ);
          axCellTableIndex.SetDroplistCell(6, i + 1, 0, "启用\t启用\r\n禁用\t禁用", 4);
          axCellTableIndex.SetDroplistCellKey(6, i + 1, 0, model.QYJY);
          axCellTableIndex.SetCellString(7, i + 1, 0, model.CJ.ToString());
          axCellTableIndex.SetDroplistCell(8, i + 1, 0, "显示\t显示\r\n隐藏\t隐藏", 4);
          axCellTableIndex.SetDroplistCellKey(8, i + 1, 0, model.XSYC);
          axCellTableIndex.SetDroplistCell(9, i + 1, 0, "是\t是\r\n否\t否", 4);
          axCellTableIndex.SetDroplistCellKey(9, i + 1, 0, model.SFMJ);
          axCellTableIndex.SetCellString(10, i + 1, 0, model.BZSZ1);
          axCellTableIndex.SetCellString(11, i + 1, 0, model.BZSZ2);
          axCellTableIndex.SetCellString(12, i + 1, 0, model.Sjzbbm);
          axCellTableIndex.SetCellString(13, i + 1, 0, model.Sjhzbm);
        }
      }
      else
      {
        axCellTableIndex.SetRows(2, 0);
        axCellTableIndex.SetDroplistCell(5, 1, 0, "是\t是\r\n否\t否", 4);
        axCellTableIndex.SetDroplistCellKey(5, 1, 0, "是");
        axCellTableIndex.SetDroplistCell(6, 1, 0, "启用\t启用\r\n禁用\t禁用", 4);
        axCellTableIndex.SetDroplistCellKey(6, 1, 0, "启用");
        //axCellTableIndex.SetDroplistCell(7, 1, 0, "是\t是\r\n否\t否", 4);
        //axCellTableIndex.SetDroplistCellKey(7, 1, 0, "否");
        axCellTableIndex.SetCellInput(7, 1, 0, 3);
        axCellTableIndex.SetDroplistCell(8, 1, 0, "显示\t显示\r\n隐藏\t隐藏", 4);
        axCellTableIndex.SetDroplistCellKey(8, 1, 0, "显示");
        axCellTableIndex.SetDroplistCell(9, 1, 0, "是\t是\r\n否\t否", 4);
        axCellTableIndex.SetDroplistCellKey(9, 1, 0, "否");
      }
      for (int i = 0; i < axCellTableIndex.GetCols(0); i++)
      {
        int width = axCellTableIndex.GetColBestWidth(i);
        axCellTableIndex.SetColWidth(1, width, i, 0);
      }
      axCellTableIndex.SetCellInput(1, -1, 0, 5);
      axCellTableIndex.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);
    }

    private void tableIndexCell_MenuStart(object sender, AxCELL50Lib._DCell2000Events_MenuStartEvent e)
    {
      if (e.section == 1)
      {
        axCellTableIndex.AddPopMenu(1100, "复制", 0);
        axCellTableIndex.AddPopMenu(1101, "粘贴", 0);
      }
      if (e.section == 2)
      {
        axCellTableIndex.AddPopMenu(1200, "添加指标", 0);
        if (isEdit)
        {
          axCellTableIndex.AddPopMenu(1201, "删除指标", 0);
          axCellTableIndex.AddPopMenu(1202, "上移", 0);
          axCellTableIndex.AddPopMenu(1203, "下移", 0);
        }
        //tableIndexCell.AddPopMenu(1202, "剪切", 0);
        //tableIndexCell.AddPopMenu(1203, "复制", 0);
        //tableIndexCell.AddPopMenu(1204, "粘贴", 0);
      }
    }

    private void tableIndexCell_MenuCommand(object sender, AxCELL50Lib._DCell2000Events_MenuCommandEvent e)
    {
      //if (isHeader(tableIndexCell))
      //{
      //  return;
      //}
      int startRow = 0, startCol = 0, endRow = 0, endCol = 0;
      axCellTableIndex.GetSelectRange(ref startCol, ref startRow, ref endCol, ref endRow);
      switch (e.itemid)
      {
        case 1100://复制
          axCellTableIndex.CopyRange(startCol, startRow, endCol, endRow);
          break;
        case 1101://粘贴
          if (startCol == 1)
          {
            return;
          }
          Common.Control.CellCommon.PasteData(axCellTableIndex);
          for (int i = 0; i < axCellTableIndex.GetRows(0); i++)
          {
            axCellTableIndex.SetDroplistCell(5, i + startRow, 0, "是\t是\r\n否\t否", 4);
            axCellTableIndex.SetDroplistCellKey(5, i + startRow, 0, "是");
            axCellTableIndex.SetDroplistCell(6, i + startRow, 0, "启用\t启用\r\n禁用\t禁用", 4);
            axCellTableIndex.SetDroplistCellKey(6, i + startRow, 0, "启用");
            axCellTableIndex.SetDroplistCell(9, startRow + i, 0, "是\t是\r\n否\t否", 4);
            axCellTableIndex.SetDroplistCellKey(9, startRow + i, 0, "否");
            axCellTableIndex.SetDroplistCell(8, i + startRow, 0, "显示\t显示\r\n隐藏\t隐藏", 4);
            axCellTableIndex.SetDroplistCellKey(8, i + startRow, 0, "显示");
          }
          break;

        case 1200://添加指标
          axCellTableIndex.InsertRow(startRow + 1, 1, 0);
          axCellTableIndex.SetDroplistCell(5, startRow + 1, 0, "是\t是\r\n否\t否", 4);
          axCellTableIndex.SetDroplistCellKey(5, startRow + 1, 0, "是");
          axCellTableIndex.SetDroplistCell(6, startRow + 1, 0, "启用\t启用\r\n禁用\t禁用", 4);
          axCellTableIndex.SetDroplistCellKey(6, startRow + 1, 0, "启用");
          axCellTableIndex.SetDroplistCell(9, startRow + 1, 0, "是\t是\r\n否\t否", 4);
          axCellTableIndex.SetDroplistCellKey(9, startRow + 1, 0, "否");
          axCellTableIndex.SetDroplistCell(8, startRow + 1, 0, "显示\t显示\r\n隐藏\t隐藏", 4);
          axCellTableIndex.SetDroplistCellKey(8, startRow + 1, 0, "显示");
          break;
        case 1201://删除指标
          if (axCellTableIndex.GetRows(0) > 2)
          {
            string cell = axCellTableIndex.GetCellString(1, startRow, 0);
            //MessageBox.Show(cell);
            if (string.IsNullOrEmpty(cell))
            {
              axCellTableIndex.DeleteRow(startRow, 1, 0);
            }
          }
          break;
        case 1202://上移
          if (startRow > 1)
          {
            for (int i = 0; i <= endCol; i++)
            {
              string cell1 = axCellTableIndex.GetCellString(i, startRow, 0);
              string cell2 = axCellTableIndex.GetCellString(i, startRow - 1, 0);
              axCellTableIndex.SetCellString(i, startRow, 0, cell2);
              axCellTableIndex.SetCellString(i, startRow - 1, 0, cell1);
            }
          }
          break;
        case 1203://下移
          if (endRow < axCellTableIndex.GetRows(0) - 1)
          {
            for (int i = 0; i <= endCol; i++)
            {
              string cell1 = axCellTableIndex.GetCellString(i, startRow, 0);
              string cell2 = axCellTableIndex.GetCellString(i, startRow + 1, 0);
              axCellTableIndex.SetCellString(i, startRow, 0, cell2);
              axCellTableIndex.SetCellString(i, startRow + 1, 0, cell1);
            }
          }
          break;
        //case 1204://粘贴
        //  tableIndexCell.InsertRow(startRow + 1, 1, 0);
        //  tableIndexCell.Paste(1, startRow, 0, 0, 0);
        //  break;
        default:
          {
            break;
          }
      }
    }

    private bool SaveTableIndex()
    {
      if (isEdit)
      {
        DeleteTableIndex();
      }
      bool flag = false;
      //BLL.login login = new BLL.login();
      //string userid = login.GetUserid(MainForm.Current.Loginname);
      string dw = GetDW();
      BLL.ENCO_ZBBMB_List bll = new BLL.ENCO_ZBBMB_List();
      int rows = axCellTableIndex.GetRows(0);
      Model.ENCO_ZBBMB_List model = new Model.ENCO_ZBBMB_List(rows - 1);
      for (int i = axCellTableIndex.GetRows(0) - 1; i > 0; i--)
      {
        model.BBBM[i - 1] = txtTableNum.Text;
        string zbbm = axCellTableIndex.GetCellString(1, i, 0);
        if (zbbm == "")//当指标编码为新增时
        {
          zbbm = txtTableNum.Text + string.Format("{0:D4}", --rows);
          axCellTableIndex.SetCellString(1, i, 0, zbbm);
          model.ZBBM[i - 1] = zbbm;
        }
        else
        {
          model.ZBBM[i - 1] = zbbm;
        }
        model.ZBMC[i - 1] = axCellTableIndex.GetCellString(2, i, 0).Trim();
        model.ZBDM[i - 1] = axCellTableIndex.GetCellString(3, i, 0);
        model.JLDW1[i - 1] = axCellTableIndex.GetCellString(4, i, 0);
        model.SFKBJ[i - 1] = axCellTableIndex.GetCellString(5, i, 0);
        model.QYJY[i - 1] = axCellTableIndex.GetCellString(6, i, 0);
        model.CJ[i - 1] = axCellTableIndex.GetCellString(7, i, 0) == "" ? 1 : int.Parse(axCellTableIndex.GetCellString(7, i, 0));
        model.XSYC[i - 1] = axCellTableIndex.GetCellString(8, i, 0);
        model.SFMJ[i - 1] = axCellTableIndex.GetCellString(9, i, 0);
        model.HC[i - 1] = i;
        model.BZSZ1[i - 1] = axCellTableIndex.GetCellString(10, i, 0) == "" ? dw : axCellTableIndex.GetCellString(10, i, 0);//创建人
        model.BZSZ2[i - 1] = axCellTableIndex.GetCellString(11, i, 0) == "" ?
          DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : axCellTableIndex.GetCellString(11, i, 0);
        model.Sjzbbm[i - 1] = axCellTableIndex.GetCellString(12, i, 0);
        model.Sjhzbm[i - 1] = axCellTableIndex.GetCellString(13, i, 0);
      }
      flag = bll.Add(model);
      return flag;
    }

    private bool DeleteTableIndex()
    {
      bool flag = false;
      BLL.ENCO_ZBBMB bll = new BLL.ENCO_ZBBMB();
      flag = bll.Delete(txtTableNum.Text);
      return flag;
    }
    #endregion

    #region 报表单元格精度配置
    private void InitTableCellPreCell()
    {
      int cellHeaderRowCount = axcellTableHeader.GetRows(0);
      axCellTableCellPre.SetRows(axCellTableIndex.GetRows(0) + cellHeaderRowCount - 1, 0);
      axCellTableCellPre.SetCols(axcellTableHeader.GetCols(0), 0);
      axCellTableCellPre.DrawGridLine(1, 1, 1000, 1000, 0, 2, -1);

      //初始化，使本表指标名称等于指标配置tab 
      for (int i = 1; i < axCellTableIndex.GetRows(0); i++)
      {
        axCellTableCellPre.SetCellString(5, cellHeaderRowCount + i - 1, 0, axCellTableIndex.GetCellString(2, i, 0));
        //int width = axCellTableCellPre.GetColBestWidth(1);
        //axCellTableCellPre.SetColWidth(1, width, 1, 0);
      }
      for (int j = 1; j < axCellTableCellPre.GetCols(0); j++)
      {
        string type = axCellTableColumn.GetCellString(j, cellHeaderRowCount + 2, 0);
        if (type == "数字型")
        {
          for (int i = cellHeaderRowCount; i < axCellTableCellPre.GetRows(0); i++)
          {
            axCellTableCellPre.SetCellInput(j, i, 0, 3);
            //axCellTableCellPre.SetCellDouble(j, i, 0, 4);
          }
        }
        else
        {
          for (int i = cellHeaderRowCount; i < axCellTableCellPre.GetRows(0); i++)
          {
            axCellTableCellPre.SetCellInput(j, i, 0, 5);
            //axCellTableCellPre.SetCellDouble(j, i, 0, 4);
          }
        }
      }
      for (int i = 0; i < cellHeaderRowCount; i++)
      {
        //axCellTableCellPre.SetCellFontSize(i, 1, 0, 9);
        int height = axCellTableCellPre.GetRowBestHeight(i);
        axCellTableCellPre.SetRowHeight(1, height, i, 0);
      }
      for (int i = 0; i < axCellTableCellPre.GetRows(0); i++)
      {
        int width = axCellTableCellPre.GetColBestWidth(i);
        axCellTableCellPre.SetColWidth(1, width, i, 0);
      }

      axCellTableCellPre.SetColHidden(1, 1);
      axCellTableCellPre.SetColHidden(2, 2);
      axCellTableCellPre.SetColHidden(3, 3);
      axCellTableCellPre.SetColHidden(4, 4);
      axCellTableCellPre.SetColHidden(7, 7);
      axCellTableCellPre.SetColHidden(6, 6);
      axCellTableCellPre.SetColHidden(10, 10);
      axCellTableCellPre.SetColHidden(11, 11);
      axCellTableCellPre.SetColHidden(12, 12);
      axCellTableCellPre.SetColHidden(13, 13);
      //axCellTableCellPre.SetColHidden(axcellTableHeader.GetCols(0) - 1, axcellTableHeader.GetCols(0) - 1);
    }

    private void InitTableCellPreNum()
    {
      int cellHeaderRowCount = axcellTableHeader.GetRows(0);
      //只能输入数字
      BLL.ENCO_SJJDJJBL bll = new BLL.ENCO_SJJDJJBL();
      Dictionary<string, Model.ENCO_SJJDJJBL> modelList = bll.GetHashList_BBBM(txtTableNum.Text);
      //List<Model.ENCO_SJJDJJBL> modelList = bll.GetModelList_BBBM(txtTableNum.Text);
      //int index = 0;
      for (int j = 14; j < axCellTableCellPre.GetCols(0) - 1; j++)
      {
        string type = axCellTableColumn.GetCellString(j, cellHeaderRowCount + 2, 0);
        if (type == "数字型")
        {
          for (int i = cellHeaderRowCount; i < axCellTableCellPre.GetRows(0); i++)
          {
            axCellTableCellPre.SetCellInput(j, i, 0, 3);
            if (isEdit)
            {
              //int index = (i - cellHeaderRowCount) * (axCellTableCellPre.GetCols(0) - 1) + (j - 1);
              string zbbm = axCellTableIndex.GetCellString(1, i - cellHeaderRowCount + 1, 0);
              string zd = axCellTableColumn.GetCellString(j, cellHeaderRowCount + 7, 0);
              string key = txtTableNum.Text + "," + zbbm + "," + zd;
              if (modelList.ContainsKey(key))
              {
                Model.ENCO_SJJDJJBL model = modelList[key];
                if (model == null)
                  return;
                axCellTableCellPre.SetCellDouble(j, i, 0, (double)model.SJJD);
              }
              //index++;
            }
            //else
            //{
            //  axCellTableCellPre.SetCellDouble(j, i, 0, 4);
            //}
          }
        }
      }
    }

    private bool SaveTableCell()
    {
      if (isEdit)
      {
        DeleteTableCell();
      }
      bool flag = false;
      BLL.ENCO_SJJDJJBL_List bll = new BLL.ENCO_SJJDJJBL_List();
      List<decimal> sjjd = new List<decimal>();
      List<string> bbbm = new List<string>();
      List<string> zbbm = new List<string>();
      List<string> zd = new List<string>();
      int cellHeaderRowCount = axcellTableHeader.GetRows(0);
      for (int i = cellHeaderRowCount; i < axCellTableCellPre.GetRows(0); i++)
      {
        for (int j = 14; j < axCellTableCellPre.GetCols(0) - 1; j++)
        {
          string type = axCellTableColumn.GetCellString(j, cellHeaderRowCount + 2, 0);
          if (type == "数字型")
          {
            string jd = axCellTableCellPre.GetCellString(j, i, 0);
            if (jd != "")
            {
              bbbm.Add(txtTableNum.Text);
              zbbm.Add(axCellTableIndex.GetCellString(1, i - cellHeaderRowCount + 1, 0));
              zd.Add(axCellTableColumn.GetCellString(j, cellHeaderRowCount + 7, 0));
              sjjd.Add(int.Parse(jd));
            }
          }
        }
      }
      int length = 0;
      length = bbbm.Count;
      if (length == 0)
      { return true; }

      Model.ENCO_SJJDJJBL_List model = new Model.ENCO_SJJDJJBL_List(length);
      model.BBBM = bbbm.ToArray();
      model.ZBBM = zbbm.ToArray();
      model.ZD = zd.ToArray();
      model.SJJD = sjjd.ToArray();
      flag = bll.Add(model);
      return flag;
      #region
      //int index = 0;
      //for (int i = cellHeaderRowCount; i < axCellTableCellPre.GetRows(0); i++)
      //{
      //  for (int j = 1; j < axCellTableCellPre.GetCols(0); j++)
      //  {
      //    string type = axCellTableColumn.GetCellString(j, cellHeaderRowCount + 2, 0);
      //    if (type == "数字型")
      //    {
      //      //int index = (i - cellHeaderRowCount) * (axCellTableCellPre.GetCols(0) - 1) + j - 1;
      //      model.BBBM[index] = txtTableNum.Text;
      //      model.ZBBM[index] = axCellTableIndex.GetCellString(1, i - cellHeaderRowCount + 1, 0);
      //      model.ZD[index] = axCellTableColumn.GetCellString(j, cellHeaderRowCount + 7, 0);
      //      decimal jd = (decimal)axCellTableCellPre.GetCellDouble(j, i, 0);
      //      model.SJJD[index] = jd;
      //      index++;
      //    }
      //  }
      //}
      #endregion
    }

    private bool DeleteTableCell()
    {
      bool flag = false;
      BLL.ENCO_SJJDJJBL bll = new BLL.ENCO_SJJDJJBL();
      flag = bll.Delete(txtTableNum.Text);
      return flag;
    }
    #endregion

    #region 报表个性化配置

    #endregion

    #region 保存到xml
    private bool SaveXml()
    {
      if (isEdit)
      {
        DeleteXml();
      }
      bool flag = false;
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      model_xml.YEAR = MainForm.Current.Version;
      model_xml.BBBM = txtTableNum.Text;
      //model_xml.BBBM = "uuu";
      model_xml.ROWCOUNT = axcellTableHeader.GetRows(0) - 1;
      model_xml.COLUMNCOUNT = axcellTableHeader.GetCols(0) - 1;
      if (!isEdit)
      {
        model_xml.ORDERBY = isAddRow.Checked ? "ZBBM" : "HC";
      }
      //获取标题和坐标
      string caption = "", coordinates = "";
      Classes.SaveCell.SaveCellHeader(axcellTableHeader, txtTableNum.Text, ref caption, ref coordinates);
      model_xml.CAPTION = caption;
      model_xml.COORDINATES = coordinates;
      //HiddenColumn
      string HiddenColumn = "", NotAllowEditColumn = "", selectSort = "";
      for (int i = 1; i < axCellTableColumn.GetCols(0); i++)
      {
        string value = axCellTableColumn.GetCellString(i, model_xml.ROWCOUNT + 2, 0);
        string zd = axCellTableColumn.GetCellString(i, model_xml.ROWCOUNT + 8, 0);
        if (value == "是")
        {
          HiddenColumn += zd + ",";
        }
        value = axCellTableColumn.GetCellString(i, model_xml.ROWCOUNT + 1, 0);
        if (value == "是")
        {
          NotAllowEditColumn += zd + ",";
        }
        value = axCellTableColumn.GetCellString(i, model_xml.ROWCOUNT + 8, 0);
        selectSort += value + ",";
      }
      model_xml.HIDDENCOLUMN = HiddenColumn.Trim(new char[] { ',' });
      model_xml.NotAllowEditColumn = NotAllowEditColumn.Trim(new char[] { ',' });
      //model_xml.NotAllowEditColumn = "0,1,2,3,4,5,6,7,8,9,10,11,12";
      model_xml.SELECTFIELD = selectSort.Trim(new char[] { ',' }) + ",rowid ";
      //HiddenRow
      string HiddenRow = "", NotAllowEditRow = "";
      for (int i = 1; i < axCellTableIndex.GetRows(0); i++)
      {
        string value = axCellTableIndex.GetCellString(8, i, 0);
        if (value == "隐藏")
        {
          string zbbm = axCellTableIndex.GetCellString(1, i, 0);
          HiddenRow += zbbm + ",";
        }
        //value = axCellTableIndex.GetCellString(5, i, 0);
        //if (value == "否")
        //{
        //  NotAllowEditRow += (i - 1).ToString() + ",";
        //}
      }
      model_xml.HIDDENROW = HiddenRow.Trim(new char[] { ',' });
      model_xml.NOTALLOWEDITROW = NotAllowEditRow.Trim(new char[] { ',' });
      model_xml.Title = txtTableHeader.Text;
      flag = bll.Add(model_xml);
      Classes.SaveCell.SaveXML(model_xml, MainForm.Current.Version.ToString());
      //flag = true;
      return flag;
    }

    private bool DeleteXml()
    {
      bool flag = false;
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      bll.Delete(MainForm.Current.Version, txtTableNum.Text);
      return flag;
    }

    private void InitXml()
    {
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      model_xml = bll.GetModel(MainForm.Current.Version, txtTableNum.Text);

    }
    #endregion
  }
}
