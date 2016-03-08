using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StatisticsSystem.Formula;

namespace StatisticsSystem.TableConfig
{
  public partial class OpenForm : Form
  {
    private int mode = 0;//1为打开报表 2 公式配置 3 继承新建报表 4 校验配置 5 报表对应列单位选择配置
    //6 单位指标对应配置 7 单位列对应配置 8报表对应指标单位选择
    //9 整列公式配置  
    public OpenForm()
    {
      InitializeComponent();
    }

    public OpenForm(int flag)
    {
      InitializeComponent();
      BindBBLX();
      initGrid();
      mode = flag;
    }

    private void BindBBLX()
    {
      BLL.ENCO_BBLX bll = new BLL.ENCO_BBLX();
      DataSet ds = bll.GetList("");
      cobBBLX.DisplayMember = "DS.LBMC";
      cobBBLX.ValueMember = "DS.ID";
      cobBBLX.DataSource = ds;
    }

    private void initGrid()
    {
      string bblx = cobBBLX.SelectedValue.ToString();
      BLL.CODE_BBBMB bll = new BLL.CODE_BBBMB();
      //DataTable dt = bll.GetList(" bblx=" + bblx).Tables[0];
      DataTable dt = bll.GetList_BBLX_DW(GetDW(), bblx).Tables[0];
      openTableGrid.AutoGenerateColumns = false;
      openTableGrid.DataSource = dt;
    }
    private string GetDW()
    {
      BLL.DWBMB blldw = new BLL.DWBMB();
      string dw = blldw.GetDW(MainForm.Current.Loginname);
      return dw;
    }

    private void openTableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      openTableGrid.Rows[openTableGrid.CurrentCell.RowIndex].Selected = true;
    }

    private void OpenForm_Shown(object sender, EventArgs e)
    {
      if (openTableGrid.Rows.Count > 0)
      {
        openTableGrid.CurrentRow.Selected = true;
      }
    }

