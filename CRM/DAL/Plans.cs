using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Plans
	/// </summary>
	public partial class Plans
	{
		public Plans()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PlanID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Plans");
			strSql.Append(" where PlanID=@PlanID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlanID", SqlDbType.Char,36)			};
			parameters[0].Value = PlanID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Plans model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Plans(");
			strSql.Append("PlanID,ChanID,PlanDate,PlanContent,PlanResultDate,PlanResult)");
			strSql.Append(" values (");
			strSql.Append("@PlanID,@ChanID,@PlanDate,@PlanContent,@PlanResultDate,@PlanResult)");
			SqlParameter[] parameters = {
					new SqlParameter("@PlanID", SqlDbType.Char,36),
					new SqlParameter("@ChanID", SqlDbType.Int,4),
					new SqlParameter("@PlanDate", SqlDbType.DateTime),
					new SqlParameter("@PlanContent", SqlDbType.NVarChar,1000),
					new SqlParameter("@PlanResultDate", SqlDbType.DateTime),
					new SqlParameter("@PlanResult", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.PlanID;
			parameters[1].Value = model.ChanID;
			parameters[2].Value = model.PlanDate;
			parameters[3].Value = model.PlanContent;
			parameters[4].Value = model.PlanResultDate;
			parameters[5].Value = model.PlanResult;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Plans model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Plans set ");
			strSql.Append("ChanID=@ChanID,");
			strSql.Append("PlanDate=@PlanDate,");
			strSql.Append("PlanContent=@PlanContent,");
			strSql.Append("PlanResultDate=@PlanResultDate,");
			strSql.Append("PlanResult=@PlanResult");
			strSql.Append(" where PlanID=@PlanID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ChanID", SqlDbType.Int,4),
					new SqlParameter("@PlanDate", SqlDbType.DateTime),
					new SqlParameter("@PlanContent", SqlDbType.NVarChar,1000),
					new SqlParameter("@PlanResultDate", SqlDbType.DateTime),
					new SqlParameter("@PlanResult", SqlDbType.NVarChar,1000),
					new SqlParameter("@PlanID", SqlDbType.Char,36)};
			parameters[0].Value = model.ChanID;
			parameters[1].Value = model.PlanDate;
			parameters[2].Value = model.PlanContent;
			parameters[3].Value = model.PlanResultDate;
			parameters[4].Value = model.PlanResult;
			parameters[5].Value = model.PlanID;

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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string PlanID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Plans ");
			strSql.Append(" where PlanID=@PlanID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlanID", SqlDbType.Char,36)			};
			parameters[0].Value = PlanID;

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
		public bool DeleteList(string PlanIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Plans ");
			strSql.Append(" where PlanID in ("+PlanIDlist + ")  ");
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
		public Maticsoft.Model.Plans GetModel(string PlanID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PlanID,ChanID,PlanDate,PlanContent,PlanResultDate,PlanResult from Plans ");
			strSql.Append(" where PlanID=@PlanID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PlanID", SqlDbType.Char,36)			};
			parameters[0].Value = PlanID;

			Maticsoft.Model.Plans model=new Maticsoft.Model.Plans();
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
		public Maticsoft.Model.Plans DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Plans model=new Maticsoft.Model.Plans();
			if (row != null)
			{
				if(row["PlanID"]!=null)
				{
					model.PlanID=row["PlanID"].ToString();
				}
				if(row["ChanID"]!=null && row["ChanID"].ToString()!="")
				{
					model.ChanID=int.Parse(row["ChanID"].ToString());
				}
				if(row["PlanDate"]!=null && row["PlanDate"].ToString()!="")
				{
					model.PlanDate=DateTime.Parse(row["PlanDate"].ToString());
				}
				if(row["PlanContent"]!=null)
				{
					model.PlanContent=row["PlanContent"].ToString();
				}
				if(row["PlanResultDate"]!=null && row["PlanResultDate"].ToString()!="")
				{
					model.PlanResultDate=DateTime.Parse(row["PlanResultDate"].ToString());
				}
				if(row["PlanResult"]!=null)
				{
					model.PlanResult=row["PlanResult"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM Plans a ");
            strSql.Append(" inner join Chances b on a.ChanID=b.ChanID ");
            if (strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
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
			strSql.Append(" PlanID,ChanID,PlanDate,PlanContent,PlanResultDate,PlanResult ");
			strSql.Append(" FROM Plans ");
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
			strSql.Append("select count(1) FROM Plans a");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
				strSql.Append("order by T.PlanID desc");
			}
			strSql.Append(")AS Row, T.*  from Plans T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
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
			parameters[0].Value = "Plans";
			parameters[1].Value = "PlanID";
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

