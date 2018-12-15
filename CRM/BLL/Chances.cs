using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// Chances
	/// </summary>
	public partial class Chances
	{
		private readonly Maticsoft.DAL.Chances dal=new Maticsoft.DAL.Chances();
		public Chances()
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
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ChanID)
		{
			return dal.Exists(ChanID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.Chances model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Chances model)
		{
			return dal.Update(model);
		}


        /// <summary>
        /// 分配客户给指派人
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SetChanDueMan(Maticsoft.Model.Chances model)
        {
            return dal.SetChanDueMan(model);
        }
        /// <summary>
        /// 销售机会状态为失败
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SetChancesError(Maticsoft.Model.Chances model)
        {
            return dal.SetChancesError(model);
        }
        /// <summary>
        /// 销售机会状态为成功
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SetChanceSuccess(Maticsoft.Model.Chances model)
        {
            return dal.SetChanceSuccess(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ChanID)
		{
			
			return dal.Delete(ChanID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ChanIDlist )
		{
			return dal.DeleteList(ChanIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Chances GetModel(int ChanID)
		{
			
			return dal.GetModel(ChanID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.Chances GetModelByCache(int ChanID)
		{
			
			string CacheKey = "ChancesModel-" + ChanID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ChanID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.Chances)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere,string wheretwo,int pageindex,int pagesize)
		{
			return dal.GetList(strWhere,wheretwo,pageindex,pagesize );
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.Chances> GetModelList(string strWhere,string wheretwo,int pageindex,int pagesize)
		{
			DataSet ds = dal.GetList(strWhere,wheretwo,pageindex,pagesize);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.Chances> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.Chances> modelList = new List<Maticsoft.Model.Chances>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.Chances model;
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
        ///得到用户的角色编号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetUserRoleID(string strWhere)
        {
            return dal.GetUserRoleID(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
            //public DataSet GetAllList()
            //{
            //	return GetList("");
            //}

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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}

        /// <summary>
        /// 查询对应职位的编号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int SelectRole(string strWhere)
        {
            return dal.SelectRole(strWhere);
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

