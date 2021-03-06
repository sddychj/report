﻿using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// XMLVERSION_DW
  /// </summary>
  public partial class XMLVERSION_DW_HideCol
  {
    private readonly StatisticsSystem.DAL.XMLVERSION_DW_HideCol dal = new StatisticsSystem.DAL.XMLVERSION_DW_HideCol();
    public XMLVERSION_DW_HideCol()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal YEAR, string DWBM, string BBBM)
    {
      return dal.Exists(YEAR, DWBM, BBBM);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.XMLVERSION_DW_HideCol model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.XMLVERSION_DW_HideCol model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(decimal YEAR, string DWBM, string BBBM)
    {

      return dal.Delete(YEAR, DWBM, BBBM);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.XMLVERSION_DW_HideCol GetModel(decimal YEAR, string DWBM, string BBBM)
    {

      return dal.GetModel(YEAR, DWBM, BBBM);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.XMLVERSION_DW GetModelByCache(decimal YEAR, string DWBM, string BBBM)
    //{

    //  string CacheKey = "XMLVERSION_DWModel-" + YEAR + DWBM + BBBM;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(YEAR, DWBM, BBBM);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.XMLVERSION_DW)objModel;
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
    public List<StatisticsSystem.Model.XMLVERSION_DW_HideCol> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.XMLVERSION_DW_HideCol> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.XMLVERSION_DW_HideCol> modelList = new List<StatisticsSystem.Model.XMLVERSION_DW_HideCol>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.XMLVERSION_DW_HideCol model;
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

    public DataSet GetListDWMC(string bbbm, string year)
    {
      return dal.GetListDWMC(bbbm, year);
    }
    #endregion  ExtensionMethod
  }
}

