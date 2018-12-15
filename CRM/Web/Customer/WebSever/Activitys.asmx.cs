using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Maticsoft.Web.Customer.WebSever
{
    /// <summary>
    /// Activitys 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Activitys : System.Web.Services.WebService
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
        public List<Model.Activitys> SelectAllActivitys(string cusid)
        {
            BLL.Activitys ActivitysBLL = new BLL.Activitys();

            return ActivitysBLL.GetModelList("CusID="+"'"+cusid+"'");

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool Delete(int ID)
        {
            BLL.Activitys ActivitysBLL = new BLL.Activitys();

            return ActivitysBLL.Delete(ID);

        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Model.Activitys> SelectWhereActivitys(int ID)
        {
            BLL.Activitys ActivitysBLL = new BLL.Activitys();

            return ActivitysBLL.GetModelList("ActID="+ID);

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool update(Model.Activitys Activity)
        {
            BLL.Activitys ActivitysBLL = new BLL.Activitys();

            return ActivitysBLL.Update(Activity);

        }
        [WebMethod]
        //添加
        public int Add(Maticsoft.Model.Activitys ActAdd)
        {

            BLL.Activitys actBLL = new BLL.Activitys();
            return actBLL.Add(ActAdd);


        }
    }
}
