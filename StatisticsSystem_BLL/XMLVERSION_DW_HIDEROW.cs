using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using StatisticsSystem.Model;
namespace StatisticsSystem.BLL
{
  /// <summary>
  /// XMLVERSION_DW_HIDEROW
  /// </summary>
  public partial class XMLVERSION_DW_HIDEROW
  {
    private readonly StatisticsSystem.DAL.XMLVERSION_DW_HIDEROW dal = new StatisticsSystem.DAL.XMLVERSION_DW_HIDEROW();
    public XMLVERSION_DW_HIDEROW()
    { }
    #region  BasicMethod
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal YEAR, string BBBM, string DWBM)
    {
      return dal.Exists(YEAR, BBBM, DWBM);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.XMLVERSION_DW_HIDEROW model)
    {
      return dal.Add(model);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.XMLVERSION_DW_HIDEROW model)
    {
      return dal.Update(model);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(decimal YEAR, string BBBM, string DWBM)
    {

      return dal.Delete(YEAR, BBBM, DWBM);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.XMLVERSION_DW_HIDEROW GetModel(decimal YEAR, string BBBM, string DWBM)
    {

      return dal.GetModel(YEAR, BBBM, DWBM);
    }

    /// <summary>
    /// 得到一个对象实体，从缓存中
    /// </summary>
    //public StatisticsSystem.Model.XMLVERSION_DW_HIDEROW GetModelByCache(decimal YEAR, string BBBM, string DWBM)
    //{

    //  string CacheKey = "XMLVERSION_DW_HIDEROWModel-" + YEAR + BBBM + DWBM;
    //  object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
    //  if (objModel == null)
    //  {
    //    try
    //    {
    //      objModel = dal.GetModel(YEAR, BBBM, DWBM);
    //      if (objModel != null)
    //      {
    //        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
    //        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
    //      }
    //    }
    //    catch { }
    //  }
    //  return (StatisticsSystem.Model.XMLVERSION_DW_HIDEROW)objModel;
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
    public List<StatisticsSystem.Model.XMLVERSION_DW_HIDEROW> GetModelList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      return DataTableToList(ds.Tables[0]);
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public List<StatisticsSystem.Model.XMLVERSION_DW_HIDEROW> DataTableToList(DataTable dt)
    {
      List<StatisticsSystem.Model.XMLVERSION_DW_HIDEROW> modelList = new List<StatisticsSystem.Model.XMLVERSION_DW_HIDEROW>();
      int rowsCount = dt.Rows.Count;
      if (rowsCount > 0)
      {
        StatisticsSystem.Model.XMLVERSION_DW_HIDEROW model;
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

