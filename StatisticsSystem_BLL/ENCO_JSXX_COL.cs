using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// ENCO_JSXX_COL
  /// </summary>
  public partial class ENCO_JSXX_COL
  {
    private readonly StatisticsSystem.DAL.ENCO_JSXX_COL dal = new StatisticsSystem.DAL.ENCO_JSXX_COL();
    public ENCO_JSXX_COL()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal JSXXID)
    {
      return dal.Exists(JSXXID);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_JSXX_COL model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ENCO_JSXX_COL model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(decimal JSXXID)
    {

      return dal.Delete(JSXXID);
    }
    /// <summary>
    /// 删除一条数据
    /// </summary>
    //public bool DeleteList(string JSXXIDlist)
    //{
    //  return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(JSXXIDlist, 0));
    //}

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_JSXX_COL GetModel(decimal JSXXID)
    {

      return dal.GetModel(JSXXID);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.ENCO_JSXX_COL GetModelByCache(decimal JSXXID)
    //{

    //  string CacheKey = "ENCO_JSXX_COLModel-" + JSXXID;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(JSXXID);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.ENCO_JSXX_COL)objModel;
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
    public List<StatisticsSystem.Model.ENCO_JSXX_COL> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.ENCO_JSXX_COL> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.ENCO_JSXX_COL> modelList = new List<StatisticsSystem.Model.ENCO_JSXX_COL>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.ENCO_JSXX_COL model;
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

    public DataSet GetYear()
    {
      return dal.GetYear();
    }
    public Dictionary<string, Model.ENCO_JSXX_COL> GetJSxxHash(string BBBM, string year, string month, string dwbm)
    {
      year = year == "" ? year : "[" + year + "]";
      month = month == "" ? month : "[" + month + "]";
      Dictionary<string, Model.ENCO_JSXX_COL> jsxx = dal.GetJSXXHash(BBBM, year, month, dwbm);
      return jsxx;
    }

    public int GetJSXXID()
    {
      return dal.GetJSXXID();
    }
    public string CrossQuote(Model.ENCO_JSXXYSJ_COL model)
    {
      return dal.CrossQuote(model);
    }

    #endregion  ExtensionMethod
  }
}

