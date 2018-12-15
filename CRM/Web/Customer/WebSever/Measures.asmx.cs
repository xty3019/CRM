using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Maticsoft.Web.Customer.WebSever
{
    /// <summary>
    /// Measures 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Measures : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        //显示数据
        public List<Model.Measures> SelectAllMeasures(int ID)
        {
            BLL.Measures Measures = new BLL.Measures();
            return Measures.GetModelList("a.CLID =" + ID);

        }


        [WebMethod]
        public List<Model.Measures> ShowOld(int mid) {
            BLL.Measures Measures = new BLL.Measures();
            return Measures.GetModelList("a.MeID =" + mid);
        }
        [WebMethod]
        public int Update(int mid,string desc) {
            bool check = new BLL.Measures().UpdateTwo(mid,desc);
            if (check)
            {
                return 1;
            }
            else {
                return 0;
            }
        }
    }
}
