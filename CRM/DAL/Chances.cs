using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Chances
	/// </summary>
	public partial class Chances
	{
		public Chances()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ChanID", "Chances"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ChanID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Chances");
			strSql.Append(" where ChanID=@ChanID");
			SqlParameter[] parameters = {
					new SqlParameter("@ChanID", SqlDbType.Int,4)
			};
			parameters[0].Value = ChanID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Chances model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Chances(");
			strSql.Append("ChanName,ChanRate,ChanLinkMan,ChanLinkTel,ChanTitle,ChanDesc,ChanCreateMan,ChanCreateDate,ChanDueMan,ChanDueDate,ChanState,ChanError)");
			strSql.Append(" values (");
			strSql.Append("@ChanName,@ChanRate,@ChanLinkMan,@ChanLinkTel,@ChanTitle,@ChanDesc,@ChanCreateMan,@ChanCreateDate,@ChanDueMan,@ChanDueDate,@ChanState,@ChanError)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ChanName", SqlDbType.NVarChar,50),
					new SqlParameter("@ChanRate", SqlDbType.Int,4),
					new SqlParameter("@ChanLinkMan", SqlDbType.NVarChar,50),
					new SqlParameter("@ChanLinkTel", SqlDbType.VarChar,50),
					new SqlParameter("@ChanTitle", SqlDbType.NVarChar,500),
					new SqlParameter("@ChanDesc", SqlDbType.NVarChar,2000),
					new SqlParameter("@ChanCreateMan", SqlDbType.Int,4),
					new SqlParameter("@ChanCreateDate", SqlDbType.DateTime),
					new SqlParameter("@ChanDueMan", SqlDbType.Int,4),
					new SqlParameter("@ChanDueDate", SqlDbType.DateTime),
					new SqlParameter("@ChanState", SqlDbType.Int,4),
					new SqlParameter("@ChanError", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.ChanName;
			parameters[1].Value = model.ChanRate;
			parameters[2].Value = model.ChanLinkMan;
			parameters[3].Value = model.ChanLinkTel;
			parameters[4].Value = model.ChanTitle;
			parameters[5].Value = model.ChanDesc;
			parameters[6].Value = model.ChanCreateMan;
			parameters[7].Value = model.ChanCreateDate;
			parameters[8].Value = model.ChanDueMan;
			parameters[9].Value = model.ChanDueDate;
			parameters[10].Value = model.ChanState;
			parameters[11].Value = model.ChanError;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Chances model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Chances set ");
			strSql.Append("ChanName=@ChanName,");
			strSql.Append("ChanRate=@ChanRate,");
			strSql.Append("ChanLinkMan=@ChanLinkMan,");
			strSql.Append("ChanLinkTel=@ChanLinkTel,");
			strSql.Append("ChanTitle=@ChanTitle,");
			strSql.Append("ChanDesc=@ChanDesc,");
			strSql.Append("ChanCreateMan=@ChanCreateMan,");
			strSql.Append("ChanDueMan=@ChanDueMan,");
			strSql.Append("ChanDueDate=@ChanDueDate,");
			strSql.Append("ChanState=@ChanState,");
			strSql.Append("ChanError=@ChanError");
			strSql.Append(" where ChanID=@ChanID");
			SqlParameter[] parameters = {
					new SqlParameter("@ChanName", SqlDbType.NVarChar,50),
					new SqlParameter("@ChanRate", SqlDbType.Int,4),
					new SqlParameter("@ChanLinkMan", SqlDbType.NVarChar,50),
					new SqlParameter("@ChanLinkTel", SqlDbType.VarChar,50),
					new SqlParameter("@ChanTitle", SqlDbType.NVarChar,500),
					new SqlParameter("@ChanDesc", SqlDbType.NVarChar,2000),
					new SqlParameter("@ChanCreateMan", SqlDbType.Int,4),
					
					new SqlParameter("@ChanDueMan", SqlDbType.Int,4),
					new SqlParameter("@ChanDueDate", SqlDbType.DateTime),
					new SqlParameter("@ChanState", SqlDbType.Int,4),
					new SqlParameter("@ChanError", SqlDbType.NVarChar,500),
					new SqlParameter("@ChanID", SqlDbType.Int,4)};
			parameters[0].Value = model.ChanName;
			parameters[1].Value = model.ChanRate;
			parameters[2].Value = model.ChanLinkMan;
			parameters[3].Value = model.ChanLinkTel;
			parameters[4].Value = model.ChanTitle;
			parameters[5].Value = model.ChanDesc;
			parameters[6].Value = model.ChanCreateMan;
		
			parameters[7].Value = model.ChanDueMan;
			parameters[8].Value = model.ChanDueDate;
			parameters[9].Value = model.ChanState;
			parameters[10].Value = model.ChanError;
			parameters[11].Value = model.ChanID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

        /// <summary>
        /// 分配客户给指派人
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SetChanDueMan(Maticsoft.Model.Chances model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Chances set ");
            strSql.Append("ChanDueMan=@ChanDueMan,");
            strSql.Append("ChanDueDate=@ChanDueDate,");
            strSql.Append("ChanState=@ChanState");
            strSql.Append(" where ChanID=@ChanID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ChanDueMan", SqlDbType.Int,4),
                    new SqlParameter("@ChanDueDate", SqlDbType.DateTime),
                    new SqlParameter("@ChanState", SqlDbType.Int,4),
                    new SqlParameter("@ChanID", SqlDbType.Int,4)};
            parameters[0].Value = model.ChanDueMan;
            parameters[1].Value = model.ChanDueDate;
            parameters[2].Value = model.ChanState;
            parameters[3].Value = model.ChanID;
        int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
        }
        /// <summary>
        /// 销售机会状态为失败
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SetChancesError(Maticsoft.Model.Chances model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Chances set ");
            strSql.Append("ChanError=@ChanError,");
            strSql.Append("ChanState=@ChanState");
            strSql.Append(" where ChanID=@ChanID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ChanError", SqlDbType.NVarChar,500),
                    new SqlParameter("@ChanState", SqlDbType.Int,4),
                    new SqlParameter("@ChanID", SqlDbType.Int,4)};
            parameters[0].Value = model.ChanError;
            parameters[1].Value = model.ChanState;
            parameters[2].Value = model.ChanID;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 销售机会状态为成功
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SetChanceSuccess(Maticsoft.Model.Chances model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Chances set ");
            strSql.Append("ChanState=@ChanState");
            strSql.Append(" where ChanID=@ChanID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ChanState", SqlDbType.Int,4),
                    new SqlParameter("@ChanID", SqlDbType.Int,4)}; 
            parameters[0].Value = model.ChanState;
            parameters[1].Value = model.ChanID;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ChanID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Chances ");
			strSql.Append(" where ChanID=@ChanID");
			SqlParameter[] parameters = {
					new SqlParameter("@ChanID", SqlDbType.Int,4)
			};
			parameters[0].Value = ChanID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string ChanIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Chances ");
			strSql.Append(" where ChanID in ("+ChanIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Chances GetModel(int ChanID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ChanID,ChanName,ChanRate,ChanLinkMan,ChanLinkTel,ChanTitle,ChanDesc,ChanCreateMan,ChanCreateDate,ChanDueMan,ChanDueDate,ChanState,ChanError from Chances ");
			strSql.Append(" where ChanID=@ChanID");
			SqlParameter[] parameters = {
					new SqlParameter("@ChanID", SqlDbType.Int,4)
			};
			parameters[0].Value = ChanID;

			Maticsoft.Model.Chances model=new Maticsoft.Model.Chances();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Chances DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Chances model=new Maticsoft.Model.Chances();
			if (row != null)
			{
				if(row["ChanID"]!=null && row["ChanID"].ToString()!="")
				{
					model.ChanID=int.Parse(row["ChanID"].ToString());
				}
				if(row["ChanName"]!=null)
				{
					model.ChanName=row["ChanName"].ToString();
				}
				if(row["ChanRate"]!=null && row["ChanRate"].ToString()!="")
				{
					model.ChanRate=int.Parse(row["ChanRate"].ToString());
				}
				if(row["ChanLinkMan"]!=null)
				{
					model.ChanLinkMan=row["ChanLinkMan"].ToString();
				}
				if(row["ChanLinkTel"]!=null)
				{
					model.ChanLinkTel=row["ChanLinkTel"].ToString();
				}
				if(row["ChanTitle"]!=null)
				{
					model.ChanTitle=row["ChanTitle"].ToString();
				}
				if(row["ChanDesc"]!=null)
				{
					model.ChanDesc=row["ChanDesc"].ToString();
				}
				if(row["ChanCreateMan"]!=null && row["ChanCreateMan"].ToString()!="")
				{
					model.ChanCreateMan=int.Parse(row["ChanCreateMan"].ToString());
				}
				if(row["ChanCreateDate"]!=null && row["ChanCreateDate"].ToString()!="")
				{
					model.ChanCreateDate=DateTime.Parse(row["ChanCreateDate"].ToString());
				}
				if(row["ChanDueMan"]!=null && row["ChanDueMan"].ToString()!="")
				{
					model.ChanDueMan=int.Parse(row["ChanDueMan"].ToString());
				}
				if(row["ChanDueDate"]!=null && row["ChanDueDate"].ToString()!="")
				{
					model.ChanDueDate=DateTime.Parse(row["ChanDueDate"].ToString());
				}
				if(row["ChanState"]!=null && row["ChanState"].ToString()!="")
				{
					model.ChanState=int.Parse(row["ChanState"].ToString());
				}
				if(row["ChanError"]!=null)
				{
					model.ChanError=row["ChanError"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere,string wheretwo,int pageindex,int pagesize)
		{
			StringBuilder strSql=new StringBuilder();
			//strSql.AppendFormat("select top {0} * from Chances where ChanID not in (select  top ({0} * ({1} -1)) ChanID from Chances '{2}') ",pagesize,pageindex,wheretwo);
            strSql.Append("select top (@pagesize) * from Chances where ChanID not in  ");
            if (wheretwo.Trim() != "")
            {
                strSql.Append(" (select top ((@pagesize) * (@pageindex - 1)) ChanID from Chances  where" + wheretwo+")");
            }
            else {
                strSql.Append("(select top ((@pagesize) * (@pageindex - 1)) ChanID from Chances) ");
            }
            if (strWhere.Trim()!="")
			{
				strSql.Append(""+strWhere);
			}
            SqlParameter[] parameters = {
                    new SqlParameter("@pagesize", SqlDbType.Int,4),
                      new SqlParameter("@pageindex", SqlDbType.Int,4)
            };
            parameters[0].Value = pagesize;
            parameters[1].Value = pageindex;
            return DbHelperSQL.Query(strSql.ToString(),parameters);
		}

      
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ChanID,ChanName,ChanRate,ChanLinkMan,ChanLinkTel,ChanTitle,ChanDesc,ChanCreateMan,ChanCreateDate,ChanDueMan,ChanDueDate,ChanState,ChanError ");
			strSql.Append(" FROM Chances ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Chances ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where 1>0 "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}

      
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ChanID desc");
			}
			strSql.Append(")AS Row, T.*  from Chances T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 查询对应职位的编号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int SelectRole(string strWhere) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Roleid FROM Role ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        ///得到用户的角色编号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetUserRoleID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Roleid FROM Users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }



        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Chances";
			parameters[1].Value = "ChanID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

