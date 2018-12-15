using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:LinkMans
	/// </summary>
	public partial class LinkMans
	{
		public LinkMans()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("LMID", "LinkMans");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int LMID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from LinkMans");
            strSql.Append(" where LMID=@LMID");
            SqlParameter[] parameters = {
                    new SqlParameter("@LMID", SqlDbType.Int,4)
            };
            parameters[0].Value = LMID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.LinkMans model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into LinkMans(");
            strSql.Append("CusID,LMName,LMSex,LMDuty,LMMobileNo,LMOfficeNo,LMMemo)");
            strSql.Append(" values (");
            strSql.Append("@CusID,@LMName,@LMSex,@LMDuty,@LMMobileNo,@LMOfficeNo,@LMMemo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14),
                    new SqlParameter("@LMName", SqlDbType.NVarChar,50),
                    new SqlParameter("@LMSex", SqlDbType.Char,2),
                    new SqlParameter("@LMDuty", SqlDbType.NVarChar,50),
                    new SqlParameter("@LMMobileNo", SqlDbType.VarChar,50),
                    new SqlParameter("@LMOfficeNo", SqlDbType.VarChar,50),
                    new SqlParameter("@LMMemo", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.CusID;
            parameters[1].Value = model.LMName;
            parameters[2].Value = model.LMSex;
            parameters[3].Value = model.LMDuty;
            parameters[4].Value = model.LMMobileNo;
            parameters[5].Value = model.LMOfficeNo;
            parameters[6].Value = model.LMMemo;

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
        public bool Update(Maticsoft.Model.LinkMans model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update LinkMans set ");
            strSql.Append("CusID=@CusID,");
            strSql.Append("LMName=@LMName,");
            strSql.Append("LMSex=@LMSex,");
            strSql.Append("LMDuty=@LMDuty,");
            strSql.Append("LMMobileNo=@LMMobileNo,");
            strSql.Append("LMOfficeNo=@LMOfficeNo,");
            strSql.Append("LMMemo=@LMMemo");
            strSql.Append(" where LMID=@LMID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14),
                    new SqlParameter("@LMName", SqlDbType.NVarChar,50),
                    new SqlParameter("@LMSex", SqlDbType.Char,2),
                    new SqlParameter("@LMDuty", SqlDbType.NVarChar,50),
                    new SqlParameter("@LMMobileNo", SqlDbType.VarChar,50),
                    new SqlParameter("@LMOfficeNo", SqlDbType.VarChar,50),
                    new SqlParameter("@LMMemo", SqlDbType.NVarChar,500),
                    new SqlParameter("@LMID", SqlDbType.Int,4)};
            parameters[0].Value = model.CusID;
            parameters[1].Value = model.LMName;
            parameters[2].Value = model.LMSex;
            parameters[3].Value = model.LMDuty;
            parameters[4].Value = model.LMMobileNo;
            parameters[5].Value = model.LMOfficeNo;
            parameters[6].Value = model.LMMemo;
            parameters[7].Value = model.LMID;

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
        public bool Delete(int LMID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from LinkMans ");
            strSql.Append(" where LMID=@LMID");
            SqlParameter[] parameters = {
                    new SqlParameter("@LMID", SqlDbType.Int,4)
            };
            parameters[0].Value = LMID;

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
        public bool DeleteList(string LMIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from LinkMans ");
            strSql.Append(" where LMID in (" + LMIDlist + ")  ");
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
        public Maticsoft.Model.LinkMans GetModel(int LMID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 LMID,CusID,LMName,LMSex,LMDuty,LMMobileNo,LMOfficeNo,LMMemo from LinkMans ");
            strSql.Append(" where LMID=@LMID");
            SqlParameter[] parameters = {
                    new SqlParameter("@LMID", SqlDbType.Int,4)
            };
            parameters[0].Value = LMID;

            Maticsoft.Model.LinkMans model = new Maticsoft.Model.LinkMans();
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
        public Maticsoft.Model.LinkMans DataRowToModel(DataRow row)
        {
            Maticsoft.Model.LinkMans model = new Maticsoft.Model.LinkMans();
            if (row != null)
            {
                if (row["LMID"] != null && row["LMID"].ToString() != "")
                {
                    model.LMID = int.Parse(row["LMID"].ToString());
                }
                if (row["CusID"] != null)
                {
                    model.CusID = row["CusID"].ToString();
                }
                if (row["LMName"] != null)
                {
                    model.LMName = row["LMName"].ToString();
                }
                if (row["LMSex"] != null)
                {
                    model.LMSex = row["LMSex"].ToString();
                }
                if (row["LMDuty"] != null)
                {
                    model.LMDuty = row["LMDuty"].ToString();
                }
                if (row["LMMobileNo"] != null)
                {
                    model.LMMobileNo = row["LMMobileNo"].ToString();
                }
                if (row["LMOfficeNo"] != null)
                {
                    model.LMOfficeNo = row["LMOfficeNo"].ToString();
                }
                if (row["LMMemo"] != null)
                {
                    model.LMMemo = row["LMMemo"].ToString();
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
            strSql.Append("SELECT  LinkMans.*, Customers.CusName");
            strSql.Append(" FROM Customers INNER JOIN LinkMans ON Customers.CusID = LinkMans.CusID ");
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
            strSql.Append(" LMID,CusID,LMName,LMSex,LMDuty,LMMobileNo,LMOfficeNo,LMMemo ");
            strSql.Append(" FROM LinkMans ");
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
            strSql.Append("select count(1) FROM LinkMans ");
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
                strSql.Append("order by T.LMID desc");
            }
            strSql.Append(")AS Row, T.*  from LinkMans T ");
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
			parameters[0].Value = "LinkMans";
			parameters[1].Value = "LMID";
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

