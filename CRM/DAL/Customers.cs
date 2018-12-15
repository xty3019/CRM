using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Customers
	/// </summary>
	public partial class Customers
	{
		public Customers()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string CusID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Customers");
            strSql.Append(" where CusID=@CusID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14)           };
            parameters[0].Value = CusID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.Customers model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Customers(");
            strSql.Append("CusID,UserID,CusName,CusAddress,CusZip,CusFax,CusWebsite,CusLicenceNo,CusChieftain,CusBankroll,CusTurnover,CusBank,CusBankNo,CusLocalTaxNo,CusNationalTaxNo,CusDate,CusState)");
            strSql.Append(" values (");
            strSql.Append("@CusID,@UserID,@CusName,@CusAddress,@CusZip,@CusFax,@CusWebsite,@CusLicenceNo,@CusChieftain,@CusBankroll,@CusTurnover,@CusBank,@CusBankNo,@CusLocalTaxNo,@CusNationalTaxNo,@CusDate,@CusState)");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14),
                    new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@CusName", SqlDbType.NVarChar,50),
                    new SqlParameter("@CusAddress", SqlDbType.NVarChar,100),
                    new SqlParameter("@CusZip", SqlDbType.VarChar,50),
                    new SqlParameter("@CusFax", SqlDbType.VarChar,50),
                    new SqlParameter("@CusWebsite", SqlDbType.VarChar,100),
                    new SqlParameter("@CusLicenceNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusChieftain", SqlDbType.NVarChar,50),
                    new SqlParameter("@CusBankroll", SqlDbType.Int,4),
                    new SqlParameter("@CusTurnover", SqlDbType.Int,4),
                    new SqlParameter("@CusBank", SqlDbType.NVarChar,50),
                    new SqlParameter("@CusBankNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusLocalTaxNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusNationalTaxNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusDate", SqlDbType.DateTime),
                    new SqlParameter("@CusState", SqlDbType.Int,4)};
            parameters[0].Value = model.CusID;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.CusName;
            parameters[3].Value = model.CusAddress;
            parameters[4].Value = model.CusZip;
            parameters[5].Value = model.CusFax;
            parameters[6].Value = model.CusWebsite;
            parameters[7].Value = model.CusLicenceNo;
            parameters[8].Value = model.CusChieftain;
            parameters[9].Value = model.CusBankroll;
            parameters[10].Value = model.CusTurnover;
            parameters[11].Value = model.CusBank;
            parameters[12].Value = model.CusBankNo;
            parameters[13].Value = model.CusLocalTaxNo;
            parameters[14].Value = model.CusNationalTaxNo;
            parameters[15].Value = model.CusDate;
            parameters[16].Value = model.CusState;

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
        public bool Update(Maticsoft.Model.Customers model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Customers set ");
            strSql.Append("UserID=@UserID,");
            strSql.Append("CusName=@CusName,");
            strSql.Append("CusAddress=@CusAddress,");
            strSql.Append("CusZip=@CusZip,");
            strSql.Append("CusFax=@CusFax,");
            strSql.Append("CusWebsite=@CusWebsite,");
            strSql.Append("CusLicenceNo=@CusLicenceNo,");
            strSql.Append("CusChieftain=@CusChieftain,");
            strSql.Append("CusBankroll=@CusBankroll,");
            strSql.Append("CusTurnover=@CusTurnover,");
            strSql.Append("CusBank=@CusBank,");
            strSql.Append("CusBankNo=@CusBankNo,");
            strSql.Append("CusLocalTaxNo=@CusLocalTaxNo,");
            strSql.Append("CusNationalTaxNo=@CusNationalTaxNo,");
            strSql.Append("CusDate=@CusDate,");
            strSql.Append("CusState=@CusState");
            strSql.Append(" where CusID=@CusID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@UserID", SqlDbType.Int,4),
                    new SqlParameter("@CusName", SqlDbType.NVarChar,50),
                    new SqlParameter("@CusAddress", SqlDbType.NVarChar,100),
                    new SqlParameter("@CusZip", SqlDbType.VarChar,50),
                    new SqlParameter("@CusFax", SqlDbType.VarChar,50),
                    new SqlParameter("@CusWebsite", SqlDbType.VarChar,100),
                    new SqlParameter("@CusLicenceNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusChieftain", SqlDbType.NVarChar,50),
                    new SqlParameter("@CusBankroll", SqlDbType.Int,4),
                    new SqlParameter("@CusTurnover", SqlDbType.Int,4),
                    new SqlParameter("@CusBank", SqlDbType.NVarChar,50),
                    new SqlParameter("@CusBankNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusLocalTaxNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusNationalTaxNo", SqlDbType.VarChar,50),
                    new SqlParameter("@CusDate", SqlDbType.DateTime),
                    new SqlParameter("@CusState", SqlDbType.Int,4),
                    new SqlParameter("@CusID", SqlDbType.Char,14)};
            parameters[0].Value = model.UserID;
            parameters[1].Value = model.CusName;
            parameters[2].Value = model.CusAddress;
            parameters[3].Value = model.CusZip;
            parameters[4].Value = model.CusFax;
            parameters[5].Value = model.CusWebsite;
            parameters[6].Value = model.CusLicenceNo;
            parameters[7].Value = model.CusChieftain;
            parameters[8].Value = model.CusBankroll;
            parameters[9].Value = model.CusTurnover;
            parameters[10].Value = model.CusBank;
            parameters[11].Value = model.CusBankNo;
            parameters[12].Value = model.CusLocalTaxNo;
            parameters[13].Value = model.CusNationalTaxNo;
            parameters[14].Value = model.CusDate;
            parameters[15].Value = model.CusState;
            parameters[16].Value = model.CusID;

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
        /// 更新客户状态为流失
        /// </summary>
        public bool UpdateOne(String CusID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Customers set ");
           
            strSql.Append("CusState=2");
            strSql.Append(" where CusID=@CusID ");
            SqlParameter[] parameters = {
                
                  
                    new SqlParameter("@CusID", SqlDbType.Char,14)};
       
         
            parameters[0].Value =CusID;

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
        public bool Delete(string CusID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Customers ");
            strSql.Append(" where CusID=@CusID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14)           };
            parameters[0].Value = CusID;

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
        public bool DeleteList(string CusIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Customers ");
            strSql.Append(" where CusID in (" + CusIDlist + ")  ");
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
        public Maticsoft.Model.Customers GetModel(string CusID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CusID,UserID,CusName,CusAddress,CusZip,CusFax,CusWebsite,CusLicenceNo,CusChieftain,CusBankroll,CusTurnover,CusBank,CusBankNo,CusLocalTaxNo,CusNationalTaxNo,CusDate,CusState from Customers ");
            strSql.Append(" where CusID=@CusID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CusID", SqlDbType.Char,14)           };
            parameters[0].Value = CusID;

            Maticsoft.Model.Customers model = new Maticsoft.Model.Customers();
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
        public Maticsoft.Model.Customers DataRowToModel(DataRow row)
        {
            Maticsoft.Model.Customers model = new Maticsoft.Model.Customers();
            if (row != null)
            {
                if (row["CusID"] != null)
                {
                    model.CusID = row["CusID"].ToString();
                }
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(row["UserID"].ToString());
                }
                if (row["CusName"] != null)
                {
                    model.CusName = row["CusName"].ToString();
                }
                if (row["CusAddress"] != null)
                {
                    model.CusAddress = row["CusAddress"].ToString();
                }
                if (row["CusZip"] != null)
                {
                    model.CusZip = row["CusZip"].ToString();
                }
                if (row["CusFax"] != null)
                {
                    model.CusFax = row["CusFax"].ToString();
                }
                if (row["CusWebsite"] != null)
                {
                    model.CusWebsite = row["CusWebsite"].ToString();
                }
                if (row["CusLicenceNo"] != null)
                {
                    model.CusLicenceNo = row["CusLicenceNo"].ToString();
                }
                if (row["CusChieftain"] != null)
                {
                    model.CusChieftain = row["CusChieftain"].ToString();
                }
                if (row["CusBankroll"] != null && row["CusBankroll"].ToString() != "")
                {
                    model.CusBankroll = int.Parse(row["CusBankroll"].ToString());
                }
                if (row["CusTurnover"] != null && row["CusTurnover"].ToString() != "")
                {
                    model.CusTurnover = int.Parse(row["CusTurnover"].ToString());
                }
                if (row["CusBank"] != null)
                {
                    model.CusBank = row["CusBank"].ToString();
                }
                if (row["CusBankNo"] != null)
                {
                    model.CusBankNo = row["CusBankNo"].ToString();
                }
                if (row["CusLocalTaxNo"] != null)
                {
                    model.CusLocalTaxNo = row["CusLocalTaxNo"].ToString();
                }
                if (row["CusNationalTaxNo"] != null)
                {
                    model.CusNationalTaxNo = row["CusNationalTaxNo"].ToString();
                }
                if (row["CusDate"] != null && row["CusDate"].ToString() != "")
                {
                    model.CusDate = DateTime.Parse(row["CusDate"].ToString());
                }
                if (row["CusState"] != null && row["CusState"].ToString() != "")
                {
                    model.CusState = int.Parse(row["CusState"].ToString());
                }
                if (row["UserName"] != null)
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
           
            strSql.AppendFormat("select top {0} * from Customers a inner join Users b on a.UserID = b.UserID  where a.CusID not in ", pagesize);
            if (wheretwo.Trim() != "")
            {
                strSql.AppendFormat("(select top ({0}*({1}-1)) a.CusID from Customers a inner join Users b on a.UserID = b.UserID  where  {2}  order by CusID desc)", pagesize,pageindex,wheretwo);
            }
            else {
                strSql.AppendFormat("(select top ({0}*({1}-1)) a.CusID from Customers a inner join Users b on a.UserID = b.UserID order by CusID desc)", pagesize, pageindex);
            }

            if (strWhere.Trim() != "")
            {
                strSql.Append("" + strWhere + "order by CusID desc");
            }
            else {
                strSql.Append("order by CusID desc");
            }
            return DbHelperSQL.Query(strSql.ToString());


        }

        /// <summary>
        /// 获得数据列表(自建)
        /// </summary>
        public DataSet GetListTwo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select * from Customers a inner join Users b on a.UserID = b.UserID");
            if (strWhere.Trim() != "")
            {
                strSql.Append("  where" + strWhere);
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
            strSql.Append(" CusID,UserID,CusName,CusAddress,CusZip,CusFax,CusWebsite,CusLicenceNo,CusChieftain,CusBankroll,CusTurnover,CusBank,CusBankNo,CusLocalTaxNo,CusNationalTaxNo,CusDate,CusState ");
            strSql.Append(" FROM Customers ");
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
            strSql.Append("select count(1) FROM Customers ");
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
            strSql.Append("select count(1) FROM Customers a inner join Users b  on a.UserID = b.UserID");
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
                strSql.Append("order by T.CusID desc");
            }
            strSql.Append(")AS Row, T.*  from Customers T ");
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
			parameters[0].Value = "Customers";
			parameters[1].Value = "CusID";
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

