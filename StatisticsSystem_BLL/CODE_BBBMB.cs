using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// CODE_BBBMB
  /// </summary>
  public partial class CODE_BBBMB
  {
    private readonly StatisticsSystem.DAL.CODE_BBBMB dal = new StatisticsSystem.DAL.CODE_BBBMB();
    public CODE_BBBMB()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM)
    {
      return dal.Exists(BBBM);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.CODE_BBBMB model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.CODE_BBBMB model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string BBBM)
    {

      return dal.Delete(BBBM);
    }
    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool DeleteList(string BBBMlist)
    {
      return dal.DeleteList(BBBMlist);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.CODE_BBBMB GetModel(string BBBM)
    {

      return dal.GetModel(BBBM);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.CODE_BBBMB GetModelByCache(string BBBM)
    //{

    //  string CacheKey = "CODE_BBBMBModel-" + BBBM;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(BBBM);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.CODE_BBBMB)objModel;
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
    public List<StatisticsSystem.Model.CODE_BBBMB> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.CODE_BBBMB> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.CODE_BBBMB> modelList = new List<StatisticsSystem.Model.CODE_BBBMB>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.CODE_BBBMB model;
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

    public Dictionary<string, string> GetDic()
    {
      return dal.GetDic();
    }
    public DataSet GetList_BBLX(string strWhere)
    {
      return dal.GetList_BBLX(strWhere);
    }
    public int GetMaxBBBM()
    {
      return dal.GetMaxBBBM();
    }
    public int GetMaxXH()
    {
      return dal.GetMaxXH();
    }
    public DataSet GetList_BBLX_DW(string dw, string bblx)
    {
      return dal.GetList_BBLX_DW(dw, bblx);
    }
    #endregion  ExtensionMethod
  }
}

