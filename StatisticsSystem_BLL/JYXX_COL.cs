using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// JYXX_COL
  /// </summary>
  public partial class JYXX_COL
  {
    private readonly StatisticsSystem.DAL.JYXX_COL dal = new StatisticsSystem.DAL.JYXX_COL();
    public JYXX_COL()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal JYXXID)
    {
      return dal.Exists(JYXXID);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.JYXX_COL model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.JYXX_COL model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(decimal JYXXID)
    {

      return dal.Delete(JYXXID);
    }
    /// <summary>
    /// 删除一条数据
    /// </summary>
    //public bool DeleteList(string JYXXIDlist)
    //{
    //  return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(JYXXIDlist, 0));
    //}

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.JYXX_COL GetModel(decimal JYXXID)
    {

      return dal.GetModel(JYXXID);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.JYXX_COL GetModelByCache(decimal JYXXID)
    //{

    //  string CacheKey = "JYXX_COLModel-" + JYXXID;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(JYXXID);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.JYXX_COL)objModel;
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
    public List<StatisticsSystem.Model.JYXX_COL> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.JYXX_COL> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.JYXX_COL> modelList = new List<StatisticsSystem.Model.JYXX_COL>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.JYXX_COL model;
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
    public DataSet GetList_DW(string strWhere)
    {
      return dal.GetList_DW(strWhere);
    }
    public int GetMaxID()
    {
      return dal.GetMaxID();
    }

    #endregion  ExtensionMethod
  }
}

