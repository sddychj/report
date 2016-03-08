using System;
using System.Data;
using System.Collections.Generic;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// ENCO_JSXXYSJ
  /// </summary>
  public partial class ENCO_JSXXYSJ
  {
    private readonly StatisticsSystem.DAL.ENCO_JSXXYSJ dal = new StatisticsSystem.DAL.ENCO_JSXXYSJ();
    public ENCO_JSXXYSJ()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal JSXXID, string ONAME)
    {
      return dal.Exists(JSXXID, ONAME);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_JSXXYSJ model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ENCO_JSXXYSJ model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(decimal JSXXID, string ONAME)
    {

      return dal.Delete(JSXXID, ONAME);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_JSXXYSJ GetModel(decimal JSXXID, string ONAME)
    {

      return dal.GetModel(JSXXID, ONAME);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.ENCO_JSXXYSJ GetModelByCache(decimal JSXXID, string ONAME)
    //{

    //  string CacheKey = "ENCO_JSXXYSJModel-" + JSXXID + ONAME;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(JSXXID, ONAME);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.ENCO_JSXXYSJ)objModel;
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
    public List<StatisticsSystem.Model.ENCO_JSXXYSJ> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ENCO_JSXXYSJ> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.ENCO_JSXXYSJ> modelList = new List<StatisticsSystem.Model.ENCO_JSXXYSJ>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.ENCO_JSXXYSJ model;
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
    public DataSet GetList_jsxxid(int jsxxid)
    {
      return dal.GetList_jsxxid(jsxxid);
    }

    public bool Delete(decimal JSXXID)
    {

      return dal.Delete(JSXXID);
    }
    #endregion  ExtensionMethod
  }
}

