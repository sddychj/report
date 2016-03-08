using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Xiaovcn.DB;

namespace XBExport.App_Code
{
    public class EXCELEXPORT
    {
        public EXCELEXPORT()
        { }

        #region Model
        private string _dwbm;
        private decimal _nf;
        private decimal _yf;
        private decimal? _status;
        private string _finishtime;
        private string _bbbmlist;
        /// <summary>
        /// 单位编码
        /// </summary>
        public string DWBM
        {
            set { _dwbm = value; }
            get { return _dwbm; }
        }
        /// <summary>
        /// 年份
        /// </summary>
        public decimal NF
        {
            set { _nf = value; }
            get { return _nf; }
        }
        /// <summary>
        /// 月份
        /// </summary>
        public decimal YF
        {
            set { _yf = value; }
            get { return _yf; }
        }
        /// <summary>
        /// 当前状态(0=未处理,1=已处理)
        /// </summary>
        public decimal? STATUS
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 完成时间
        /// </summary>
        public string FINISHTIME
        {
            set { _finishtime = value; }
            get { return _finishtime; }
        }
        /// <summary>
        /// 报表编码列表
        /// </summary>
        public string BBBMLIST
        {
            set { _bbbmlist = value; }
            get { return _bbbmlist; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(EXCELEXPORT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EXCELEXPORT set ");
            if (model.STATUS != null)
            {
                strSql.Append("STATUS=" + model.STATUS + ",");
            }
            else
            {
                strSql.Append("STATUS= null ,");
            }
            if (model.FINISHTIME != null)
            {
                strSql.Append("FINISHTIME='" + model.FINISHTIME + "',");
            }
            else
            {
                strSql.Append("FINISHTIME= null ,");
            }
            if (model.BBBMLIST != null)
            {
                strSql.Append("BBBMLIST='" + model.BBBMLIST + "',");
            }
            else
            {
                strSql.Append("BBBMLIST= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where DWBM='" + model.DWBM + "' and NF=" + model.NF + " and YF=" + model.YF + " ");
            bool rowsAffected = PPADBHelper.ExecuteNonQuery(strSql.ToString());
           
            return rowsAffected;
            
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static EXCELEXPORT GetModel(string DWBM, decimal NF, decimal YF)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            strSql.Append(" DWBM,NF,YF,STATUS,FINISHTIME,BBBMLIST ");
            strSql.Append(" from EXCELEXPORT ");
            strSql.Append(" where DWBM='" + DWBM + "' and NF=" + NF + " and YF=" + YF + " ");
            EXCELEXPORT model = new EXCELEXPORT();
            DataSet ds = PPADBHelper.ExecuteDataSet(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["DWBM"] != null && ds.Tables[0].Rows[0]["DWBM"].ToString() != "")
                {
                    model.DWBM = ds.Tables[0].Rows[0]["DWBM"].ToString();
                }
                if (ds.Tables[0].Rows[0]["NF"] != null && ds.Tables[0].Rows[0]["NF"].ToString() != "")
                {
                    model.NF = decimal.Parse(ds.Tables[0].Rows[0]["NF"].ToString());
                }
                if (ds.Tables[0].Rows[0]["YF"] != null && ds.Tables[0].Rows[0]["YF"].ToString() != "")
                {
                    model.YF = decimal.Parse(ds.Tables[0].Rows[0]["YF"].ToString());
                }
                if (ds.Tables[0].Rows[0]["STATUS"] != null && ds.Tables[0].Rows[0]["STATUS"].ToString() != "")
                {
                    model.STATUS = decimal.Parse(ds.Tables[0].Rows[0]["STATUS"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FINISHTIME"] != null && ds.Tables[0].Rows[0]["FINISHTIME"].ToString() != "")
                {
                    model.FINISHTIME = ds.Tables[0].Rows[0]["FINISHTIME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BBBMLIST"] != null && ds.Tables[0].Rows[0]["BBBMLIST"].ToString() != "")
                {
                    model.BBBMLIST = ds.Tables[0].Rows[0]["BBBMLIST"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        #endregion  Method
    }
}
