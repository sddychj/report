using System;
using System.Data;
using System.Collections.Generic;
using StatisticsSystem.Model;

namespace StatisticsSystem.BLL
{
  /// <summary>
  /// ENCO_SJJDJJBL
  /// </summary>
  public partial class ENCO_SJJDJJBL
  {
    private readonly StatisticsSystem.DAL.ENCO_SJJDJJBL dal = new StatisticsSystem.DAL.ENCO_SJJDJJBL();
    public ENCO_SJJDJJBL()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string ZBBM, string ZD)
    {
      return dal.Exists(BBBM, ZBBM, ZD);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_SJJDJJBL model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ENCO_SJJDJJBL model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string BBBM, string ZBBM, string ZD)
    {

      return dal.Delete(BBBM, ZBBM, ZD);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_SJJDJJBL GetModel(string BBBM, string ZBBM, string ZD)
    {

      return dal.GetModel(BBBM, ZBBM, ZD);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.ENCO_SJJDJJBL GetModelByCache(string BBBM, string ZBBM, string ZD)
    //{

    //  string CacheKey = "ENCO_SJJDJJBLModel-" + BBBM + ZBBM + ZD;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(BBBM, ZBBM, ZD);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.ENCO_SJJDJJBL)objModel;
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
    public List<StatisticsSystem.Model.ENCO_SJJDJJBL> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ENCO_SJJDJJBL> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.ENCO_SJJDJJBL> modelList = new List<StatisticsSystem.Model.ENCO_SJJDJJBL>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.ENCO_SJJDJJBL model;
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
    public Dictionary<string, Model.ENCO_SJJDJJBL> GetHashList_BBBM(string BBBM)
    {
      //DataSet ds = dal.GetList_BBBM(BBBM);
      return dal.GetHashList_BBBM(BBBM);
    }

    #endregion  ExtensionMethod
  }
}

