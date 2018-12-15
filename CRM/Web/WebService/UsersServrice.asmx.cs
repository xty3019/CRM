using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Text;
namespace Maticsoft.Web.WebService
{
    /// <summary>
    /// UsersServrice 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
     [System.Web.Script.Services.ScriptService]
    public class UsersServrice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// 得到所有销售机会表数据
        /// </summary>
        [WebMethod]

        public void GetAllUsers()

        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string size = Context.Request.QueryString["limit"];//数量
            string index = Context.Request.QueryString["page"];//页码
          
           
            List<Maticsoft.Model.Users> list = new List<Model.Users>();
            int count = new BLL.Users().GetRecordCount("");

            list = new BLL.Users().GetModelList("", "", Convert.ToInt32(size), Convert.ToInt32(index));
            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", count);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);

        }

        /// <summary>
        /// 查询用户
        /// </summary>
        [WebMethod]
        public void SelectUser(string name,int type) {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            StringBuilder str = new StringBuilder();
            string size = Context.Request.QueryString["limit"];//数量
            string index = Context.Request.QueryString["page"];//页码
            if (!string.IsNullOrEmpty(name)) {
                str.AppendFormat(" and UserLName like '%{0}%'",name);
            }
            if (type > 0) {
                str.AppendFormat(" and a.RoleID ={0}",type);
            }
            List<Maticsoft.Model.Users> list = new List<Model.Users>();
            int count = new BLL.Users().GetRecordCount("1>0"+str.ToString());

            list = new BLL.Users().GetModelList(str.ToString(), "1>0"+str.ToString(), Convert.ToInt32(size), Convert.ToInt32(index));
            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", count);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        [WebMethod]
        public void DeleteUser(int id) {
            JavaScriptSerializer json = new JavaScriptSerializer();
            bool c = new BLL.Users().Delete(id);
            if (c)
            {
                Context.Response.Write(1);
            }
            else {
                Context.Response.Write(0);
            }
        }

        [WebMethod]
        public  void GetUserOne(int uid)
        {
           
                JavaScriptSerializer json = new JavaScriptSerializer();
                Maticsoft.Model.Users list = new BLL.Users().GetModel(uid);
               Context.Response.Write(json.Serialize(list));
              

           
        }

        [WebMethod]
        public void UpdateUser(int UserID,string UserLName,string UserLPWD,string UserName,int RoleID) {
            JavaScriptSerializer json = new JavaScriptSerializer();
            Model.Users u = new Model.Users {
                 RoleID=RoleID,
                   UserID=UserID,
                    UserLName=UserLName,
                     UserLPWD=UserLPWD,
                      UserName=UserName

            };

            bool c = new BLL.Users().Update(u);
            if (c)
            {
                Context.Response.Write(json.Serialize(1));
            }
            else {
                Context.Response.Write(json.Serialize(0));
            }
        }


        [WebMethod]
        public void Add(string UserLName, string UserLPWD, string UserName, int RoleID)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            Model.Users u = new Model.Users
            {
                RoleID = RoleID,
               
                UserLName = UserLName,
                UserLPWD = UserLPWD,
                UserName = UserName

            };

            int c = new BLL.Users().Add(u);
            if (c>0)
            {
                Context.Response.Write(json.Serialize(c));
            }
            else
            {
                Context.Response.Write(json.Serialize(0));
            }
        }
    }
}
