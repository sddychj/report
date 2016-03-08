using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Statistics.Model
{
    public class Owner
    {
        private static DataSet ownerDataSet { get; set; }
        private static DataSet ownerDataSetSingle { get; set; }
        private static readonly object _object = new object();
        public string Name { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// 并非单例：因为不同单位对应的报表不同
        /// </summary>
        /// <param name="bbbm"></param>
        /// <returns></returns>
        public static DataSet GetInstance(string bbbm,string yhdw)
        {
            
            //if (ownerDataSet == null)
            //{
            //    lock (_object)
            //    {
            //        if (ownerDataSet == null)
            //        {
                        ownerDataSet =Maticsoft.DBUtility.DbHelperOra.Query("select y.dwmc,t.dwbm from bbdytbdw t,dwbmb y where t.dwbm=y.dwbm and t.bbbm='"+bbbm.ToUpper()+"' and t.dwbm like '"+yhdw+"%'");
            //        }
            //    }
            //}
            return ownerDataSet;
        }
        public static DataSet GetInstance()
        {
            if (ownerDataSetSingle == null)
            {
                lock (_object)
                {
                    if (ownerDataSetSingle == null)
                    {
                        ownerDataSetSingle = Maticsoft.DBUtility.DbHelperOra.Query("select distinct(t.DWBM),y.dwmc from bbdytbdw t,dwbmb y where t.dwbm=y.dwbm and length(t.dwbm)>=2 order by t.dwbm asc");
                    }
                }
            }
            return ownerDataSetSingle;
        }
    }
}
