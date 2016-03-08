using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// ENCO_ZBBMB
  /// </summary>
  public partial class ENCO_ZBBMB
  {
    private readonly StatisticsSystem.DAL.ENCO_ZBBMB dal = new StatisticsSystem.DAL.ENCO_ZBBMB();
    public ENCO_ZBBMB()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string ZBBM)
    {
      return dal.Exists(BBBM, ZBBM);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_ZBBMB model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ENCO_ZBBMB model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string BBBM, string ZBBM)
    {

      return dal.Delete(BBBM, ZBBM);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_ZBBMB GetModel(string BBBM, string ZBBM)
    {

      return dal.GetModel(BBBM, ZBBM);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.ENCO_ZBBMB GetModelByCache(string BBBM, string ZBBM)
    //{

    //string CacheKey = "ENCO_ZBBMBModel-" + BBBM + ZBBM;
    //object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //if (objModel == null)
    //{
    //  try
    //  {
    //    objModel = dal.GetModel(BBBM, ZBBM);
    //    if (objModel != null)
    //    {
    //      int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //      Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //    }
    //  }
    //  catch { }
    //}
    //  return (StatisticsSystem.Model.ENCO_ZBBMB)objModel;
    //}

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetList(string strWhere)
    {
      return dal.GetList(strWhere);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ENCO_ZBBMB> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      foreach (DataRow dr in ds.Tables[0].Rows)
      {
        dr["ZBMC"] = GetZBMC(dr["ZBMC"].ToString(), dr["cj"].ToString());
      }
      return DataTableToList(ds.Tables[0]);
    }
    private string GetZBMC(string zbmc, string cj)
    {
      int cjI = int.Parse(cj);
      for (int cjInd = 1; cjInd < cjI; cjInd++)
      {
        zbmc = "  " + zbmc;
      }
      return zbmc;
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ENCO_ZBBMB> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.ENCO_ZBBMB> modelList = new List<StatisticsSystem.Model.ENCO_ZBBMB>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.ENCO_ZBBMB model;
        for (int n = 0; n < rowsCount; n++)
        {
          model = dal.DataRowToModel(dt.Rows[n]);
          if (model != null)
          {
            modelList.Add(model);
          }
        }
      }
      return modelList;
    }

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetAllList()
    {
      return GetList("");
    }

    /// <summary>
    /// 分页获取数据列表
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      return dal.GetRecordCount(strWhere);
    }
    /// <summary>
    /// 分页获取数据列表
    /// </summary>
    public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
    {
      return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
    }
    /// <summary>
    /// 分页获取数据列表
    /// </summary>
    //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
    //{
    //return dal.GetList(PageSize,PageIndex,strWhere);
    //}

    #endregion  BasicMethod
    #region  ExtensionMethod
    public bool Delete(string BBBM)
    {

      return dal.Delete(BBBM);
    }

    public void GetZBBMB_YYBB(string BBBM, Dictionary<string, Model.ENCO_ZBBMB> zbbmb, Dictionary<string, Model.ENCO_ZBBMB> zbbmb_hc)
    {
      dal.GetZBBMB_YYBB_HC(BBBM, zbbmb, zbbmb_hc);
    }

    public Dictionary<int, string> GetZBBMB_hc(string BBBM)
    {
      return dal.GetZBBMB_hc(BBBM);
    }

    public Dictionary<string, string> GetZBBMB_jy(string BBBM)
    {
      return dal.GetZBBMB_jy(BBBM);
    }

    #endregion  ExtensionMethod
  }
}

