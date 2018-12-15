using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// Customers
	/// </summary>
	public partial class Customers
	{
		private readonly Maticsoft.DAL.Customers dal=new Maticsoft.DAL.Customers();
		public Customers()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string CusID)
        {
            return dal.Exists(CusID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.Customers model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.Customers model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 更新客户状态为流失
        /// </summary>
        public bool UpdateOne(String CusID)
        {
            return dal.UpdateOne(CusID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string CusID)
        {

            return dal.Delete(CusID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string CusIDlist)
        {
            return dal.DeleteList(CusIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.Customers GetModel(string CusID)
        {

            return dal.GetModel(CusID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Maticsoft.Model.Customers GetModelByCache(string CusID)
        {

            string CacheKey = "CustomersModel-" + CusID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(CusID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Maticsoft.Model.Customers)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,string wheretwo,int pagesize,int pageindex)
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
        public List<Maticsoft.Model.Customers> GetModelList(string strWhere,string wheretwo,int pagesize,int pageindex)
        {
            DataSet ds = dal.GetList(strWhere, wheretwo,pagesize,pageindex);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表(自建)
        /// </summary>
        public List<Maticsoft.Model.Customers> GetModelListTwo(string strWhere)
        {
            DataSet ds = dal.GetListTwo(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.Customers> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.Customers> modelList = new List<Maticsoft.Model.Customers>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.Customers model;
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
        //public DataSet GetAllList(int pagesize,int pageindex)
        //{
        //    return GetList("",pagesize,pageindex);
        //}

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// 获取记录总数（自建的）
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

