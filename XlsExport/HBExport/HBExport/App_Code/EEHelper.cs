using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Diagnostics;




namespace XBExport.App_Code
{
    public class EEHelper
    {
       
        /// <summary>
        /// 将所有表导入到一个EXCEL文件中
        /// </summary>
        /// <param name="_xmlFilePath">表的配置文件路径</param>
        /// <param name="_sArray">表名列表</param>
        /// <param name="_nf">年份</param>
        /// <param name="_yf">月份</param>
        /// <param name="_owner">单位编码</param>
        /// <param name="_exportPath">导出路径</param>     
        public static void DataTableToExcel(string _xmlFilePath, string[] _sArray,string _nf,string _yf ,string _owner,string _exportPath)
        {
            Object oMissing = System.Reflection.Missing.Value;//实例化对象时缺省参数

            string templetFilePath;  //EXCEL模板路径
            string outputFilePath;   //EXCEL输出路径
            //outputFilePath = System.Windows.Forms.Application.StartupPath + @"\ExcelFile\报表" + "_" + _nf + "_" + _yf + ".xls";
            //根据单位编码，取出单位名称
            string dwmc="";
            string sql_dw = "select dwmc from dwbmb where dwbm = '" + _owner + "' ";
            object o_dw = Xiaovcn.DB.PPADBHelper.ExecuteScalar(sql_dw);
            if (o_dw != null)
            {
                dwmc = o_dw.ToString();
            }
            //导出的路径（每个单位独立的文件夹）
            _exportPath = _exportPath + "\\" + dwmc;
            //生成文件夹
            SSEC.Tools.FileControl.CreateFolder(_exportPath);
            //拼出EXCEL的输出路径
            outputFilePath = _exportPath + "\\" + dwmc + "_" + _nf + "_" + _yf + ".xls";

            //进程的启动时间段
            DateTime beforeTime;
            DateTime afterTime;
            beforeTime = DateTime.Now;
            
            //创建一个Excel
            Excel.Application app = new Excel.Application();
            app.Visible = false;
            afterTime = DateTime.Now;

            Excel.Workbooks workbooks = app.Workbooks;
            //单个模板
            Excel._Workbook workbook_template;
            Excel.Sheets sheets_template;

            //打开总模板
            Excel._Workbook workbook = workbooks.Add(System.Windows.Forms.Application.StartupPath + @"\ExcelTemplate\theone.xls");
            Excel.Sheets sheets = workbook.Worksheets;

            int i = 1;
            //循环所有的表名列表
            foreach (string tablename in _sArray)
            {
                i++;
                //workbook.Worksheets.Add(oMissing, oMissing, oMissing, oMissing);

                //模板路径
                templetFilePath = System.Windows.Forms.Application.StartupPath + @"\ExcelTemplate\" + tablename + ".xls";

                //读取XML配置文件
                XmlDocument docXml = new XmlDocument();
                docXml.Load(_xmlFilePath);
                XmlElement root = docXml.DocumentElement;
                XmlNodeList xn = root.GetElementsByTagName(tablename);
                //节点存在且模板存在
                if (xn.Count > 0 && File.Exists(templetFilePath))
                {
                    workbook_template = workbooks.Add(templetFilePath);//这里的Add方法里的参数就是模板的路径
                    sheets_template = workbook_template.Worksheets;
                    Excel.Worksheet worksheet_template = (Excel.Worksheet)sheets_template.get_Item(1);//获得模板中的sheet表

                    if (worksheet_template != null)
                    {
                        //获取配置：未来有扩展在此增加                        
                        string StartCell = xn.Item(0).ChildNodes.Item(0).InnerXml;
                        string DateCell = xn.Item(0).ChildNodes.Item(1).InnerXml;
                        string EndCell = xn.Item(0).ChildNodes.Item(2).InnerXml;
                        string BottomInfo = xn.Item(0).ChildNodes.Item(3).InnerXml;
                        string hiddencolumn = xn.Item(0).ChildNodes.Item(4).InnerXml;
                        string hiddenrow = xn.Item(0).ChildNodes.Item(5).InnerXml;
                        //不同的表查询语句不一样
                        string sql_query;
                        if (tablename.Contains("NH"))
                        {
                            switch (tablename)
                            {
                                case "NH61":
                                    sql_query = "select * from " + tablename + "  where NF={0}  and YF={1}  and DWBM = '{2}'  order by zbbm ";
                                    break;
                                case "NH68":
                                    sql_query = @"select 1,'机械采油' nyzl,a.*,b.*,null zbbm,null zbmc,null jldw,null bgq,null sntq from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='原油生产电力消耗' and a.nyzl='机械采油') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='油井开井数' and a.nyzl='机械采油') b
                                union all
                                select 2,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,a.*,b.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='原油产量' and a.nyzl='机械采油') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位原油生产电耗' and a.nyzl='机械采油') b
                                union all
                                select 3,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,a.*,b.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='产液量' and a.nyzl='机械采油') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位液量生产电耗' and a.nyzl='机械采油') b

                                union all
                                select 4,'注水' nyzl,a.*,b.*,null zbbm,null zbmc,null jldw,null bgq,null sntq from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='注水电力消耗' and a.nyzl='注水') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='水井开井数' and a.nyzl='注水') b
                                union all
                                select 5,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,a.*,b.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='注水量' and a.nyzl='注水') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位注水量电耗' and a.nyzl='注水') b

                                union
                                select 6,'注汽' nyzl,a.*,b.*,null zbbm,null zbmc,null jldw,null bgq,null sntq from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='注汽综合能耗折标煤' and a.nyzl='注汽') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='稠油井开井数' and a.nyzl='注汽') b
                                union all
                                select 7,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,a.*,null zbbm,null zbmc,null jldw,null bgq,null sntq from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='稠油产量' and a.nyzl='注汽') a
                                union all
                                select 8,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,a.*,b.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='注蒸汽量' and a.nyzl='注汽') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位注汽量综合能耗' and a.nyzl='注汽') b

                                union all
                                select 9,'集输' nyzl,a.*,b.*,c.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='油气产量' and a.nyzl='集输') b,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位油气集输综合能耗' and a.nyzl='集输') c,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='油气集输综合能耗折标煤' and a.nyzl='集输') a

                                union all
                                select 10,'气层天然气生产' nyzl,a.*,b.*,null zbbm,null zbmc,null jldw,null bgq,null sntq from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='气层天然气生产综合能耗折标煤' and a.nyzl='气层天然气生产') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='气层天然气井开井数' and a.nyzl='气层天然气生产') b
                                union all
                                select 11,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,a.*,b.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='气层天然气产量' and a.nyzl='气层天然气生产') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位气层天然气生产综合能耗' and a.nyzl='气层天然气生产') b

                                union all
                                select 12,'综合' nyzl,a.*,b.*,c.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='企业综合电力消耗' and a.nyzl='综合') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='油气产量' and a.zbbm='NH6826' and a.nyzl='综合') b,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位油气综合电耗' and a.nyzl='综合') c
                                union all
                                select 13,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,null zbbm,null zbmc,null jldw,null bgq,null sntq,b.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位油气综合能耗' and a.nyzl='综合') b

                                union all
                                select 14,null,a.*,b.*,c.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='企业综合能耗折标煤' and a.nyzl='综合') a,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='工业总产值' and a.nyzl='综合') b,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='万元产值综合能耗' and a.nyzl='综合') c
                                union all
                                select 15,null,null zbbm,null zbmc,null jldw,null bgq,null sntq,null zbbm,null zbmc,null jldw,null bgq,null sntq,b.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='节能量' and a.nyzl='综合') b

                                union all
                                select 16,null,a.*,b.*,c.* from
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='生产量' and a.zbmc='油气产量' and a.zbbm='NH6828' and a.nyzl='综合') b,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='单位能耗' and a.zbmc='单位油气生产综合能耗' and a.nyzl='综合') c,
                                  (select a.zbbm,a.zbmc,a.jldw,a.bgq,a.sntq from nh68 a,bm_zbbmb b
                                      where a.zbbm=b.zbbm and a.dwbm='{2}' and a.nf={0} and a.yf={1} and b.zd3='能源消耗量' and a.zbmc='油气生产综合能耗折标煤' and a.nyzl='综合') a ";
                                    break;
                                case "NH70":
                                    if (_owner == "HB")
                                    {
                                        sql_query = "select rownum,zbmc,jldw,hj from " + tablename + "  where NF={0}  and YF={1}  order by zbbm ";
                                    }
                                    else
                                    {
                                        if (_owner == "HB01" || _owner == "HB02" || _owner == "HB03" || _owner == "HB04" || _owner == "HB05" || _owner == "HB10" || _owner == "HB14")
                                        {
                                            sql_query = "select rownum,zbmc,jldw,dw" + Convert.ToInt32(_owner.Substring(2, 2)).ToString() + " from " + tablename + "  where NF={0}  and YF={1}  order by zbbm ";
                                        }
                                        else
                                        {
                                            string dw_col;
                                            switch (_owner)
                                            {
                                                case "HB06":
                                                    dw_col = "DW12";
                                                    break;
                                                case "HB07":
                                                    dw_col = "DW13";
                                                    break;
                                                case "HB08":
                                                    dw_col = "DW9";
                                                    break;
                                                case "HB09":
                                                    dw_col = "DW6";
                                                    break;
                                                case "HB11":
                                                    dw_col = "DW7";
                                                    break;
                                                case "HB12":
                                                    dw_col = "DW8";
                                                    break;
                                                case "HB13":
                                                    dw_col = "DW11";
                                                    break;
                                                case "HB16":
                                                    dw_col = "DW15";
                                                    break;
                                                case "HB17":
                                                    dw_col = "DW16";
                                                    break;                                               
                                                default:
                                                    dw_col = "DW6";
                                                    break;
                                            }
                                            sql_query = "select rownum,zbmc,jldw," + dw_col + "  from " + tablename + "  where NF={0}  and YF={1}  order by zbbm ";
                                        }
                                    }
                                    break;
                                default:
                                    sql_query = "select * from " + tablename + "  where NF={0}  and YF={1}  and DWBM like '{2}'||'%'  order by zbbm ";
                                    break;
                            }
                        }
                        else
                        {
//                            if (tablename == "SC37")
//                            {
//                                sql_query = @" select a.nf,a.yf,a.zbbm,a.dwbm,b.bz3,b.bz2,a.zbmc,a.zpfs,a.lbbm,a.rowid 
//                                            from SC37 a ,ZBBMB b 
//                                            where b.bbbm='SC37' and a.zbbm=b.zbbm 
//                                            and a.dwbm='{2}' and a.nf={0} and a.yf={1} ";
//                            }
//                            else
//                            {
                                //sql_query = "select a.* from " + tablename + "  a,zbbmb b where a.zbbm = b.zbbm and a.NF={0}  and a.YF={1}  and a.DWBM='{2}'  order by b.hc ";
                                sql_query = "select decode(a.cj,null,'',0,'',1,'  ',2,'    ',3,'      ',4,'        ',5,'          ',6,'            ',7,'              ') || a.zbmc as zbmc_modi,a.*  from " + tablename + "  a where a.NF={0}  and a.YF={1}  and a.DWBM='{2}'  order by a.hc ";
                            //}
                        }

                        //获取要填充的数据：
                        DataSet ds = new DataSet();
                        string sql = String.Format(sql_query, _nf, _yf, _owner);
                        ds = Xiaovcn.DB.PPADBHelper.ExecuteDataSet(sql);
                        DataTable dt = ds.Tables[0];

                        if ((tablename.Contains("SC") || tablename.Contains("TG")) && (tablename != "SC37"))
                        {
                            dt.Columns.Remove(dt.Columns[5].ColumnName);
                            dt.Columns[0].SetOrdinal(4);
                        }
                        dt.AcceptChanges();
                        
                        //根据excel的Address生成起始行列
                        int startcolumn = worksheet_template.Cells.get_Range(StartCell, Type.Missing).Column;
                        int startrow = worksheet_template.Cells.get_Range(StartCell, Type.Missing).Row;
                                                
                        //不隐藏行
                        //for (int delrow = dt.Rows.Count - 1; delrow >= 0; delrow--)
                        //{
                        //    if (hiddenrow.Contains(delrow.ToString()))
                        //    {
                        //        dt.Rows.RemoveAt(delrow);
                        //    }
                        //}

                        //隐藏列
                        string[] scolArray = hiddencolumn.ToString().Split(',');                        
                        for (int delcol = dt.Columns.Count - 1; delcol >= 0; delcol--)
                        {
                            foreach (string col in scolArray)
                            {
                                if (col == delcol.ToString())
                                {
                                    dt.Columns.Remove(dt.Columns[delcol].ColumnName);                                    
                                }
                            }                           
                        }
                        
                        dt.AcceptChanges();

                        //写入Excel
                        if (dt.Rows.Count > 0)
                        {
                            for (int t = 0; t < dt.Rows.Count; t++)
                            {
                                for (int k = startcolumn; k <= dt.Columns.Count; k++)
                                {

                                    worksheet_template.Cells[startrow + t, k] = dt.Rows[t][k - 1].ToString();
                                    //字体边框对齐等样式
                                    Excel.Range range = worksheet_template.Range[worksheet_template.Cells[startrow + t, k], worksheet_template.Cells[startrow + t, k]];

                                    if (k == 1 || k == dt.Columns.Count)
                                    {
                                        range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                                        range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    else
                                    {
                                        range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                    }

                                    if (dt.Columns[k-1].ColumnName.Contains("ZBMC") || dt.Columns[k-1].ColumnName.Contains("JLDW"))
                                    {
                                        range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                                    }
                                    else
                                    {
                                        range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                                    }
                                    range.Font.Name = "宋体";
                                    range.Font.Size = 9;
                                    //worksheet_template.Cells.get_Range(worksheet_template.Cells[startrow + t, k],Type.Missing).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                    //worksheet_template.Cells.get_Range(worksheet_template.Cells[startrow + t, k], Type.Missing).Font.Size = 8;
                                    //worksheet_template.Cells.get_Range(worksheet_template.Cells[startrow + t, k], Type.Missing).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                    
                                }
                            }
                        }

                        
                       
                        //Excel.Range range = worksheet_template.Range[worksheet_template.Cells[startrow, startcolumn], worksheet_template.Cells[startrow + dt.Rows.Count, startcolumn + dt.Columns.Count - 1]];
                        //range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; 

                        //找到最后一行
                        int endrow = startrow + ds.Tables[0].Rows.Count + 1;
                        int endcolumn = startcolumn + ds.Tables[0].Columns.Count - 1;
                        //合并该行
                        object a = worksheet_template.Cells[endrow, startcolumn];
                        object b = worksheet_template.Cells[endrow, endcolumn];  
                      
                        Excel.Range range_bottom = worksheet_template.Range[a,b];                        
                        worksheet_template.get_Range(a, b).Merge(Missing.Value);
                        //写入底部数据
                        worksheet_template.Cells[endrow, startcolumn] = BottomInfo;
                        range_bottom.Font.Name = "宋体";
                        range_bottom.Font.Size = 10;
                        //写入年月
                        worksheet_template.Cells.get_Range(DateCell, Type.Missing).Value = _nf + "年" + _yf + "月";

                        //}
                        //catch
                        //{ 

                        //}
                    }
                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);//获得模板中的sheet表
                    worksheet_template.Copy(oMissing, worksheet);
                    worksheet_template = null;
                    workbook_template.Close(false, Type.Missing, Type.Missing);
                    workbook_template = null;
                }

            }



            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }


            //try
            //{
            workbook.SaveAs(outputFilePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(false, Type.Missing, Type.Missing);

            app.Workbooks.Close();
            app.Application.Quit();
            app.Quit();

            //System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);

            //worksheet = null;
            workbook = null;
            app = null;

            GC.Collect();
            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    Process[] myProcesses;
            //    DateTime startTime;
            //    myProcesses = Process.GetProcessesByName("EXCEL");

            //    //得不到Excel进程ID，暂时只能判断进程启动时间
            //    foreach (Process myProcess in myProcesses)
            //    {
            //        startTime = myProcess.StartTime;

            //        if (startTime > beforeTime && startTime < afterTime)
            //        {
            //            myProcess.Kill();
            //        }
            //    }
            //}

        }

        public static void Quit()
        {            
            GC.Collect();
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                if (p.ProcessName.ToUpper() == "EXCEL")
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }

        

    }
}
