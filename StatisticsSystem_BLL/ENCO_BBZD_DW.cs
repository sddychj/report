using System;
using System.Data;
using System.Collections.Generic;
using StatisticsSystem.Model;

namespace StatisticsSystem.BLL
{
  /// <summary>
  /// ENCO_BBZD_DW
  /// </summary>
  public partial class ENCO_BBZD_DW
  {
    private readonly StatisticsSystem.DAL.ENCO_BBZD_DW dal = new StatisticsSystem.DAL.ENCO_BBZD_DW();
    public ENCO_BBZD_DW()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string ZD, string DWBM, string BBBM)
    {
      return dal.Exists(ZD, DWBM, BBBM);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_BBZD_DW model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ENCO_BBZD_DW model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string ZD, string DWBM, string BBBM)
    {

      return dal.Delete(ZD, DWBM, BBBM);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_BBZD_DW GetModel(string ZD, string DWBM, string BBBM)
    {

      return dal.GetModel(ZD, DWBM, BBBM);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.ENCO_BBZD_DW GetModelByCache(string ZD, string DWBM, string BBBM)
    //{

    //  string CacheKey = "ENCO_BBZD_DWModel-" + ZD + DWBM + BBBM;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(ZD, DWBM, BBBM);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.ENCO_BBZD_DW)objModel;
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
    public List<StatisticsSystem.Model.ENCO_BBZD_DW> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ENCO_BBZD_DW> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.ENCO_BBZD_DW> modelList = new List<StatisticsSystem.Model.ENCO_BBZD_DW>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.ENCO_BBZD_DW model;
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
    //public int GetRecordCount(string strWhere)
    //{
    //  return dal.GetRecordCount(strWhere);
    //}
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

    public bool Deletebbbm(string bbbm)
    {

      return dal.Deletebbbm(bbbm);
    }
    #endregion  ExtensionMethod
  }
}
