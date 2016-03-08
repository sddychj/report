using System;
using System.Data;
using System.Collections.Generic;
using StatisticsSystem.Model;

namespace StatisticsSystem.BLL
{
  /// <summary>
  /// ENCO_BBZD
  /// </summary>
  public partial class ENCO_BBZD
  {
    private readonly StatisticsSystem.DAL.ENCO_BBZD dal = new StatisticsSystem.DAL.ENCO_BBZD();
    public ENCO_BBZD()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string ZD)
    {
      return dal.Exists(BBBM, ZD);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_BBZD model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ENCO_BBZD model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string BBBM, string ZD)
    {

      return dal.Delete(BBBM, ZD);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_BBZD GetModel(string BBBM, string ZD)
    {

      return dal.GetModel(BBBM, ZD);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.ENCO_BBZD GetModelByCache(string BBBM, string ZD)
    //{

    //  string CacheKey = "ENCO_BBZDModel-" + BBBM + ZD;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(BBBM, ZD);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.ENCO_BBZD)objModel;
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
    public List<StatisticsSystem.Model.ENCO_BBZD> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ENCO_BBZD> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.ENCO_BBZD> modelList = new List<StatisticsSystem.Model.ENCO_BBZD>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.ENCO_BBZD model;
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

    public DataSet GetList_BBBM(string BBBM)
    {
      return dal.GetList_BBBM(BBBM);
    }
    public List<StatisticsSystem.Model.ENCO_BBZD> GetModelList_BBBM(string BBBM)
    {
      DataSet ds = dal.GetList_BBBM(BBBM);
      return DataTableToList(ds.Tables[0]);
    }

    public string[] GetColumnName(string BBBM)
    {
      DataSet ds = GetList_BBBM(BBBM);
      string[] list = new string[ds.Tables[0].Rows.Count];
      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        list[i] = ds.Tables[0].Rows[i]["zd"].ToString();
      }
      return list;
    }

    public void GetZBBMB_YYBB(string BBBM, Dictionary<string, Model.ENCO_BBZD> zbbmb, Dictionary<string, Model.ENCO_BBZD> zbbmb_hc)
    {
      dal.GetZBBMB_YYBB_HC(BBBM, zbbmb, zbbmb_hc);
    }

    public Dictionary<int, string> GetDic(string bbbm)
    {
      return dal.GetDic(bbbm);
    }
    public Dictionary<string, int> GetDic_zdsx(string bbbm)
    {
      return dal.GetDic_zdsx(bbbm);
    }
    #endregion  ExtensionMethod
  }
}

