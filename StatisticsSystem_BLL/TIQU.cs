using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// TIQU
  /// </summary>
  public partial class TIQU
  {
    private readonly StatisticsSystem.DAL.TIQU dal = new StatisticsSystem.DAL.TIQU();
    public TIQU()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string SOURSETABLE, string TARGETTABLE)
    {
      return dal.Exists(SOURSETABLE, TARGETTABLE);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.TIQU model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.TIQU model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string SOURSETABLE, string TARGETTABLE)
    {

      return dal.Delete(SOURSETABLE, TARGETTABLE);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.TIQU GetModel(string SOURSETABLE, string TARGETTABLE)
    {

      return dal.GetModel(SOURSETABLE, TARGETTABLE);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.TIQU GetModelByCache(string SOURSETABLE, string TARGETTABLE)
    //{

    //  string CacheKey = "TIQUModel-" + SOURSETABLE + TARGETTABLE;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(SOURSETABLE, TARGETTABLE);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.TIQU)objModel;
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
    public List<StatisticsSystem.Model.TIQU> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.TIQU> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.TIQU> modelList = new List<StatisticsSystem.Model.TIQU>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.TIQU model;
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
    public DataSet GetList_tq(string bblx)
    {
      return dal.GetList_tq(bblx);
    }
    public DataSet Get_tq(string bbbm)
    {
      return dal.Get_tq(bbbm);
    }
    public bool Delete(string TARGETTABLE)
    {

      return dal.Delete(TARGETTABLE);
    }
    #endregion  ExtensionMethod
  }
}

