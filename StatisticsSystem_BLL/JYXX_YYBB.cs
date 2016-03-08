using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
using System.Text;

namespace StatisticsSystem.BLL
{
  /// <summary>
  /// JYXX_YYBB
  /// </summary>
  public partial class JYXX_YYBB
  {
    private readonly StatisticsSystem.DAL.JYXX_YYBB dal = new StatisticsSystem.DAL.JYXX_YYBB();
    public JYXX_YYBB()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string YYBBBM)
    {
      return dal.Exists(BBBM, YYBBBM);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.JYXX_YYBB model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.JYXX_YYBB model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string BBBM, string YYBBBM)
    {

      return dal.Delete(BBBM, YYBBBM);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.JYXX_YYBB GetModel(string BBBM, string YYBBBM)
    {

      return dal.GetModel(BBBM, YYBBBM);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.JYXX_YYBB GetModelByCache(string BBBM, string YYBBBM)
    //{

    //  string CacheKey = "JYXX_YYBBModel-" + BBBM + YYBBBM;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(BBBM, YYBBBM);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.JYXX_YYBB)objModel;
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
    public List<StatisticsSystem.Model.JYXX_YYBB> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.JYXX_YYBB> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.JYXX_YYBB> modelList = new List<StatisticsSystem.Model.JYXX_YYBB>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.JYXX_YYBB model;
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
    public DataSet GetList_BBBM(string BBBM)
    {
      return dal.GetList_BBBM(BBBM);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string BBBM)
    {

      return dal.Delete(BBBM);
    }
    #endregion  ExtensionMethod
  }
}

