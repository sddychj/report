using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
namespace Statistics.UI
{
    public class DDL
    {
        public static void BindDDL_Owner(System.Web.UI.WebControls.DropDownList ddl_Owner, string tableName, string userDept)
        {
            ddl_Owner.DataSource = Statistics.Model.Owner.GetInstance(tableName,userDept);
            ddl_Owner.DataTextField = "DWMC";
            ddl_Owner.DataValueField = "DWBM";
            ddl_Owner.DataBind();
        }
        public static void BindDDL_Owner(System.Web.UI.WebControls.DropDownList ddl_Owner, string userDept)
        {
            System.Data.DataSet ds = Statistics.Model.Owner.GetInstance();
            System.Data.DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "dwbm like '" + userDept + "%'";
            ddl_Owner.DataSource = dv;
            ddl_Owner.DataTextField = "DWMC";
            ddl_Owner.DataValueField = "DWBM";
            ddl_Owner.DataBind();
        }
        public static void BindDDL_YearAndMonth(DropDownList ddl_Year,DropDownList ddl_Month, string tableName)
        {
            int thisyear = DateTime.Now.Year;
            int preyear = 2006;
           
            string sql = "select t.bbzq from bbbmb t where t.bbbm='"+tableName.ToUpper()+"'";
            object o = Maticsoft.DBUtility.DbHelperOra.GetSingle(sql);
            int thismonth = DateTime.Now.Month;
            if (o != null)
            {
                switch (o.ToString())
                {
                    case "月度":
                        for (int year = preyear; year <= thisyear + 10; year++)
                        {
                            ddl_Year.Items.Add(year.ToString());
                        }
                        for (int month = 1; month <= 12; month++)
                        {
                            ddl_Month.Items.Add(month.ToString());
                        }
                        break;
                    case "年度":
                        for (int year = preyear; year <= thisyear + 10; year++)
                        {
                            ddl_Year.Items.Add(year.ToString());
                        }
                        ddl_Month.Items.Add(new ListItem("12","12"));
                        break;
                    case "半年报":
                        for (int year = preyear; year <= thisyear + 10; year++)
                        {
                            ddl_Year.Items.Add(year.ToString());
                        }
                        ddl_Month.Items.Add(new ListItem("6", "6"));
                        ddl_Month.Items.Add(new ListItem("12", "12"));
                        break;
                    case "季度":
                        for (int year = preyear; year <= thisyear + 10; year++)
                        {
                            ddl_Year.Items.Add(year.ToString());
                        }
                        ddl_Month.Items.Add(new ListItem("一季度", "3"));
                        ddl_Month.Items.Add(new ListItem("二季度", "6"));
                        ddl_Month.Items.Add(new ListItem("三季度", "9"));
                        ddl_Month.Items.Add(new ListItem("四季度", "12"));
                        break;
                    case "旬度":
                        //备注 ： 上旬.1 中旬.2 下旬.3
                        for (int year = preyear; year <= thisyear + 10; year++)
                        {
                            ddl_Year.Items.Add(year.ToString());
                        }
                        for (int month = 1; month <= 12; month++)
                        {                            
                            ddl_Month.Items.Add(new ListItem(month+"月-上旬",(month+0.10).ToString()));
                            ddl_Month.Items.Add(new ListItem(month + "月-中旬", (month + 0.20).ToString()));
                            ddl_Month.Items.Add(new ListItem(month + "月-下旬", (month + 0.30).ToString()));                  
     
                        }
                        
                        break;
                    case "汇编":
                        ddl_Year.Items.Add(new ListItem("2011", "2011"));
                        ddl_Year.Items.Add(new ListItem("2016", "2016"));
                        ddl_Year.Items.Add(new ListItem("2021", "2021"));
                        ddl_Year.Items.Add(new ListItem("2026", "2026"));
                        ddl_Year.Items.Add(new ListItem("2031", "2031"));
                        ddl_Month.Items.Add(new ListItem("12", "12"));
                        break;
                    default:                        
                        break;
                }
            }
            ddl_Year.SelectedValue = thisyear.ToString();
            ddl_Month.SelectedValue = (thismonth-1).ToString();
        }
        public static void BindDDL_Tijiaoren(DropDownList ddl_username, string loginid)
        {
            string sql = "select UserXM from tjryb where ploginid='" + loginid + "'";
            ddl_username.DataSource =  Maticsoft.DBUtility.DbHelperOra.Query(sql);
            ddl_username.DataTextField = "userxm";
            ddl_username.DataValueField = "userxm";
            ddl_username.DataBind();
        }
        public static void BindDDL_YearAndMonth(DropDownList ddl_Year, DropDownList ddl_Month)
        {
            int thisyear = DateTime.Now.Year;
            int thismonth = DateTime.Now.Month;
            int preyear = 2010;
            for (int year = preyear; year <= thisyear + 10; year++)
            {
                ddl_Year.Items.Add(year.ToString());
            }
            for (int i = 1; i <=12; i++)
            {
                ddl_Month.Items.Add(i.ToString());
            }
            ddl_Year.SelectedValue = thisyear.ToString();
            ddl_Month.SelectedValue = (thismonth-1).ToString();
        }
        /// <summary>
        /// 按表和单位绑定菜单
        /// </summary>
        /// <param name="ddl_Owner"></param>
        /// <param name="ddl_Year"></param>
        /// <param name="ddl_Month"></param>
        /// <param name="tableName"></param>
        /// <param name="loginName"></param>
        public static void BindDDL(DropDownList ddl_Owner,DropDownList ddl_Year,DropDownList ddl_Month,string tableName,string userDept)
        {
            BindDDL_Owner(ddl_Owner,tableName,userDept);
            BindDDL_YearAndMonth(ddl_Year,ddl_Month,tableName);
        }
        /// <summary>
        /// 绑定单位，所有年份,所有月份 不带分公司
        /// </summary>
        /// <param name="ddl_Owner"></param>
        /// <param name="ddl_Year"></param>
        /// <param name="ddl_Month"></param>
        /// <param name="loginName"></param>
        public static void BindDDL(DropDownList ddl_Owner, DropDownList ddl_Year, DropDownList ddl_Month,string userDept,bool hasRoot)
        {
            BindDDL_Owner(ddl_Owner, userDept);
            if (!hasRoot)
            {
                ddl_Owner.Items.RemoveAt(0);
            }
            BindDDL_YearAndMonth(ddl_Year, ddl_Month);
        }
    }
}
