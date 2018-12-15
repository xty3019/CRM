using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
namespace Maticsoft.Web.Customer.WebSever
{
    /// <summary>
    /// Lost 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Lost : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        //显示数据
        public List<Model.CustomLosts> SelectAllCustomLosts(int pagesize,int pageindex,Maticsoft.Model.CustomLosts models)
        {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(models.CusName)) {
                str.AppendFormat(" and Customers.CusName like '%{0}%'",models.CusName);
            }
            if (models.CLState > 0) {
                str.AppendFormat(" and CustomLosts.CLState={0}",models.CLState);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(models.CLEnterDate)))
            {
                var CLEnterDate = Convert.ToDateTime(models.CLEnterDate).ToString("yyyy-MM-dd");
                str.AppendFormat(" and convert(varchar(10),CLEnterDate,120)='{0}' ", CLEnterDate);
            }
            BLL.CustomLosts CustomLosts = new BLL.CustomLosts();
            return CustomLosts.GetModelListTwo(str.ToString(),"1>0"+str.ToString(),pagesize,pageindex);

        }
        [WebMethod]

        public int GetCount(Maticsoft.Model.CustomLosts models) {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(models.CusName))
            {
                str.AppendFormat(" and Customers.CusName like '%{0}%'", models.CusName);
            }
            if (models.CLState > 0)
            {
                str.AppendFormat(" and CustomLosts.CLState={0}", models.CLState);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(models.CLEnterDate)))
            {
                var CLEnterDate = Convert.ToDateTime(models.CLEnterDate).ToString("yyyy-MM-dd");
                str.AppendFormat(" and convert(varchar(10),CLEnterDate,120)='{0}' ", CLEnterDate);
            }
        

            return new BLL.CustomLosts().GetRecordCountTwo("1>0" + str.ToString());
        }


        [WebMethod]
        //LostAdd.htm页面添加数据
        public int LostAdd(Maticsoft.Model.Measures lost)
        {
            lost.MeDate = DateTime.Now;
            BLL.Measures lostBLL = new BLL.Measures();
            return lostBLL.Add(lost);

        }

        [WebMethod]
        //LostDispose.htm显示所需要的数据
        public List<Model.Measures> SelectAllMeasures()
        {
            BLL.Measures measuresBLL = new BLL.Measures();
            return measuresBLL.GetModelList("");

        }

        [WebMethod]
        //LostDispose.htm删除
        public bool LostDeleteID(int MeID)
        {
            Maticsoft.BLL.Measures LostDelete = new BLL.Measures();
            return LostDelete.Delete(MeID);

        }



        [WebMethod]

        //LostEnter.htm添加
        public int ClostAdd(Maticsoft.Model.CustomLosts Clost)
        {
            Maticsoft.Model.CustomLosts list = new BLL.CustomLosts().GetModel(Clost.CLID);
            BLL.CustomLosts ClostBLL = new BLL.CustomLosts();
            //修改客户状态为2 即流失
            int success = 0;
            bool check2= ClostBLL.ClostAdd(Clost);//修改流失措施表为确认流失
            if (check2) {
                bool check = new BLL.Customers().UpdateOne(list.CusID);
                if (check)
                {
                    success= 1;
                }
                else {

                    success= 0;
                }
            }
            return success;

        }

        [WebMethod]
        public int Updatestate(int lid) {
            Maticsoft.Model.CustomLosts model = new BLL.CustomLosts().GetModel(lid);
            if (model.CLState == 1)
            {
                return 0;
            }
            else {

                return 1;
                    }
        }
    }
}
