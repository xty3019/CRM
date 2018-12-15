using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
namespace Maticsoft.Web.WebService
{
    /// <summary>
    /// LoginWebServer 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
     [System.Web.Script.Services.ScriptService]
    public class LoginWebServer : System.Web.Services.WebService
    {

        [WebMethod]
        public int LoginUser(string name,string pwd)
        {
            try
            {
                int i = new BLL.Users().GetUserLogin(name, pwd);
                return i;

            }
            catch(Exception) {
                return 0;
            }
           
        }
    }
}
