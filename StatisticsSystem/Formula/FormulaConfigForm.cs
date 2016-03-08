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
  public partial class FormulaConfigForm : Form, MainForm.ICipherInputForm
  {
    StatisticsSystem.BLL.ENCO_BBZD bll_zd = new BLL.ENCO_BBZD();
    StatisticsSystem.BLL.ENCO_JSXX bll_jsxx = new BLL.ENCO_JSXX();
    Model.XMLVERSION model_xml = new Model.XMLVERSION();
    //private int cellHeaderRowCount = 0;//表头行数
    string tableNum = "", dwbm, year, month;//当前表名
    string[] columnNameList;//字段名列表
    int[,] jsxxidArray;//保存jsxxid

    #region 初始化
    public FormulaConfigForm()
    {
      InitializeComponent();
    }

    public FormulaConfigForm(string _tableNum, string _dwbm, string _year, string _month)
    {
      InitializeComponent();
      this.tableNum = _tableNum;
      this.year = _year;
      this.month = _month;
      this.dwbm = _dwbm;
      BLL.CODE_BBBMB bll = new BLL.CODE_BBBMB();
      Model.CODE_BBBMB model = bll.GetModel(_tableNum);
      this.Text = "报表公式配置_" + model.BBWH;
      InitXml();
      InitCell();
    }

    private void InitCell()
    {
      //Classes.InitCell.InitCellHeader(axCellFormulaConfig, tableNum, ref cellHeaderRowCount);
      //axCellFormulaConfig.SetColHidden(axCellFormulaConfig.GetCols(0)-1, axCellFormulaConfig.GetCols(0)-1);
      axCellFormulaConfig.SetRows(model_xml.ROWCOUNT + 1, 0);
      axCellFormulaConfig.SetCols(model_xml.COLUMNCOUNT + 2, 0);
      Classes.InitCell.InitCellHeader(axCellFormulaConfig, model_xml);
      columnNameList = bll_zd.GetColumnName(tableNum);
      Classes.InitCell.InitCellIndex(axCellFormulaConfig, tableNum, model_xml.ROWCOUNT);
      jsxxidArray = new int[axCellFormulaConfig.GetRows(0), axCellFormulaConfig.GetCols(0) - 1];
      Classes.InitCell.InitCellFormula(axCellFormulaConfig, tableNum, year, month, dwbm,
        columnNameList, model_xml.ROWCOUNT, jsxxidArray);
      InitTableHeaderColor(axCellFormulaConfig);
      InitCellReadOnly();
      axCellFormulaConfig.SetFixedRow(1, model_xml.ROWCOUNT);
      axCellFormulaConfig.AllowDragdrop = false;
      axCellFormulaConfig.SetColHidden(1, 1);
      axCellFormulaConfig.SetColHidden(2, 2);
      axCellFormulaConfig.SetColHidden(3, 3);
      axCellFormulaConfig.SetColHidden(4, 4);
      axCellFormulaConfig.SetColHidden(6, 6);
      axCellFormulaConfig.SetColHidden(7, 7);
      axCellFormulaConfig.SetColHidden(10, 10);
      axCellFormulaConfig.SetColHidden(11, 11);
      axCellFormulaConfig.SetColHidden(12, 12);
      axCellFormulaConfig.SetColHidden(13, 13);
      axCellFormulaConfig.SetColHidden(axCellFormulaConfig.GetCols(0) - 2, axCellFormulaConfig.GetCols(0) - 2);
      axCellFormulaConfig.SetFixedCol(1, 13);
    }

    private void InitCellReadOnly()
    {
      BLL.ENCO_BBZD bll = new BLL.ENCO_BBZD();
      List<Model.ENCO_BBZD> modelList = bll.GetModelList_BBBM(tableNum);
      for (int i = 0; i < modelList.Count; i++)
      {
        Model.ENCO_BBZD model = modelList[i];
        if (model.SJLX == "字符型")
        {
          axCellFormulaConfig.SetCellInput(i + 1, -1, 0, 5);
          for (int j = model_xml.ROWCOUNT + 1; j < axCellFormulaConfig.GetRows(0); j++)
          {
            axCellFormulaConfig.SetCellAlign(i + 1, j, 0, 1);
          }
        }
      }
      //禁用指标不可编辑
      BLL.ENCO_ZBBMB bll_zbbmb = new BLL.ENCO_ZBBMB();
      Dictionary<string, string> dicJY = bll_zbbmb.GetZBBMB_jy(tableNum);
      for (int i = 0; i < axCellFormulaConfig.GetRows(0); i++)
      {
        if (dicJY.ContainsKey(axCellFormulaConfig.GetCellString(axCellFormulaConfig.GetCols(0) - 1, i, 0)))
        {
          for (int col = 13; col < axCellFormulaConfig.GetCols(0); col++)
          {
            axCellFormulaConfig.SetCellInput(col, i, 0, 5);
          }
        }
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

    private void InitXml()
    {
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      model_xml = bll.GetModel(MainForm.Current.Version, tableNum);

    }

    private void FormulaConfigForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (axCellFormulaConfig.IsModified() == 1)
      {
        DialogResult result;
        result = MessageBox.Show("有未修改数据，是否保存？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        if (result == DialogResult.OK)
        {
          if (SaveJSXX(model_xml.ROWCOUNT + 1, axCellFormulaConfig.GetRows(0), 1, axCellFormulaConfig.GetCols(0) - 1))
          {
            { MessageBox.Show("保存成功"); };
          }
          else
          {

          }
        }
      }
    }
    #endregion

    #region 右键
    private void axCellFormulaConfig_MenuStart(object sender, AxCELL50Lib._DCell2000Events_MenuStartEvent e)
    {
      //if (e.section == 2)//左上角
      //{
      //}
      if (e.section == 1)//表格范围内
      {
        axCellFormulaConfig.AddPopMenu(1100, "引用报表", 0);
        axCellFormulaConfig.AddPopMenu(1101, "编辑公式", 0);
        axCellFormulaConfig.AddPopMenu(1102, "纵向顺序填充", 0);
        axCellFormulaConfig.AddPopMenu(1103, "删除公式", 0);
        axCellFormulaConfig.AddPopMenu(1104, "横向顺序填充", 0);
      }
    }

    private void axCellFormulaConfig_MenuCommand(object sender, AxCELL50Lib._DCell2000Events_MenuCommandEvent e)
    {
      Classes.FormulaCheck check = new Classes.FormulaCheck();
      switch (e.itemid)
      {
        case 1100://引用报表
          TableQuoteForm form00 = new TableQuoteForm(tableNum);
          form00.ShowDialog();
          break;
        case 1101://编辑公式
          #region
          int currentCol = axCellFormulaConfig.GetCurrentCol();
          int currentRow = axCellFormulaConfig.GetCurrentRow();
          string formula1101 = axCellFormulaConfig.GetCellString(currentCol, currentRow, 0).ToUpper();
          axCellFormulaConfig.SetCellString(currentCol, currentRow, 0, formula1101);
          string formulaNum = check.ConvertCharToNum(formula1101);
          //if (check.IsRepeat(formula1101))
          //{
          //  MessageBox.Show("存在重复字符");
          //  return;
          //}
          if (check.CheckFormula(formulaNum))
          {
            MessageBox.Show("公式格式有误");
            return;
          }
          if (currentRow <= model_xml.ROWCOUNT)
          {
            break;
          }
          if (string.IsNullOrEmpty(formula1101))
          {
            MessageBox.Show("请录入公式");
            break;
          }
          Model.ENCO_JSXX model_jsxx = new Model.ENCO_JSXX();
          int jsxxid = jsxxidArray[currentRow, currentCol];
          if (jsxxid == 0)//为空则先保存
          {
            model_jsxx = new Model.ENCO_JSXX();
            model_jsxx.JSXXID = bll_jsxx.GetJSXXID();
            model_jsxx.BBBM = tableNum;
            string indexName = axCellFormulaConfig.GetCellString(axCellFormulaConfig.GetCols(0) - 1, currentRow, 0);
            string columnName = columnNameList[currentCol - 1];
            model_jsxx.ZBBM = indexName;
            model_jsxx.ZD = columnName;
            model_jsxx.JSMS = formula1101;
            model_jsxx.DWBM = this.dwbm;
            bll_jsxx.Add(model_jsxx);
            jsxxidArray[currentRow, currentCol] = int.Parse(model_jsxx.JSXXID.ToString());
          }
          else
          {
            model_jsxx = bll_jsxx.GetModel(jsxxid);
            if (model_jsxx.JSMS != formula1101)
            {
              model_jsxx.JSMS = formula1101;
              bll_jsxx.Update(model_jsxx);
              BLL.ENCO_JSXXYSJ bll_ysj = new BLL.ENCO_JSXXYSJ();
              bll_ysj.Delete(model_jsxx.JSXXID);
            }
          }
          FormulaEditForm form01 = new FormulaEditForm(model_jsxx);
          form01.ShowDialog();
          break;
          #endregion
        case 1102://顺序填充
          #region
          int startRow = 0, startCol = 0, endRow = 0, endCol = 0;
          axCellFormulaConfig.GetSelectRange(ref startCol, ref startRow, ref endCol, ref endRow);
          if (startRow <= model_xml.ROWCOUNT)
          {
            break;
          }
          if (endCol - startCol > 0)
          {
            MessageBox.Show("只能选择一列填充");
            return;
          }
          if (endRow - startRow == 0)
          {
            MessageBox.Show("选择行数必须大于一行");
            return;
          }
          string formula1102 = axCellFormulaConfig.GetCellString(startCol, startRow, 0).ToUpper();
          axCellFormulaConfig.SetCellString(startCol, startRow, 0, formula1102);
          string formulaNum1102 = check.ConvertCharToNum(formula1102);
          if (check.CheckFormula(formulaNum1102))
          {
            MessageBox.Show("公式格式有误");
            return;
          }
          if (string.IsNullOrEmpty(formula1102))
          {
            MessageBox.Show("请录入公式");
            break;
          }
          FillFormula(startRow, endRow, startCol, endCol, formula1102);
          if (SaveJSXX(startRow + 1, endRow + 1, startCol, endCol + 1))
          {
            if (SaveJSXXYsj(startRow, endRow, startCol, endCol))
            {
              MessageBox.Show("保存成功");
            }
            else
            {
              DeleteFormula(startRow + 1, endRow, startCol, endCol);
              MessageBox.Show("失败");
            }
          }
          break;
          #endregion
        case 1103://删除公式
          #region
          startRow = 0; startCol = 0; endRow = 0; endCol = 0;
          axCellFormulaConfig.GetSelectRange(ref startCol, ref startRow, ref endCol, ref endRow);
          if (DeleteFormula(startRow, endRow, startCol, endCol))
          {
            MessageBox.Show("删除成功");
          }
          break;
          #endregion
        case 1104://横向
          #region
          startRow = 0; startCol = 0; endRow = 0; endCol = 0;
          axCellFormulaConfig.GetSelectRange(ref startCol, ref startRow, ref endCol, ref endRow);
          if (startRow <= model_xml.ROWCOUNT)
          {
            break;
          }
          if (endRow - startRow > 0)
          {
            MessageBox.Show("只能选择一行填充");
            return;
          }
          if (endCol - startCol == 0)
          {
            MessageBox.Show("选择列数必须大于一");
            return;
          }
          if (endCol == axCellFormulaConfig.GetCols(0) - 1)
          {
            return;
          }
          formula1102 = axCellFormulaConfig.GetCellString(startCol, startRow, 0).ToUpper();
          axCellFormulaConfig.SetCellString(startCol, startRow, 0, formula1102);
          formulaNum1102 = check.ConvertCharToNum(formula1102);
          if (check.CheckFormula(formulaNum1102))
          {
            MessageBox.Show("公式格式有误");
            return;
          }
          if (string.IsNullOrEmpty(formula1102))
          {
            MessageBox.Show("请录入公式");
            break;
          }
          FillFormula_H(startRow, endRow, startCol, endCol, formula1102);
          if (SaveJSXX(startRow, endRow + 1, startCol + 1, endCol + 1))
          {
            if (SaveJSXXYsj_H(startRow, endRow, startCol, endCol))
            {
              MessageBox.Show("保存成功");
            }
            else
            {
              DeleteFormula(startRow, endRow, startCol + 1, endCol);
              MessageBox.Show("失败");
            }
          }
          break;
          #endregion
      }
    }

    private bool DeleteFormula(int startRow, int endRow, int startCol, int endCol)
    {
      bool flag = false;
      int length = (endRow - startRow + 1) * (endCol - startCol + 1);
      Model.ENCO_JSXX_List model_jsxx = new Model.ENCO_JSXX_List(length);
      Model.ENCO_JSXXYSJ_List model_ysj = new Model.ENCO_JSXXYSJ_List(length);
      int index = 0;
      for (int row = startRow; row <= endRow; row++)
      {
        for (int col = startCol; col <= endCol; col++)
        {
          model_jsxx.JSXXID[index] = jsxxidArray[row, col];
          jsxxidArray[row, col] = 0;
          axCellFormulaConfig.SetCellString(col, row, 0, "");
          index++;
        }
      }
      model_ysj.JSXXID = model_jsxx.JSXXID;
      BLL.ENCO_JSXXYSJ_List bll_ysj = new BLL.ENCO_JSXXYSJ_List();
      BLL.ENCO_JSXX_List bll_jsxx = new BLL.ENCO_JSXX_List();
      flag = bll_jsxx.Delete(model_jsxx);
      bll_ysj.Delete(model_ysj);
      return flag;
    }

    private void FillFormula(int startRow, int endRow, int startCol, int endCol, string formula)
    {
      for (int i = startRow + 1; i <= endRow; i++)
      {
        axCellFormulaConfig.SetCellString(startCol, i, 0, formula);
      }
    }

    private void FillFormula_H(int startRow, int endRow, int startCol, int endCol, string formula)
    {
      for (int i = startCol + 1; i <= endCol; i++)
      {
        axCellFormulaConfig.SetCellString(i, startRow, 0, formula);
      }
    }

    private bool SaveJSXXYsj(int startRow, int endRow, int startCol, int endCol)
    {
      bool flag = false;
      Dictionary<string, Model.ENCO_ZBBMB> zbbmb = new Dictionary<string, Model.ENCO_ZBBMB>();
      Dictionary<string, Model.ENCO_ZBBMB> zbbmb_hc = new Dictionary<string, Model.ENCO_ZBBMB>();
      Model.ENCO_ZBBMB model_zbbmb = new Model.ENCO_ZBBMB();
      Model.ENCO_JSXXYSJ model_ysj = new Model.ENCO_JSXXYSJ();

      BLL.ENCO_ZBBMB bll_zbbmb = new BLL.ENCO_ZBBMB();
      bll_zbbmb.GetZBBMB_YYBB(tableNum, zbbmb, zbbmb_hc);
      BLL.ENCO_JSXXYSJ bll_ysj = new BLL.ENCO_JSXXYSJ();

      int jsxxid = jsxxidArray[startRow, startCol];
      //DataSet ds = bll_ysj.GetList_jsxxid(jsxxid);
      List<Model.ENCO_JSXXYSJ> ysj_list = bll_ysj.GetModelList(" jsxxid=" + jsxxid);
      int length = (endRow - startRow) * ysj_list.Count;
      Model.ENCO_JSXXYSJ_List ysj_list_new = new Model.ENCO_JSXXYSJ_List(length);
      int hc = 0;
      int index = 0;

      for (int i = 0; i < ysj_list.Count; i++)//循环当前第一个单元格元素
      {
        model_ysj = ysj_list[i];
        model_zbbmb = zbbmb[model_ysj.OBBBM + "," + model_ysj.OZBBM];
        hc = int.Parse(model_zbbmb.HC.ToString());
        for (int row = startRow + 1; row <= endRow; row++)//循环行
        {
          ysj_list_new.JSXXID[index] = jsxxidArray[row, startCol];
          ysj_list_new.ONAME[index] = model_ysj.ONAME;
          ysj_list_new.OBBBM[index] = model_ysj.OBBBM;
          string zbbm = model_ysj.OBBBM + "," + (hc + 1).ToString();
          if (zbbmb_hc.ContainsKey(zbbm))
          {
            ysj_list_new.OZBBM[index] = zbbmb_hc[zbbm].ZBBM;
          }
          else
          {
            MessageBox.Show("指标不存在");
            return false;
          }
          ysj_list_new.OZD[index] = model_ysj.OZD;
          ysj_list_new.ODWBM[index] = model_ysj.ODWBM;
          ysj_list_new.ONF[index] = model_ysj.ONF;
          ysj_list_new.OYF[index] = model_ysj.OYF;
          index++;
          hc++;
        }
      }
      BLL.ENCO_JSXXYSJ_List bll_ysj_list = new BLL.ENCO_JSXXYSJ_List();
      bll_ysj_list.Delete(ysj_list_new);
      flag = bll_ysj_list.Add(ysj_list_new);

      return flag;
    }

    private bool SaveJSXXYsj_H(int startRow, int endRow, int startCol, int endCol)
    {
      bool flag = false;
      Dictionary<string, Model.ENCO_BBZD> bbzd = new Dictionary<string, Model.ENCO_BBZD>();
      Dictionary<string, Model.ENCO_BBZD> bbzd_hc = new Dictionary<string, Model.ENCO_BBZD>();
      Model.ENCO_BBZD model_bbzd = new Model.ENCO_BBZD();
      Model.ENCO_JSXXYSJ model_ysj = new Model.ENCO_JSXXYSJ();

      BLL.ENCO_BBZD bll_zbbmb = new BLL.ENCO_BBZD();
      bll_zbbmb.GetZBBMB_YYBB(tableNum, bbzd, bbzd_hc);
      BLL.ENCO_JSXXYSJ bll_ysj = new BLL.ENCO_JSXXYSJ();

      int jsxxid = jsxxidArray[startRow, startCol];
      //DataSet ds = bll_ysj.GetList_jsxxid(jsxxid);
      List<Model.ENCO_JSXXYSJ> ysj_list = bll_ysj.GetModelList(" jsxxid=" + jsxxid);
      int length = (endCol - startCol) * ysj_list.Count;
      Model.ENCO_JSXXYSJ_List ysj_list_new = new Model.ENCO_JSXXYSJ_List(length);
      int hc = 0;
      int index = 0;

      for (int i = 0; i < ysj_list.Count; i++)//循环当前第一个单元格元素
      {
        model_ysj = ysj_list[i];
        model_bbzd = bbzd[model_ysj.OBBBM + "," + model_ysj.OZD];
        Dictionary<string, int> bbzdsx = bll_zbbmb.GetDic_zdsx(model_ysj.OBBBM);
        hc = bbzdsx[model_bbzd.ZDSX.ToString()];
        for (int col = startCol + 1; col <= endCol; col++)//循环行
        {
          ysj_list_new.JSXXID[index] = jsxxidArray[startRow, col];
          ysj_list_new.ONAME[index] = model_ysj.ONAME;
          ysj_list_new.OBBBM[index] = model_ysj.OBBBM;
          ysj_list_new.OZBBM[index] = model_ysj.OZBBM;
          string zd = "";
          foreach (KeyValuePair<string, int> kvp in bbzdsx)//列增加1
          {
            if (kvp.Value == hc + 1)
            {
              zd = model_ysj.OBBBM + "," + kvp.Key;
            }
          }
          if (bbzd_hc.ContainsKey(zd))
          {
            ysj_list_new.OZD[index] = bbzd_hc[zd].ZD;
          }
          else
          {
            MessageBox.Show("指标不存在");
            return false;
          }
          ysj_list_new.ODWBM[index] = model_ysj.ODWBM;
          ysj_list_new.ONF[index] = model_ysj.ONF;
          ysj_list_new.OYF[index] = model_ysj.OYF;
          index++;
          hc++;
        }
      }
      BLL.ENCO_JSXXYSJ_List bll_ysj_list = new BLL.ENCO_JSXXYSJ_List();
      bll_ysj_list.Delete(ysj_list_new);
      flag = bll_ysj_list.Add(ysj_list_new);

      return flag;
    }
    #endregion

    #region 菜单
    private void menuClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void menuSave_Click(object sender, EventArgs e)
    {
      if (SaveJSXX(model_xml.ROWCOUNT + 1, axCellFormulaConfig.GetRows(0), 1, axCellFormulaConfig.GetCols(0) - 1))
      {
        MessageBox.Show("保存成功");
      }
    }

    private bool SaveJSXX(int startRow, int endRow, int startCol, int endCol)
    {
      bool flag = false;
      BLL.ENCO_JSXX_List bll = new BLL.ENCO_JSXX_List();
      List<decimal> jsxxid = new List<decimal>();
      List<string> bbbm = new List<string>();
      List<string> zbbm = new List<string>();
      List<string> zd = new List<string>();
      List<string> jsms = new List<string>();
      List<string> dwbm = new List<string>();
      List<string> nf = new List<string>();
      List<string> yf = new List<string>();
      int jsxxidNew = 0;
      string lockCellStr = "";
      for (int row = startRow; row < endRow; row++)
      {
        for (int col = startCol; col < endCol; col++)
        {
          string formula = axCellFormulaConfig.GetCellString(col, row, 0).ToUpper();
          if (formula != "")
          {
            Classes.FormulaCheck check = new Classes.FormulaCheck();
            string formulaNum = check.ConvertCharToNum(formula);
            if (!check.CheckFormula(formulaNum)) //当前公式合法时
            {
              int jsxxidUpdate = jsxxidArray[row, col];//已存在jsxxid，修改
              if (jsxxidUpdate == 0) //当此单元格为新增时
              {
                if (jsxxidNew == 0)//第一次从数据库获取最大JSXXID
                {
                  jsxxidNew = bll_jsxx.GetJSXXID();
                  jsxxidUpdate = jsxxidNew++;
                }
                else
                {
                  jsxxidUpdate = jsxxidNew++;
                }
              }
              jsxxidArray[row, col] = jsxxidUpdate;//同步更新二维数组
              jsxxid.Add(jsxxidUpdate);
              bbbm.Add(tableNum);
              zbbm.Add(axCellFormulaConfig.GetCellString(axCellFormulaConfig.GetCols(0) - 1, row, 0));
              zd.Add(columnNameList[col - 1]);
              jsms.Add(axCellFormulaConfig.GetCellString(col, row, 0));
              dwbm.Add(this.dwbm);
              nf.Add(string.IsNullOrEmpty(year) ? year : "[" + year + "]");
              yf.Add(string.IsNullOrEmpty(month) ? month : "[" + month + "]");
              axCellFormulaConfig.SetCellString(col, row, 0, formula);
              //保存单元格锁定
              lockCellStr += (col - 1).ToString() + "," + (col - 1).ToString() + ","
                + (row - model_xml.ROWCOUNT - 1).ToString() + "," + (row - model_xml.ROWCOUNT - 1).ToString() + "|";
            }
          }
        }
      }
      int length = jsxxid.Count;
      if (length == 0)
      { return false; }
      Model.ENCO_JSXX_List model = new Model.ENCO_JSXX_List(length);
      model.JSXXID = jsxxid.ToArray();
      model.BBBM = bbbm.ToArray();
      model.ZBBM = zbbm.ToArray();
      model.ZD = zd.ToArray();
      model.JSMS = jsms.ToArray();
      model.DWBM = dwbm.ToArray();
      model.NF = nf.ToArray();
      model.YF = yf.ToArray();
      bll.Delete(model);
      flag = bll.Add(model);
      //更新状态，为计算用
      BLL.JSXX_State bll2 = new BLL.JSXX_State();
      bll2.Update();
      //保存单元格锁定
      bll_jsxx.CreateLockcell(MainForm.Current.Version.ToString(), tableNum);
      #region
      //if (this.dwbm == "")  //当单位都为空，保存在xmlversion时
      //{
      //  model_xml.LOCKCELL = lockCellStr.Trim(new char[] { '|' });
      //  SaveCellLock();
      //}
      //else
      //{
      //  //不同单位时，lockcell保存表不同
      //  BLL.XMLVERSION_DW_LOCKCELL bll_lock = new BLL.XMLVERSION_DW_LOCKCELL();
      //  string yearT = this.year == "" ? MainForm.Current.Version.ToString() : this.year;
      //  Model.XMLVERSION_DW_LOCKCELL model_lock = bll_lock.GetModel(decimal.Parse(yearT), this.tableNum, this.dwbm);
      //  if (model_lock == null)
      //  {
      //    model_lock = new Model.XMLVERSION_DW_LOCKCELL();
      //    model_lock.BBBM = this.tableNum;
      //    model_lock.DWBM = this.dwbm;
      //    model_lock.YEAR = decimal.Parse(yearT);
      //  }
      //  model_lock.LOCKCELL = lockCellStr.Trim(new char[] { '|' });
      //  bll_lock.Delete(decimal.Parse(yearT), this.tableNum, this.dwbm);
      //  bll_lock.Add(model_lock);
      //}
      #endregion
      axCellFormulaConfig.SetModified(0);
      return flag;
    }

    private bool SaveCellLock()
    {
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      bool flag = bll.Update(model_xml);
      //Classes.SaveCell.SaveXML(model_xml, MainForm.Current.Version.ToString());
      return flag;
      //return true;
    }

    #endregion//Tools为你子窗体的工具栏.注意将其Visible = false;

    public ToolStrip CipherToolStrip
    {
      get
      {
        return Tools;
      }
    }
  }
}
