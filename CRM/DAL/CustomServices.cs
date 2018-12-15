using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:CustomServices
	/// </summary>
	public partial class CustomServices
	{
		public CustomServices()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("CSID", "CustomServices");
        }

        /// 
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CSID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CustomServices");
            strSql.Append(" where CSID=@CSID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CSID", SqlDbType.Int,4)
            };
            parameters[0].Value = CSID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.CustomServices model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CustomServices(");
            strSql.Append("STID,CusID,CSTitle,CSState,CSDesc,CSCreateID,CSDueID,CSDueDate,CSDeal,CSDealDate,CSResult,CSSatisfy)");
            strSql.Append(" values (");
            strSql.Append("@STID,@CusID,@CSTitle,@CSState,@CSDesc,@CSCreateID,@CSDueID,@CSDueDate,@CSDeal,@CSDealDate,@CSResult,@CSSatisfy)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@STID", SqlDbType.Int,4),
                    new SqlParameter("@CusID", SqlDbType.Char,14),
                    new SqlParameter("@CSTitle", SqlDbType.NVarChar,100),
                    new SqlParameter("@CSState", SqlDbType.Int,4),
                    new SqlParameter("@CSDesc", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CSCreateID", SqlDbType.Int,4),

                    new SqlParameter("@CSDueID", SqlDbType.Int,4),
                    new SqlParameter("@CSDueDate", SqlDbType.DateTime),
                    new SqlParameter("@CSDeal", SqlDbType.NVarChar,500),
                    new SqlParameter("@CSDealDate", SqlDbType.DateTime),
                    new SqlParameter("@CSResult", SqlDbType.NVarChar,500),
                    new SqlParameter("@CSSatisfy", SqlDbType.Int,4)};
            parameters[0].Value = model.STID;
            parameters[1].Value = model.CusID;
            parameters[2].Value = model.CSTitle;
            parameters[3].Value = model.CSState;
            parameters[4].Value = model.CSDesc;
            parameters[5].Value = model.CSCreateID;

            parameters[6].Value = model.CSDueID;
            parameters[7].Value = model.CSDueDate;
            parameters[8].Value = model.CSDeal;
            parameters[9].Value = model.CSDealDate;
            parameters[10].Value = model.CSResult;
            parameters[11].Value = model.CSSatisfy;

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
        public bool Update(Maticsoft.Model.CustomServices model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CustomServices set ");
            strSql.Append("STID=@STID,");
            strSql.Append("CusID=@CusID,");
            strSql.Append("CSTitle=@CSTitle,");
            strSql.Append("CSState=@CSState,");
            strSql.Append("CSDesc=@CSDesc,");
            strSql.Append("CSCreateID=@CSCreateID,");
            strSql.Append("CSCreateDate=@CSCreateDate,");
            strSql.Append("CSDueID=@CSDueID,");
            strSql.Append("CSDueDate=@CSDueDate,");
            strSql.Append("CSDeal=@CSDeal,");
            strSql.Append("CSDealDate=@CSDealDate,");
            strSql.Append("CSResult=@CSResult,");
            strSql.Append("CSSatisfy=@CSSatisfy");
            strSql.Append(" where CSID=@CSID");
            SqlParameter[] parameters = {
                    new SqlParameter("@STID", SqlDbType.Int,4),
                    new SqlParameter("@CusID", SqlDbType.Char,14),
                    new SqlParameter("@CSTitle", SqlDbType.NVarChar,100),
                    new SqlParameter("@CSState", SqlDbType.Int,4),
                    new SqlParameter("@CSDesc", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CSCreateID", SqlDbType.Int,4),
                    new SqlParameter("@CSCreateDate", SqlDbType.DateTime),
                    new SqlParameter("@CSDueID", SqlDbType.Int,4),
                    new SqlParameter("@CSDueDate", SqlDbType.DateTime),
                    new SqlParameter("@CSDeal", SqlDbType.NVarChar,500),
                    new SqlParameter("@CSDealDate", SqlDbType.DateTime),
                    new SqlParameter("@CSResult", SqlDbType.NVarChar,500),
                    new SqlParameter("@CSSatisfy", SqlDbType.Int,4),
                    new SqlParameter("@CSID", SqlDbType.Int,4)};
            parameters[0].Value = model.STID;
            parameters[1].Value = model.CusID;
            parameters[2].Value = model.CSTitle;
            parameters[3].Value = model.CSState;
            parameters[4].Value = model.CSDesc;
            parameters[5].Value = model.CSCreateID;
            parameters[6].Value = model.CSCreateDate;
            parameters[7].Value = model.CSDueID;
            parameters[8].Value = model.CSDueDate;
            parameters[9].Value = model.CSDeal;
            parameters[10].Value = model.CSDealDate;
            parameters[11].Value = model.CSResult;
            parameters[12].Value = model.CSSatisfy;
            parameters[13].Value = model.CSID;

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
        public bool UpdateTwo(Maticsoft.Model.CustomServices model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CustomServices set ");
          
            strSql.Append("CSState=@CSState,");
            strSql.Append("CSDealDate=@CSDealDate,");
            strSql.Append("CSDeal=@CSDeal");
         
            strSql.Append(" where CSID=@CSID");
            SqlParameter[] parameters = {
              
               
                    new SqlParameter("@CSState", SqlDbType.Int,4),
                     new SqlParameter("@CSDealDate", SqlDbType.DateTime),
                    new SqlParameter("@CSDeal", SqlDbType.NVarChar,500),
     
                    new SqlParameter("@CSID", SqlDbType.Int,4)};
          
            parameters[0].Value = model.CSState;
            parameters[1].Value = model.CSDealDate;
            parameters[2].Value = model.CSDeal;
            parameters[3].Value = model.CSID;

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
        public bool UpdateFoure(Maticsoft.Model.CustomServices model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CustomServices set ");

            strSql.Append("CSState=4,");
            strSql.Append("CSResult=@CSResult,");
            strSql.Append("CSSatisfy=@CSSatisfy");

            strSql.Append(" where CSID=@CSID");
            SqlParameter[] parameters = {


                    new SqlParameter("@CSState", SqlDbType.Int,4),
                     new SqlParameter("@CSResult", SqlDbType.NVarChar,500),
                    new SqlParameter("@CSSatisfy",SqlDbType.Int,4 ),

                    new SqlParameter("@CSID", SqlDbType.Int,4)};

            parameters[0].Value = model.CSState;
            parameters[1].Value = model.CSResult;
            parameters[2].Value = model.CSSatisfy;
            parameters[3].Value = model.CSID;

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
        public bool UpdateOne(int CSID,int CSDueID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CustomServices set ");

            strSql.Append("CSState=2,");

            strSql.Append("CSDueID=@CSDueID,");
            strSql.Append("CSDueDate=@CSDueDate");

            strSql.Append(" where CSID=@CSID");
            SqlParameter[] parameters = {


                    
                   new SqlParameter("@CSDueID", SqlDbType.Int,4),
                    new SqlParameter("@CSDueDate", SqlDbType.DateTime),
                    new SqlParameter("@CSID", SqlDbType.Int,4)};

            parameters[0].Value = CSDueID;
            parameters[1].Value =DateTime.Now;
            parameters[2].Value = CSID;

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
        public bool Delete(int CSID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CustomServices ");
            strSql.Append(" where CSID=@CSID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CSID", SqlDbType.Int,4)
            };
            parameters[0].Value = CSID;

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
        public bool DeleteList(string CSIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CustomServices ");
            strSql.Append(" where CSID in (" + CSIDlist + ")  ");
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
        public Maticsoft.Model.CustomServices GetModel(int CSID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CSID,STID,CusID,CSTitle,CSState,CSDesc,CSCreateID,CSCreateDate,CSDueID,CSDueDate,CSDeal,CSDealDate,CSResult,CSSatisfy from CustomServices ");
            strSql.Append(" where CSID=@CSID");
            SqlParameter[] parameters = {
                    new SqlParameter("@CSID", SqlDbType.Int,4)
            };
            parameters[0].Value = CSID;

            Maticsoft.Model.CustomServices model = new Maticsoft.Model.CustomServices();
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
        public Maticsoft.Model.CustomServices DataRowToModel(DataRow row)
        {
            Maticsoft.Model.CustomServices model = new Maticsoft.Model.CustomServices();
            if (row != null)
            {
               
                if (row["CSID"] != null && row["CSID"].ToString() != "")
                {
                    model.CSID = int.Parse(row["CSID"].ToString());
                }
                if (row["STID"] != null && row["STID"].ToString() != "")
                {
                    model.STID = int.Parse(row["STID"].ToString());
                }
                if (row["CusID"] != null)
                {
                    model.CusID = row["CusID"].ToString();
                }
                if (row["CSTitle"] != null)
                {
                    model.CSTitle = row["CSTitle"].ToString();
                }
                if (row["CSState"] != null && row["CSState"].ToString() != "")
                {
                    model.CSState = int.Parse(row["CSState"].ToString());
                }
                if (row["CusName"] != null && row["CusName"].ToString() != "")
                {
                    model.CusName = row["CusName"].ToString();
                }
                if (row["CSDesc"] != null)
                {
                    model.CSDesc = row["CSDesc"].ToString();
                }
                if (row["CSCreateID"] != null && row["CSCreateID"].ToString() != "")
                {
                    model.CSCreateID = int.Parse(row["CSCreateID"].ToString());
                }
                if (row["CSCreateDate"] != null && row["CSCreateDate"].ToString() != "")
                {
                    model.CSCreateDate = DateTime.Parse(row["CSCreateDate"].ToString());
                }
                if (row["CSDueID"] != null && row["CSDueID"].ToString() != "")
                {
                    model.CSDueID = int.Parse(row["CSDueID"].ToString());
                }
                if (row["CSDueDate"] != null && row["CSDueDate"].ToString() != "")
                {
                    model.CSDueDate = DateTime.Parse(row["CSDueDate"].ToString());
                }
                if (row["CSDeal"] != null)
                {
                    model.CSDeal = row["CSDeal"].ToString();
                }
                if (row["CSDealDate"] != null && row["CSDealDate"].ToString() != "")
                {
                    model.CSDealDate = DateTime.Parse(row["CSDealDate"].ToString());
                }
                if (row["CSResult"] != null)
                {
                    model.CSResult = row["CSResult"].ToString();
                }
                if (row["CSSatisfy"] != null && row["CSSatisfy"].ToString() != "")
                {
                    model.CSSatisfy = int.Parse(row["CSSatisfy"].ToString());
                }
                if (row["STName"] != null && row["STName"].ToString() != "")
                {
                    model.STName = row["STName"].ToString();
                }

             
                if (row["UserName"] != null && row["UserName"].ToString() != "")
                {
                    model.UserName = row["UserName"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,string wheretwo,int pagesize,int pageindex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select top {0}* from CustomServices a inner join ServiceType c  on a.STID=c.STID inner join  Customers d on a.CusID=d.CusID  INNER JOIN Users b on a.CSCreateID = b.UserID  where CSID NOT IN ", pagesize);

            if (wheretwo.Trim() != "")
            {
                strSql.AppendFormat("  ( select  top ( {0} * ({1}-1)) CSID  from CustomServices a inner join ServiceType c  on a.STID=c.STID inner join  Customers d on a.CusID=d.CusID INNER JOIN Users b on a.CSCreateID = b.UserID  where 1 >0 {2} order by CSID desc)", pagesize, pageindex, wheretwo);
            }
            else {
                strSql.AppendFormat("  ( select  top ( {0} * ({1}-1)) CSID  from CustomServices a inner join ServiceType c  on a.STID=c.STID inner join  Customers d on a.CusID=d.CusID INNER JOIN Users b on a.CSCreateID = b.UserID  where 1 >0  order by CSID desc)", pagesize, pageindex);
            }
            if (strWhere.Trim() != "")
            {
                strSql.Append("" + strWhere + "  order by CSID desc");
            }
            else
            {
                strSql.Append("order by CSID desc");
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询功能
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllBook(Model.CustomServices b)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select * from CustomServices a
   inner join Users b on a.CSDueID =b.UserID 
 
  inner join ServiceType c  on a.STID=c.STID
  
  inner join Customers d on a.CusID=d.CusID  INNER JOIN Users b on a.CSCreateID = b.UserID  where 1>0");
            if (!string.IsNullOrEmpty(b.CusName))
            {

                strSql.AppendFormat(" and d.CusName like '%{0}%'", b.CusName);
            }

            if (b.STID > 0)
            {
                strSql.Append(" and a.STID = '" + b.STID + "'");
            }
            if (b.ChanDueMan > 0)
            {
                strSql.Append(" and d.CSCreateID = '" + b.CSCreateID + "'");
            }

            return DBUtility.DbHelperSQL.Query(strSql.ToString());
        }


        /// 
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
            strSql.Append(" CSID,STID,CusID,CSTitle,CSState,CSDesc,CSCreateID,CSCreateDate,CSDueID,CSDueDate,CSDeal,CSDealDate,CSResult,CSSatisfy ");
            strSql.Append(" FROM CustomServices ");
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
            strSql.Append("select count(1) FROM CustomServices ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCountTwo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CustomServices a inner join ServiceType c  on a.STID=c.STID inner join  Customers d on a.CusID=d.CusID ");
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
                strSql.Append("order by T.CSID desc");
            }
            strSql.Append(")AS Row, T.*  from CustomServices T ");
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
			parameters[0].Value = "CustomServices";
			parameters[1].Value = "CSID";
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

