using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// ZN_DOCJSXX
  /// </summary>
  public partial class ZN_DOCJSXX
  {
    private readonly StatisticsSystem.DAL.ZN_DOCJSXX dal = new StatisticsSystem.DAL.ZN_DOCJSXX();
    public ZN_DOCJSXX()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal DOCJSXXID)
    {
      return dal.Exists(DOCJSXXID);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ZN_DOCJSXX model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ZN_DOCJSXX model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(decimal DOCJSXXID)
    {

      return dal.Delete(DOCJSXXID);
    }
    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool DeleteList(string DOCJSXXIDlist)
    {
      return dal.DeleteList(DOCJSXXIDlist);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ZN_DOCJSXX GetModel(decimal DOCJSXXID)
    {

      return dal.GetModel(DOCJSXXID);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.ZN_DOCJSXX GetModelByCache(decimal DOCJSXXID)
    //{

    //  string CacheKey = "ZN_DOCJSXXModel-" + DOCJSXXID;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(DOCJSXXID);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.ZN_DOCJSXX)objModel;
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
    public List<StatisticsSystem.Model.ZN_DOCJSXX> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ZN_DOCJSXX> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.ZN_DOCJSXX> modelList = new List<StatisticsSystem.Model.ZN_DOCJSXX>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.ZN_DOCJSXX model;
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
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetList_DOCBM(string strWhere)
    {
      return dal.GetList_DOCBM(strWhere);
    }

    public int GetMaxID()
    {
      return dal.GetMaxID();
    }
    #endregion  ExtensionMethod
  }
}

