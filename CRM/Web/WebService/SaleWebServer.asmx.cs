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
    /// SaleWebServer 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class SaleWebServer : System.Web.Services.WebService
    {
        /// <summary>
        /// 得到所有销售机会表数据
        /// </summary>
        [WebMethod]
       
        public void GetAllChan()

        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string size = Context.Request.QueryString["limit"];//数量
            string index = Context.Request.QueryString["page"];//页码
            int id = Convert.ToInt32(Context.Request.QueryString["id"]);//用户ID
            int roleone = new BLL.Chances().SelectRole("RoleName='销售总管'");//得到销售经理的角色编号
            int roletwo= new BLL.Chances().SelectRole("RoleName='客户经理'");//得到客户经理的角色编号
            int userroleid = new BLL.Chances().GetUserRoleID("UserID="+id);//根据用户ID查找出用户角色编号
            Model.Chances model = new BLL.Chances().GetModel(id);
            List<Maticsoft.Model.Chances> list = new List<Model.Chances>();
            int count = 0;
            if (userroleid == roleone) {
                list= new BLL.Chances().GetModelList("","", Convert.ToInt32(index), Convert.ToInt32(size));
                count = new BLL.Chances().GetRecordCount("");
            } else if(userroleid==roletwo)
            {
                list = new BLL.Chances().GetModelList(" and ChanCreateMan = "+id,"", Convert.ToInt32(index), Convert.ToInt32(size));
                count = new BLL.Chances().GetRecordCount(" and ChanCreateMan="+id);
            }

           
          
            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", count);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);

        }

        /// <summary>
        /// 得到已经分配的销售机会数据
        /// </summary>
        [WebMethod]

        public void GetChancesByChanState() {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string size = Context.Request.QueryString["limit"];//数量
            string index = Context.Request.QueryString["page"];//页码
            List<Maticsoft.Model.Chances> list = new List<Model.Chances>();
            list = new BLL.Chances().GetModelList("and ChanState not in(1)","", Convert.ToInt32(index), Convert.ToInt32(size));
           int  count = new BLL.Chances().GetRecordCount("and ChanState not in(1)");

            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", count);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);
        }

        [WebMethod]

        public void GetAllChancesByNo() {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string size = Context.Request.QueryString["limit"];//数量
            string index = Context.Request.QueryString["page"];//页码
            List<Maticsoft.Model.Chances> list = new List<Model.Chances>();
            list = new BLL.Chances().GetModelList("and ChanState =1", " ChanState =1", Convert.ToInt32(index), Convert.ToInt32(size));
            int count = new BLL.Chances().GetRecordCount("and ChanState = 1");

            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", count);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        [WebMethod]
        
        public void DeleteMsg(int id) {
            bool i = new BLL.Chances().Delete(id);
            if (i)
            {
                JavaScriptSerializer json = new JavaScriptSerializer();
              
                Context.Response.Write(json.Serialize(1));
            }
            else {

                JavaScriptSerializer json = new JavaScriptSerializer();

                Context.Response.Write(json.Serialize(0));
            }
        }
        [WebMethod]
        public void GetRoleID(int uid) {
            JavaScriptSerializer json = new JavaScriptSerializer();
            int userroleid = new BLL.Chances().GetUserRoleID("UserID=" + uid);//根据用户ID查找出用户角色编号
            if (userroleid > 0)
            {
                Context.Response.Write(json.Serialize(userroleid));
            }
            else {
                Context.Response.Write(json.Serialize(0));
            }
        }


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lxr"></param>
        /// <param name="type"></param>
        [WebMethod]
        public void SelectMsg(string name, string lxr, int type) {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(name)) {
                str.AppendFormat(" and ChanName like '%{0}%'",name);
            }
            if (!string.IsNullOrEmpty(lxr)) {
                str.AppendFormat("and ChanLinkMan like '%{0}%'",lxr);
            }
            if (type>0){
                str.AppendFormat("and ChanState ='{0}'",type);
            }
            str.Append("and ChanState not in(1)");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string size = Context.Request.QueryString["limit"];//数量
            string index = Context.Request.QueryString["page"];//页码
            string id = Context.Request.QueryString["id"];
            List<Maticsoft.Model.Chances> list = new BLL.Chances().GetModelList(str.ToString(),"  1>0  "+str.ToString(), Convert.ToInt32(index), Convert.ToInt32(size));
            int count = new BLL.Chances().GetRecordCount(str.ToString());
            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", count);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);
        }


        /// <summary>
        /// 添加销售机会
        /// </summary>
        /// <param name="ChanName"></param>
        /// <param name="ChanRate"></param>
        /// <param name="ChanLinkMan"></param>
        /// <param name="ChanLinkTel"></param>
        /// <param name="ChanTitle"></param>
        /// <param name="ChanDesc"></param>
        /// <param name="ChanCreateMan"></param>
        [WebMethod]
        public void Bab(string ChanName, int ChanRate, string ChanLinkMan,string ChanLinkTel,string ChanTitle,string ChanDesc,int ChanCreateMan) {
            Maticsoft.Model.Chances model = new Model.Chances {
                  ChanName=ChanName,
                  ChanRate=ChanRate,
                  ChanLinkMan=ChanLinkMan,
                  ChanLinkTel=ChanLinkTel,
                  ChanTitle=ChanTitle,
                  ChanDesc=ChanDesc,
                  ChanCreateMan=ChanCreateMan ,
                  ChanState=1
            };
            try
            {
                JavaScriptSerializer json = new JavaScriptSerializer();
                int i = new BLL.Chances().Add(model);
                Context.Response.Write(json.Serialize(1));
            }
            catch (Exception) {
                return;
                throw;
            }
           
           
            }

        [WebMethod]
        public void update(int ChanID) {
            try
            {
                
                JavaScriptSerializer json = new JavaScriptSerializer();
                Maticsoft.Model.Chances list = new BLL.Chances().GetModel(ChanID);
                Context.Response.Write(json.Serialize(list));

            }
            catch (Exception) {
                return;
                throw;
            }
        }


        [WebMethod]

        public void UpdateChances(int ChanID,string ChanName, int ChanRate, string ChanLinkMan, string ChanLinkTel, string ChanTitle, string ChanDesc, int ChanCreateMan) {
            JavaScriptSerializer json = new JavaScriptSerializer();
            Model.Chances models = new Model.Chances
            {
                  ChanID=ChanID,
                  ChanName=ChanName,
                  ChanRate=ChanRate,
                  ChanLinkMan=ChanLinkMan,
                  ChanLinkTel=ChanLinkTel,
                  ChanTitle=ChanTitle,
                  ChanCreateMan=ChanCreateMan,
                  ChanDesc=ChanDesc,
                  ChanState=1
            };
            try
            {
                bool up = new BLL.Chances().Update(models);
                if (up)
                {
                    Context.Response.Write(json.Serialize(1));
                }
                else {
                    Context.Response.Write(json.Serialize(0));
                }
            }
            catch (Exception) {

            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lxr"></param>
        /// <param name="type"></param>
        [WebMethod]
        public void SelectMsgs(string name, string lxr,string cjr)
        {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(name))
            {
                str.AppendFormat(" and ChanName like '%{0}%'", name);
            }
            if (!string.IsNullOrEmpty(lxr))
            {
                str.AppendFormat("and ChanLinkMan like '%{0}%'", lxr);
            }
            if (!string.IsNullOrEmpty(cjr)) {
                str.AppendFormat(" and ChanCreateMan={0}",cjr);
            }
         
            str.Append("and ChanState =1");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string size = Context.Request.QueryString["limit"];//数量
            string index = Context.Request.QueryString["page"];//页码
            string id = Context.Request.QueryString["id"];
            List<Maticsoft.Model.Chances> list = new BLL.Chances().GetModelList(str.ToString(), "  1>0  " + str.ToString(), Convert.ToInt32(index), Convert.ToInt32(size));
            int count = new BLL.Chances().GetRecordCount(str.ToString());
            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", count);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);
        }

        /// <summary>
        /// 查询出所有用户(即指派人)
        /// </summary>
        /// <returns></returns>
        [WebMethod]
       
        public List<Model.Users> SelectZhiPairen() {
            List<Model.Users> list = new BLL.Users().GetModelListAll(" a.RoleID=(select RoleID from Role where RoleName='客户经理')");
            return list;
        }

        [WebMethod]
        /// <summary>
        /// 分配客户给指派人
        /// </summary>
        /// <param name="ChanID"></param>
        /// <param name="ChanDueMan"></param>
        public void AddChanDueMan(int ChanID, int ChanDueMan) {
            JavaScriptSerializer json = new JavaScriptSerializer();
            Model.Chances model = new Model.Chances
            {
                ChanID = ChanID,
                ChanDueDate = DateTime.Now,
                 ChanState=2,
                  ChanDueMan=ChanDueMan
            };
            bool check = new BLL.Chances().SetChanDueMan(model);
            if (check)
            {
                Context.Response.Write(1);
            }
            else {
                Context.Response.Write(0);
            }
        }

        /// <summary>
        /// 添加客户计划信息
        /// </summary>
        /// <param name="ChanID"></param>
        [WebMethod]
       
        public void GetPlanByChanID(int ChanID) {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("a.ChanID='{0}'", ChanID);
            Dictionary<string, object> dic = new Dictionary<string, object>();
            List<Maticsoft.Model.Plans> list = new BLL.Plans().GetModelList(str.ToString());
            int count = new BLL.Plans().GetRecordCount(str.ToString());
            dic.Add("code", "0");
            dic.Add("msg", "");
            dic.Add("count", 10);
            dic.Add("data", list);
            JavaScriptSerializer json = new JavaScriptSerializer();
            string j = json.Serialize(dic);
            Context.Response.Write(j);
        }

        /// <summary>
        /// 添加客户计划信息
        /// </summary>
        /// <param name="ChanID"></param>
        /// <param name="PlanContent"></param>
        /// <param name="PlanResult"></param>
        [WebMethod]
        public void AddPlans(int ChanID, string PlanContent, string PlanResult) {
            int[] a = new int[4];
            a = GetRandomByGuid(a);
            string bh = "PN" + DateTime.Now.ToString("yyyyMMdd");
            for (int j = 0; j < a.Length; j++)
            {
                bh += a[j];
            }
            Model.Plans model = new Model.Plans {
                ChanID = ChanID,
                PlanContent = PlanContent,
                PlanDate = DateTime.Now,
                PlanResult = PlanResult,
                PlanResultDate = DateTime.Now,
                PlanID=bh
            };
            bool check = new BLL.Plans().Add(model);
          
        }

        /// <summary>
        /// 修改销售机会为失败
        /// </summary>
        /// <param name="ChanID"></param>
        /// <param name="ChanError"></param>
        [WebMethod]
        public void UpdateChancesError(int ChanID, string ChanError) {
            JavaScriptSerializer json = new JavaScriptSerializer();
            Model.Chances model = new Model.Chances
            {
                ChanID = ChanID,
                ChanState = 4,
                ChanError=ChanError
              
            };
            bool check = new BLL.Chances().SetChancesError(model);
            if (check)
            {
                Context.Response.Write(1);
            }
            else
            {
                Context.Response.Write(0);
            }
        }


        /// <summary>
        /// 修改销售机会为成功
        /// </summary>
        /// <param name="ChanID"></param>
        /// <param name="ChanError"></param>
        [WebMethod]
        public void UpdateChancesOK(int ChanID)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            

            Model.Chances model = new Model.Chances
            {
                ChanID = ChanID,
                ChanState = 3,
       
            };
            int[] a = new int[4];
            a = GetRandomByGuid(a);


            string bh = "KH" + DateTime.Now.ToString("yyyyMMdd");
            for (int j = 0; j < a.Length; j++)
            {
                bh += a[j];
            }

            Model.Chances add = new BLL.Chances().GetModel(ChanID);
            Model.Customers cus = new Model.Customers
            {
                CusName = add.ChanName,
                CusID = bh,
                UserID = add.ChanDueMan,
                 CusState=1
            };
         
            bool check = new BLL.Chances().SetChanceSuccess(model);
            if (check)
            {
                bool i = new BLL.Customers().Add(cus);
                if (i) {
                    Context.Response.Write(0);
                }
            }
            else
            {
                Context.Response.Write(0);
            }
        }
        public static int[] GetRandomByGuid(int[] array)
        {
            int len = array.Length;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < len; i++)
            {
                array[i] = random.Next(0, len);
            }
            return array;
            //Print(array);// 输出生成的随机数
        }

        [WebMethod]
        public void SelectAllUser() {
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<Model.Users> list = new BLL.Users().GetModelListAll("  a.RoleID=(select RoleID from Role where RoleName='客户经理')");
            Context.Response.Write(json.Serialize(list));

        }


        [WebMethod]
        public void SelectAllUserTwo()
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<Model.Users> list = new BLL.Users().GetModelListAll("");
            Context.Response.Write(json.Serialize(list));

        }
    }
}
