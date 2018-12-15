using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ServiceType
	/// </summary>
	public partial class ServiceType
	{
		public ServiceType()
		{}
        #region  BasicMethod


        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("STID", "ServiceType");
        }

        /// <summary>
        /// 查询功能
        /// </summary>
        /// <returns></returns>
        public DataSet SelectTy(Model.ServiceType b)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select * from ServiceType where 1>0");

            if (b.STID > 0)
            {
                strSql.Append(" and ServiceType.STID = '" + b.STID + "'");
            }

            return DBUtility.DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int STID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ServiceType");
            strSql.Append(" where STID=@STID");
            SqlParameter[] parameters = {
                    new SqlParameter("@STID", SqlDbType.Int,4)
            };
            parameters[0].Value = STID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.ServiceType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ServiceType(");
            strSql.Append("STName)");
            strSql.Append(" values (");
            strSql.Append("@STName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@STName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.STName;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Maticsoft.Model.ServiceType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ServiceType set ");
            strSql.Append("STName=@STName");
            strSql.Append(" where STID=@STID");
            SqlParameter[] parameters = {
                    new SqlParameter("@STName", SqlDbType.NVarChar,50),
                    new SqlParameter("@STID", SqlDbType.Int,4)};
            parameters[0].Value = model.STName;
            parameters[1].Value = model.STID;

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
        public bool Delete(int STID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ServiceType ");
            strSql.Append(" where STID=@STID");
            SqlParameter[] parameters = {
                    new SqlParameter("@STID", SqlDbType.Int,4)
            };
            parameters[0].Value = STID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string STIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ServiceType ");
            strSql.Append(" where STID in (" + STIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Maticsoft.Model.ServiceType GetModel(int STID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 STID,STName from ServiceType ");
            strSql.Append(" where STID=@STID");
            SqlParameter[] parameters = {
                    new SqlParameter("@STID", SqlDbType.Int,4)
            };
            parameters[0].Value = STID;

            Maticsoft.Model.ServiceType model = new Maticsoft.Model.ServiceType();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public Maticsoft.Model.ServiceType DataRowToModel(DataRow row)
        {
            Maticsoft.Model.ServiceType model = new Maticsoft.Model.ServiceType();
            if (row != null)
            {
                if (row["STID"] != null && row["STID"].ToString() != "")
                {
                    model.STID = int.Parse(row["STID"].ToString());
                }
                if (row["STName"] != null)
                {
                    model.STName = row["STName"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select STID,STName ");
            strSql.Append(" FROM ServiceType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" STID,STName ");
            strSql.Append(" FROM ServiceType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ServiceType ");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.STID desc");
            }
            strSql.Append(")AS Row, T.*  from ServiceType T ");
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
			parameters[0].Value = "ServiceType";
			parameters[1].Value = "STID";
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

