using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:CustomLosts
	/// </summary>
	public partial class CustomLosts
	{
		public CustomLosts()
		{}
        #region  BasicMethod
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("CLID", "CustomLosts");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CLID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CustomLosts");
            strSql.Append(" where CLID=@CLID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CLID", SqlDbType.Int,4)
            };
            parameters[0].Value = CLID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.CustomLosts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CustomLosts(");
            strSql.Append("CusID,CLOrderDate,CLDate,CLEnterDate,CLReason,CLState)");
            strSql.Append(" values (");
            strSql.Append("@CusID,@CLOrderDate,@CLDate,@CLEnterDate,@CLReason,@CLState)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14),
                    new SqlParameter("@CLOrderDate", SqlDbType.DateTime),
                    new SqlParameter("@CLDate", SqlDbType.DateTime),
                    new SqlParameter("@CLEnterDate", SqlDbType.DateTime),
                    new SqlParameter("@CLReason", SqlDbType.NVarChar,500),
                    new SqlParameter("@CLState", SqlDbType.Int,4)};
            parameters[0].Value = model.CusID;
            parameters[1].Value = model.CLOrderDate;
            parameters[2].Value = model.CLDate;
            parameters[3].Value = model.CLEnterDate;
            parameters[4].Value = model.CLReason;
            parameters[5].Value = model.CLState;

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
        public bool Update(Maticsoft.Model.CustomLosts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CustomLosts set ");
            strSql.Append("CusID=@CusID,");
            strSql.Append("CLOrderDate=@CLOrderDate,");
            strSql.Append("CLDate=@CLDate,");
            strSql.Append("CLEnterDate=@CLEnterDate,");
            strSql.Append("CLReason=@CLReason,");
            strSql.Append("CLState=@CLState");
            strSql.Append(" where CLID=@CLID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14),
                    new SqlParameter("@CLOrderDate", SqlDbType.DateTime),
                    new SqlParameter("@CLDate", SqlDbType.DateTime),
                    new SqlParameter("@CLEnterDate", SqlDbType.DateTime),
                    new SqlParameter("@CLReason", SqlDbType.NVarChar,500),
                    new SqlParameter("@CLState", SqlDbType.Int,4),
                    new SqlParameter("@CLID", SqlDbType.Int,4)};
            parameters[0].Value = model.CusID;
            parameters[1].Value = model.CLOrderDate;
            parameters[2].Value = model.CLDate;
            parameters[3].Value = model.CLEnterDate;
            parameters[4].Value = model.CLReason;
            parameters[5].Value = model.CLState;
            parameters[6].Value = model.CLID;

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
        /// 更新一条数据
        /// </summary>
        public bool UpdateOne(Maticsoft.Model.CustomLosts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CustomLosts set ");
            strSql.Append("CLEnterDate=@CLEnterDate,");
            strSql.Append("CLReason=@CLReason,");
            strSql.Append("CLState=@CLState");
            strSql.Append(" where CLID=@CLID");
            SqlParameter[] parameters = {
             
               
               
                    new SqlParameter("@CLEnterDate", SqlDbType.DateTime),
                    new SqlParameter("@CLReason", SqlDbType.NVarChar,500),
                    new SqlParameter("@CLState", SqlDbType.Int,4),
                    new SqlParameter("@CLID", SqlDbType.Int,4)};
         
            parameters[0].Value = model.CLEnterDate;
            parameters[1].Value = model.CLReason;
            parameters[2].Value = model.CLState;
            parameters[3].Value = model.CLID;

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
        public bool Delete(int CLID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CustomLosts ");
            strSql.Append(" where CLID=@CLID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CLID", SqlDbType.Int,4)
            };
            parameters[0].Value = CLID;

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
        public bool DeleteList(string CLIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CustomLosts ");
            strSql.Append(" where CLID in (" + CLIDlist + ")  ");
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
        public Maticsoft.Model.CustomLosts GetModel(int CLID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CustomLosts.*, Customers.CusName");
            strSql.Append(" FROM   Customers INNER JOIN CustomLosts ON Customers.CusID = CustomLosts.CusID");
            strSql.Append(" where CustomLosts.CLID=@CLID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CLID", SqlDbType.Int,4)
            };
            parameters[0].Value = CLID;

            Maticsoft.Model.CustomLosts model = new Maticsoft.Model.CustomLosts();
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
        public Maticsoft.Model.CustomLosts DataRowToModel(DataRow row)
        {
            Maticsoft.Model.CustomLosts model = new Maticsoft.Model.CustomLosts();
            if (row != null)
            {
                if (row["CLID"] != null && row["CLID"].ToString() != "")
                {
                    model.CLID = int.Parse(row["CLID"].ToString());
                }
                if (row["CusID"] != null)
                {
                    model.CusID = row["CusID"].ToString();
                }
                if (row["CLOrderDate"] != null && row["CLOrderDate"].ToString() != "")
                {
                    model.CLOrderDate = DateTime.Parse(row["CLOrderDate"].ToString());
                }
                if (row["CLDate"] != null && row["CLDate"].ToString() != "")
                {
                    model.CLDate = DateTime.Parse(row["CLDate"].ToString());
                }
                if (row["CLEnterDate"] != null && row["CLEnterDate"].ToString() != "")
                {
                    model.CLEnterDate = DateTime.Parse(row["CLEnterDate"].ToString());
                }
                if (row["CLReason"] != null)
                {
                    model.CLReason = row["CLReason"].ToString();
                }
                if (row["CLState"] != null && row["CLState"].ToString() != "")
                {
                    model.CLState = int.Parse(row["CLState"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CustomLosts.*, Customers.CusName");
            strSql.Append(" FROM   Customers INNER JOIN CustomLosts ON Customers.CusID = CustomLosts.CusID");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表(自建)
        /// </summary>
        public DataSet GetListTwo(string strWhere,string strwheretwo,int pagesize,int pageindex)
        {
            StringBuilder strSql = new StringBuilder();
            
            strSql.AppendFormat("select top {0} * from  Customers INNER JOIN CustomLosts ON Customers.CusID = CustomLosts.CusID where CLID not in", pagesize);

            if (strwheretwo.Trim() != "")
            {
                strSql.AppendFormat("(select top ({0}*({1}-1)) CLID from Customers INNER JOIN CustomLosts ON Customers.CusID = CustomLosts.CusID where {2} )", pagesize, pageindex,strwheretwo);
            }
            else {
                strSql.AppendFormat("(select top ({0}*({1}-1)) CLID from Customers INNER JOIN CustomLosts ON Customers.CusID = CustomLosts.CusID )", pagesize, pageindex);
            }
            if (strWhere.Trim() != "")
            {
                strSql.Append(" " + strWhere);
            }
            //else {
            //    strSql.Append("order by  CLID desc");
            //}
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
            strSql.Append(" CLID,CusID,CLOrderDate,CLDate,CLEnterDate,CLReason,CLState ");
            strSql.Append(" FROM CustomLosts ");
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
            strSql.Append("select count(1) FROM CustomLosts ");
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
        /// 获取记录总数（自建的）
        /// </summary>
        public int GetRecordCountTwo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(*)");
            strSql.Append(" FROM   Customers INNER JOIN CustomLosts ON Customers.CusID = CustomLosts.CusID");
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
                strSql.Append("order by T.CLID desc");
            }
            strSql.Append(")AS Row, T.*  from CustomLosts T ");
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
			parameters[0].Value = "CustomLosts";
			parameters[1].Value = "CLID";
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

