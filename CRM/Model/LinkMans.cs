using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// LinkMans:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LinkMans
	{
		public LinkMans()
		{}
		#region Model
		private int _lmid;
		private string _cusid;
		private string _lmname;
		private string _lmsex;
		private string _lmduty;
		private string _lmmobileno;
		private string _lmofficeno;
		private string _lmmemo;
		/// <summary>
		/// 
		/// </summary>
		public int LMID
		{
			set{ _lmid=value;}
			get{return _lmid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusID
		{
			set{ _cusid=value;}
			get{return _cusid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LMName
		{
			set{ _lmname=value;}
			get{return _lmname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LMSex
		{
			set{ _lmsex=value;}
			get{return _lmsex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LMDuty
		{
			set{ _lmduty=value;}
			get{return _lmduty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LMMobileNo
		{
			set{ _lmmobileno=value;}
			get{return _lmmobileno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LMOfficeNo
		{
			set{ _lmofficeno=value;}
			get{return _lmofficeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LMMemo
		{
			set{ _lmmemo=value;}
			get{return _lmmemo;}
		}
        #endregion Model
        public string CusName { get; set; }
    }
}

