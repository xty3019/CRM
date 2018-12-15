using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Maticsoft.Web.WebService
{
    /// <summary>
    /// TypeWebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class TypeWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //删除
        [WebMethod]
        public int DeleteType(int STID)
        {
            BLL.ServiceType book = new BLL.ServiceType();
            if (book.Delete(STID))
            {
                return 1;
            }
            else return 0;
        }
 

        /// <summary>
        /// 查询显示
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
      [WebMethod]
            public List<Maticsoft.Model.CustomServices> GetAllBook(Maticsoft.Model.CustomServices book)
            {
                Maticsoft.BLL.CustomServices b = new Maticsoft.BLL.CustomServices();
                return b.GetAllBook(book);
            }


        /// <summary>
        /// 查询显示数据类型
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Maticsoft.Model.ServiceType> SelecTtype(Maticsoft.Model.ServiceType book)
        {
            Maticsoft.BLL.ServiceType b = new Maticsoft.BLL.ServiceType();
            return b.SelectTy(book);
        }
        //修改服务
        [WebMethod]
        public bool Update(Model.ServiceType tomers)
        {
            BLL.ServiceType bookinfoBLL = new BLL.ServiceType();

            return bookinfoBLL.Update(tomers);
        }

    }
}
