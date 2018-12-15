using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Activitys
	/// </summary>
	public partial class Activitys
	{
		public Activitys()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ActID", "Activitys"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ActID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Activitys");
			strSql.Append(" where ActID=@ActID");
			SqlParameter[] parameters = {
					new SqlParameter("@ActID", SqlDbType.Int,4)
			};
			parameters[0].Value = ActID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Activitys model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Activitys(");
			strSql.Append("CusID,ActDate,ActAdd,ActTitle,ActMemo,ActDesc)");
			strSql.Append(" values (");
			strSql.Append("@CusID,@ActDate,@ActAdd,@ActTitle,@ActMemo,@ActDesc)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CusID", SqlDbType.Char,14),
					new SqlParameter("@ActDate", SqlDbType.DateTime),
					new SqlParameter("@ActAdd", SqlDbType.NVarChar,100),
					new SqlParameter("@ActTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@ActMemo", SqlDbType.NVarChar,100),
					new SqlParameter("@ActDesc", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.CusID;
			parameters[1].Value = model.ActDate;
			parameters[2].Value = model.ActAdd;
			parameters[3].Value = model.ActTitle;
			parameters[4].Value = model.ActMemo;
			parameters[5].Value = model.ActDesc;

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
		public bool Update(Maticsoft.Model.Activitys model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Activitys set ");
			strSql.Append("CusID=@CusID,");
			strSql.Append("ActDate=@ActDate,");
			strSql.Append("ActAdd=@ActAdd,");
			strSql.Append("ActTitle=@ActTitle,");
			strSql.Append("ActMemo=@ActMemo,");
			strSql.Append("ActDesc=@ActDesc");
			strSql.Append(" where ActID=@ActID");
			SqlParameter[] parameters = {
					new SqlParameter("@CusID", SqlDbType.Char,14),
					new SqlParameter("@ActDate", SqlDbType.DateTime),
					new SqlParameter("@ActAdd", SqlDbType.NVarChar,100),
					new SqlParameter("@ActTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@ActMemo", SqlDbType.NVarChar,100),
					new SqlParameter("@ActDesc", SqlDbType.NVarChar,-1),
					new SqlParameter("@ActID", SqlDbType.Int,4)};
			parameters[0].Value = model.CusID;
			parameters[1].Value = model.ActDate;
			parameters[2].Value = model.ActAdd;
			parameters[3].Value = model.ActTitle;
			parameters[4].Value = model.ActMemo;
			parameters[5].Value = model.ActDesc;
			parameters[6].Value = model.ActID;

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
		public bool Delete(int ActID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Activitys ");
			strSql.Append(" where ActID=@ActID");
			SqlParameter[] parameters = {
					new SqlParameter("@ActID", SqlDbType.Int,4)
			};
			parameters[0].Value = ActID;

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
		public bool DeleteList(string ActIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Activitys ");
			strSql.Append(" where ActID in ("+ActIDlist + ")  ");
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
		public Maticsoft.Model.Activitys GetModel(int ActID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ActID,CusID,ActDate,ActAdd,ActTitle,ActMemo,ActDesc from Activitys ");
			strSql.Append(" where ActID=@ActID");
			SqlParameter[] parameters = {
					new SqlParameter("@ActID", SqlDbType.Int,4)
			};
			parameters[0].Value = ActID;

			Maticsoft.Model.Activitys model=new Maticsoft.Model.Activitys();
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
		public Maticsoft.Model.Activitys DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Activitys model=new Maticsoft.Model.Activitys();
			if (row != null)
			{
				if(row["ActID"]!=null && row["ActID"].ToString()!="")
				{
					model.ActID=int.Parse(row["ActID"].ToString());
				}
				if(row["CusID"]!=null)
				{
					model.CusID=row["CusID"].ToString();
				}
				if(row["ActDate"]!=null && row["ActDate"].ToString()!="")
				{
					model.ActDate=DateTime.Parse(row["ActDate"].ToString());
				}
				if(row["ActAdd"]!=null)
				{
					model.ActAdd=row["ActAdd"].ToString();
				}
				if(row["ActTitle"]!=null)
				{
					model.ActTitle=row["ActTitle"].ToString();
				}
				if(row["ActMemo"]!=null)
				{
					model.ActMemo=row["ActMemo"].ToString();
				}
				if(row["ActDesc"]!=null)
				{
					model.ActDesc=row["ActDesc"].ToString();
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
			strSql.Append("select ActID,CusID,ActDate,ActAdd,ActTitle,ActMemo,ActDesc ");
			strSql.Append(" FROM Activitys ");
			if(strWhere.Trim()!="")
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
			strSql.Append(" ActID,CusID,ActDate,ActAdd,ActTitle,ActMemo,ActDesc ");
			strSql.Append(" FROM Activitys ");
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
			strSql.Append("select count(1) FROM Activitys ");
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
				strSql.Append("order by T.ActID desc");
			}
			strSql.Append(")AS Row, T.*  from Activitys T ");
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
			parameters[0].Value = "Activitys";
			parameters[1].Value = "ActID";
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

