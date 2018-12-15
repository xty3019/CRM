using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
namespace Maticsoft.Web.Customer.WebSever
{
    /// <summary>
    /// CustomerPage 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class CustomerPage : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        /// <summary>
        /// 加载数据和搜索
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Model.Customers> SelectAllCustomers(Model.Customers customers,int size,int pageindex)
        {
            StringBuilder str = new StringBuilder();
           
            if (!string.IsNullOrEmpty(customers.CusName)) {
                str.AppendFormat(" and a.CusName like '%{0}%' ",customers.CusName);
            }
            if (!string.IsNullOrEmpty(customers.UserName)) {
                str.AppendFormat(" and b.UserName like '%{0}%' ", customers.UserName);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(customers.CusDate))) {
                var cusdate = Convert.ToDateTime(customers.CusDate).ToString("yyyy-MM-dd");
                str.AppendFormat(" and convert(varchar(10),CusDate,120)='{0}' ", cusdate);
            }
          
            BLL.Customers bookinfoBLL = new BLL.Customers();

            return bookinfoBLL.GetModelList(str.ToString(),"1>0"+str.ToString(),size,pageindex);

        }

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int  GetCount(string CusName,string UserName,string CusDate)
        {
            StringBuilder str = new StringBuilder();
         
            if (!string.IsNullOrEmpty(CusName))
            {
                str.AppendFormat(" and a.CusName like '{0}' ",CusName);
            }
            if (!string.IsNullOrEmpty(UserName))
            {
                str.AppendFormat(" and b.UserName like '{0}' ", UserName);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(CusDate)))
            {
                var cusdate = Convert.ToDateTime(CusDate).ToString("yyyy-MM-dd");
                str.AppendFormat(" and convert(varchar(10),CusDate,120)='{0}' ", cusdate);
            }

            BLL.Customers bookinfoBLL = new BLL.Customers();

            return bookinfoBLL.GetRecordCountTwo("1>0"+str.ToString());

        }

       
        [WebMethod]
        public List<Model.Customers> UpdateSelectWhere(string ID)
        {
            BLL.Customers bookinfoBLL = new BLL.Customers();

            return bookinfoBLL.GetModelListTwo(" a.CusID ='" + ID+"'");
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        [WebMethod]
        public bool Update(Model.Customers customers)
        {
            BLL.Customers bookinfoBLL = new BLL.Customers();

            return bookinfoBLL.Update(customers);
        }

    }
}