    private void openTableGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      //Common.Control.FormCommon.ShowSingleWindow(typeof(NewForm), MainForm.Current, "");
      string tableNum = openTableGrid.CurrentRow.Cells[1].Value.ToString();
      if (mode == 1) //打开新建报表
      {
        NewForm form = new NewForm(tableNum);
        form.MdiParent = MainForm.Current;
        form.Show();
        this.Hide();
        this.Close();
      }
      else if (mode == 2)  //打开报表公式配置窗口
      {
        //FormulaConfigForm form = new FormulaConfigForm(tableNum);
        FormulaConditionChoice form = new FormulaConditionChoice(tableNum, mode);
        //form.MdiParent = MainForm.Current;
        //form.WindowState = FormWindowState.Maximized;
        form.ShowDialog();
        this.Hide();
        this.Close();
      }
      else if (mode == 9)  //打开整列报表公式配置窗口
      {
        //FormulaConfigForm form = new FormulaConfigForm(tableNum);
        FormulaConditionChoice form = new FormulaConditionChoice(tableNum, mode);
        //form.MdiParent = MainForm.Current;
        //form.WindowState = FormWindowState.Maximized;
        form.ShowDialog();
        this.Hide();
        this.Close();
      }
      else if (mode == 3)//继承新建
      {
        #region
        string inheritTable = tableNum;
        string tableName = "";
        BLL.CODE_BBBMB bll_bbbmb = new BLL.CODE_BBBMB();
        int count = bll_bbbmb.GetMaxBBBM();
        tableName = "CL" + string.Format("{0:D4}", count + 1);
        Model.CODE_BBBMB model_bbbmb = bll_bbbmb.GetModel(inheritTable);
        model_bbbmb.BBBM = tableName;
        model_bbbmb.PXXH = bll_bbbmb.GetMaxXH();
        bll_bbbmb.Add(model_bbbmb);

        BLL.XMLVERSION bll_version = new BLL.XMLVERSION();
        Model.XMLVERSION model_xml = bll_version.GetModel(MainForm.Current.Version, inheritTable);
        model_xml.BBBM = tableName;
        bll_version.Add(model_xml);
        Classes.SaveCell.SaveXML(model_xml, MainForm.Current.Version.ToString());

        BLL.ENCO_BBZD_List bll_bbzdlist = new BLL.ENCO_BBZD_List();
        Model.ENCO_BBZD_List modelList = bll_bbzdlist.query(inheritTable);
        for (int i = 0; i < modelList.BBBM.Length; i++)
        {
          modelList.BBBM[i] = tableName;
        }
        bll_bbzdlist.Add(modelList);

        //BLL.ENCO_ZBBMB_List bll_zbbmb = new BLL.ENCO_ZBBMB_List();
        //Model.ENCO_ZBBMB_List model_zbbmb = bll_zbbmb.query(inheritTable);
        //for (int i = 0; i < model_zbbmb.BBBM.Length; i++)
        //{
        //  model_zbbmb.BBBM[i] = tableName;
        //  model_zbbmb.ZBBM[i] = tableName + model_zbbmb.ZBBM[i].Substring(6, 4);
        //}
        //bll_zbbmb.Add(model_zbbmb);

        NewForm form = new NewForm(tableName, mode.ToString());
        form.MdiParent = MainForm.Current;
        form.Show();
        this.Hide();
        this.Close();
        #endregion
      }
      else if (mode == 5)//报表对应列单位选择
      {
        SystemConfig.DWChoiceForm form = new SystemConfig.DWChoiceForm(tableNum);
        form.MdiParent = MainForm.Current;
        form.WindowState = FormWindowState.Normal;
        form.Show();
        this.Hide();
        this.Close();
      }
      else if (mode == 8)//报表对应指标单位选择
      {
        SystemConfig.DWZBBMChoiceForm form = new SystemConfig.DWZBBMChoiceForm(tableNum);
        form.MdiParent = MainForm.Current;
        form.WindowState = FormWindowState.Normal;
        form.Show();
        this.Hide();
        this.Close();
      }
      else if (mode == 6) //单位指标对应配置
      {
        StatisticsSystem.DWPersonConfig.DW_ZBBBMConfigForm form = new DWPersonConfig.DW_ZBBBMConfigForm(tableNum);
        form.Show();
        form.MdiParent = MainForm.Current;
        //form.WindowState = FormWindowState.Maximized;
        form.Show();
        this.Hide();
        this.Close();
      }
      else if (mode == 7) //单位列配置
      {
        DWPersonConfig.DW_ColConfigForm form = new DWPersonConfig.DW_ColConfigForm(tableNum);
        form.Show();
        form.MdiParent = MainForm.Current;
        //form.WindowState = FormWindowState.Maximized;
        form.Show();
        this.Hide();
        this.Close();
      }
    }

    private void openTableGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      DialogResult result;
      result = MessageBox.Show("确定要删除吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
      if (result == DialogResult.Cancel)
      {
        return;
      }
      string tableNum = openTableGrid.CurrentRow.Cells[1].Value.ToString();
      bool flag = false;
      BLL.CODE_BBBMB bll_bbbmb = new BLL.CODE_BBBMB();
      flag = bll_bbbmb.Delete(tableNum);
      BLL.ENCO_BBZD bll = new BLL.ENCO_BBZD();
      flag = bll.Delete(tableNum);
      BLL.ENCO_ZBBMB bll2 = new BLL.ENCO_ZBBMB();
      flag = bll2.Delete(tableNum);
      BLL.ENCO_SJJDJJBL bll3 = new BLL.ENCO_SJJDJJBL();
      flag = bll3.Delete(tableNum);
      BLL.XMLVERSION bll4 = new BLL.XMLVERSION();
      flag = bll4.Delete(MainForm.Current.Version, tableNum);
      BLL.BBDYTBDW bbdytbdw = new BLL.BBDYTBDW();
      bbdytbdw.delete(tableNum);
      BLL.ENCO_ZBBMB_DW zbbmb_dw = new BLL.ENCO_ZBBMB_DW();
      zbbmb_dw.Deletebbbm(tableNum);
      BLL.ENCO_BBZD_DW bbzd_dw = new BLL.ENCO_BBZD_DW();
      bbzd_dw.Deletebbbm(tableNum);
      Common.DDL.DDLExecute.DropTable(tableNum);
      MessageBox.Show(tableNum);

    }

    private void cobBBLX_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cobBBLX.SelectedIndex >= 0)
        initGrid();
    }
  }
}
