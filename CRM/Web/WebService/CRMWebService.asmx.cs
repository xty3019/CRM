using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;




namespace Maticsoft.Web.WebService
{
    /// <summary>
    /// CRMWebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class CRMWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //添加类型

        [WebMethod]
        public int Addservices(Model.ServiceType services)
        {
            BLL.ServiceType b = new BLL.ServiceType();
            return b.Add(services);
        }
        //加载下拉框
        [WebMethod]
        public List<Model.ServiceType> GetAllType()
        {

            BLL.ServiceType bt = new BLL.ServiceType();
            return bt.GetModelList("");
                
           
        }
        [WebMethod]
        public int UpdateCuMan(int CSID, int CSDueID) {
           
            bool c = new BLL.CustomServices().UpdateOne( CSID,  CSDueID);
            if (c)
            {
                return 1;
            }
            else {
                return 0;
            }
        }
        //显示所有数据
        [WebMethod]
        public List<Model.CustomServices> SlectAllMsg(string CusName, int STID, int size, int pageindex)
        {
            StringBuilder str = new StringBuilder();

            if (!string.IsNullOrEmpty(CusName))
            {
                str.AppendFormat(" and d.CusName like '%{0}%' ", CusName);
            }
            if (STID > 0)
            {
                str.AppendFormat(" and a.STID  ={0} ", STID);
            }

            str.Append(" and CSState=1");
            BLL.Customers bookinfoBLL = new BLL.Customers();

            BLL.CustomServices bllbookinfo = new BLL.CustomServices();
            List<Model.CustomServices> list= bllbookinfo.GetModelList(str.ToString(),str.ToString(),size,pageindex);

            return list;
        }


        //显示所有数据
        [WebMethod]
        public List<Model.CustomServices> SlectAllMsgTwo(int size, int pageindex)
        {
            StringBuilder str = new StringBuilder();



            str.Append("and CSState=2");

            BLL.Customers bookinfoBLL = new BLL.Customers();

            BLL.CustomServices bllbookinfo = new BLL.CustomServices();
            List<Model.CustomServices> list = bllbookinfo.GetModelList(str.ToString(), str.ToString(), size, pageindex);

            return list;
        }

        //显示所有数据
        [WebMethod]
        public List<Model.CustomServices> SelectAllThree(string CusName, int STID, string LMName,int size, int pageindex)
        {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(CusName))
            {
                str.AppendFormat(" and d.CusName like '%{0}%'", CusName);
            }
            if (STID > 0)
            {
                str.AppendFormat(" and a.STID = {0}", STID);
            }
            if (!string.IsNullOrEmpty(LMName))
            {
                str.AppendFormat(" and b.UserName like '%{0}%'", LMName);
            }
            str.Append("and CSState=4");


            BLL.CustomServices bllbookinfo = new BLL.CustomServices();
            List<Model.CustomServices> list = bllbookinfo.GetModelList(str.ToString(), str.ToString(), size, pageindex);

            return list;
        }

        [WebMethod]
        public List<Model.CustomServices> SelectAllFore(int size, int pageindex)
        {
            StringBuilder str = new StringBuilder();



            str.Append("and CSState=3");

            BLL.Customers bookinfoBLL = new BLL.Customers();

            BLL.CustomServices bllbookinfo = new BLL.CustomServices();
            List<Model.CustomServices> list = bllbookinfo.GetModelList(str.ToString(), str.ToString(), size, pageindex);

            return list;
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int GetCount(string CusName, int STID)
        {
            

            StringBuilder str = new StringBuilder();

            if (!string.IsNullOrEmpty(CusName))
            {
                str.AppendFormat(" and d.CusName like '%{0}%' ", CusName);
            }
            if (STID > 0)
            {
                str.AppendFormat(" and a.STID  ={0} ", STID);
            }
            str.Append("CSState=1");
            BLL.CustomServices bookinfoBLL = new BLL.CustomServices();

            return bookinfoBLL.GetRecordCountTwo(" 1 > 0" + str.ToString());

        }


         [WebMethod]
        public int GetCountFore(string CusName, int STID, string UserName)
        {

            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(CusName))
            {
                str.AppendFormat(" and d.CusName like '%{0}%'", CusName);
            }
            if (STID > 0)
            {
                str.AppendFormat(" and a.STID = {0}", STID);
            }
            if (!string.IsNullOrEmpty(UserName))
            {
                str.AppendFormat(" and b.UserName like '%{0}%'", UserName);
            }
            str.Append("and CSState=4");

            BLL.CustomServices bookinfoBLL = new BLL.CustomServices();

            return bookinfoBLL.GetRecordCountTwo("1>0" + str.ToString());

        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int GetCountTwo()
        {


            StringBuilder str = new StringBuilder();

            str.Append(" AND CSState=2");

            BLL.CustomServices bookinfoBLL = new BLL.CustomServices();

            return bookinfoBLL.GetRecordCountTwo("1>0" + str.ToString());

        }
        [WebMethod]
        public int GetCountThree()
        {


            StringBuilder str = new StringBuilder();

            str.Append(" AND CSState=3");

            BLL.CustomServices bookinfoBLL = new BLL.CustomServices();

            return bookinfoBLL.GetRecordCountTwo("1>0" + str.ToString());

        }

        //添加
        [WebMethod]
        public int AddOneBook(Model.CustomServices book)
        {
           
            BLL.CustomServices b = new BLL.CustomServices();
            return b.Add(book);
        }

        [WebMethod]
        //显示服务类型
        public List<Model.ServiceType> selectAlltype()
        {

            BLL.ServiceType bllbookinfo = new BLL.ServiceType();
            List<Model.ServiceType> list = bllbookinfo.GetModelList("");

            return list;
        }
        //删除服务

        public bool DeleteType(int ID)
        {
            BLL.ServiceType bookinfoBLL = new BLL.ServiceType();
            return bookinfoBLL.Delete(ID);
        }

        //显示所有数据
        [WebMethod]
        public List<Model.CustomServices> SelectMsgByCSID(int cusid)
        {
            StringBuilder str = new StringBuilder();
            str.Append(" and a.CSID="+cusid);

            BLL.CustomServices bllbookinfo = new BLL.CustomServices();
            List<Model.CustomServices> list = bllbookinfo.GetModelList(str.ToString(),str.ToString(),1,1);

            return list;
        }
        //添加服务处理
        [WebMethod]
        public int AddResult(Model.CustomServices book)
        {
            book.CSDealDate = DateTime.Now;
            BLL.CustomServices b = new BLL.CustomServices();
           bool c= b.
                UpdateTwo(book);
            if (c)
            {
                return 1;
            }
            else {
                return 0;
            }
        }
        [WebMethod]
        public int UPdateStateFoure(Model.CustomServices book) {

          
            BLL.CustomServices b = new BLL.CustomServices();
            bool c = b.
                 UpdateFoure(book);
            if (c)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        [WebMethod]
        public List<Maticsoft.Model.Customers> GetAllCus() {
          
        
            List<Maticsoft.Model.Customers> list = new List<Model.Customers>();
            list = new BLL.Customers().GetModelListTwo("");
            return list;
        }
    }
}
