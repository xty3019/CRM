using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Maticsoft.Web.Customer.WebSever
{
    /// <summary>
    /// LinkMans 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class LinkMans : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Model.LinkMans> SelectAllLinkMans(string ID)
        {
            BLL.LinkMans LinkMans = new BLL.LinkMans();
            return LinkMans.GetModelList("LinkMans.CusID='" + ID+"'");

        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Model.LinkMans> SelectAllLinkMansByID(string ID)
        {
            BLL.LinkMans LinkMans = new BLL.LinkMans();
            return LinkMans.GetModelList("LinkMans.LMID='" + ID + "'");

        }
        [WebMethod]
        //LinkManAdd.htm添加
        public int Add(Model.LinkMans model)
        {

            BLL.LinkMans linkBLL = new BLL.LinkMans();
            return linkBLL.Add(model);

        }
        [WebMethod]
        public bool update(Model.LinkMans model)
        {

            BLL.LinkMans linkBLL = new BLL.LinkMans();
            return linkBLL.Update(model);

        }
        [WebMethod]
        public bool delete(int LMID)
        {

            BLL.LinkMans linkBLL = new BLL.LinkMans();
            return linkBLL.Delete(LMID);

        }
    }
}
