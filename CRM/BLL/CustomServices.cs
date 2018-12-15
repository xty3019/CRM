using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// CustomServices
	/// </summary>
	public partial class CustomServices
	{
		private readonly Maticsoft.DAL.CustomServices dal=new Maticsoft.DAL.CustomServices();
		public CustomServices()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }
        /// <summary>
        /// 查询功能
        /// </summary>
        /// <returns></returns>
        public List<Model.CustomServices> GetAllBook(Model.CustomServices b)
        {
            DataSet ds = dal.GetAllBook(b);

            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CSID)
        {
            return dal.Exists(CSID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.CustomServices model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.CustomServices model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateTwo(Maticsoft.Model.CustomServices model)
        {
            return dal.UpdateTwo(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateFoure(Maticsoft.Model.CustomServices model)
        {
            return dal.UpdateFoure(model);
        }
        public bool UpdateOne(int CSID, int CSDueID)
        {
            return dal.UpdateOne( CSID, CSDueID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int CSID)
        {

            return dal.Delete(CSID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string CSIDlist)
        {
            return dal.DeleteList(CSIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.CustomServices GetModel(int CSID)
        {

            return dal.GetModel(CSID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Maticsoft.Model.CustomServices GetModelByCache(int CSID)
        {

            string CacheKey = "CustomServicesModel-" + CSID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(CSID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Maticsoft.Model.CustomServices)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string wheretwo, int pagesize, int pageindex)
        {
            return dal.GetList(strWhere,wheretwo,pagesize,pageindex);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.CustomServices> GetModelList(string strWhere, string wheretwo, int pagesize, int pageindex)
        {
            DataSet ds = dal.GetList(strWhere,wheretwo,pagesize,pageindex);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.CustomServices> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.CustomServices> modelList = new List<Maticsoft.Model.CustomServices>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.CustomServices model;
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

        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetAllList()
        //{
        //    return GetList("");
        //}

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCountTwo(string strWhere)
        {
            return dal.GetRecordCountTwo(strWhere);
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

        #endregion  ExtensionMethod


    }
}

