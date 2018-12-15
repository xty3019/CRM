using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Measures
	/// </summary>
	public partial class Measures
	{
		public Measures()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeID", "Measures"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Measures");
			strSql.Append(" where MeID=@MeID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeID", SqlDbType.Int,4)
			};
			parameters[0].Value = MeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Measures model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Measures(");
			strSql.Append("CLID,MeDate,MeDesc)");
			strSql.Append(" values (");
			strSql.Append("@CLID,@MeDate,@MeDesc)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CLID", SqlDbType.Int,4),
					new SqlParameter("@MeDate", SqlDbType.DateTime),
					new SqlParameter("@MeDesc", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.CLID;
			parameters[1].Value = model.MeDate;
			parameters[2].Value = model.MeDesc;

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
		public bool Update(Maticsoft.Model.Measures model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Measures set ");
			strSql.Append("CLID=@CLID,");
			strSql.Append("MeDate=@MeDate,");
			strSql.Append("MeDesc=@MeDesc");
			strSql.Append(" where MeID=@MeID");
			SqlParameter[] parameters = {
					new SqlParameter("@CLID", SqlDbType.Int,4),
					new SqlParameter("@MeDate", SqlDbType.DateTime),
					new SqlParameter("@MeDesc", SqlDbType.NVarChar,-1),
					new SqlParameter("@MeID", SqlDbType.Int,4)};
			parameters[0].Value = model.CLID;
			parameters[1].Value = model.MeDate;
			parameters[2].Value = model.MeDesc;
			parameters[3].Value = model.MeID;

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
        public bool UpdateTwo(int mid, string desc) {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Measures set ");
            strSql.Append("MeDesc=@desc");
            strSql.Append(" where MeID=@mid");
            SqlParameter[] parameters = {
     
                    new SqlParameter("@desc", SqlDbType.NVarChar,-1),
                    new SqlParameter("@mid", SqlDbType.Int,4)};
            parameters[0].Value = desc;
            parameters[1].Value = mid;

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
        public bool Delete(int MeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Measures ");
			strSql.Append(" where MeID=@MeID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeID", SqlDbType.Int,4)
			};
			parameters[0].Value = MeID;

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
		public bool DeleteList(string MeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Measures ");
			strSql.Append(" where MeID in ("+MeIDlist + ")  ");
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
		public Maticsoft.Model.Measures GetModel(int MeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MeID,CLID,MeDate,MeDesc from Measures ");
			strSql.Append(" where MeID=@MeID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeID", SqlDbType.Int,4)
			};
			parameters[0].Value = MeID;

			Maticsoft.Model.Measures model=new Maticsoft.Model.Measures();
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
		public Maticsoft.Model.Measures DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Measures model=new Maticsoft.Model.Measures();
			if (row != null)
			{
				if(row["MeID"]!=null && row["MeID"].ToString()!="")
				{
					model.MeID=int.Parse(row["MeID"].ToString());
				}
				if(row["CLID"]!=null && row["CLID"].ToString()!="")
				{
					model.CLID=int.Parse(row["CLID"].ToString());
				}
                if (row["CusID"] != null && row["CusID"].ToString() != "")
                {
                    model.CusID = row["CusID"].ToString();
                }
                if (row["MeDate"]!=null && row["MeDate"].ToString()!="")
				{
					model.MeDate=DateTime.Parse(row["MeDate"].ToString());
				}
				if(row["MeDesc"]!=null)
				{
					model.MeDesc=row["MeDesc"].ToString();
				}
                if (row["CusName"] != null)
                {
                    model.CusName = row["CusName"].ToString();
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
			strSql.Append(@"select a.MeID,a.CLID,a.MeDate,a.MeDesc,b.CusID,c.CusName from Measures a 
                                inner join CustomLosts b on a.CLID = b.CLID
                                inner join Customers c on b.CusID = c.CusID");

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
			strSql.Append(" MeID,CLID,MeDate,MeDesc ");
			strSql.Append(" FROM Measures ");
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
			strSql.Append("select count(1) FROM Measures ");
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
				strSql.Append("order by T.MeID desc");
			}
			strSql.Append(")AS Row, T.*  from Measures T ");
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
			parameters[0].Value = "Measures";
			parameters[1].Value = "MeID";
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

