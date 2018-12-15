using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// CustomLosts:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CustomLosts
	{
		public CustomLosts()
		{}
		#region Model
		private int _clid;
		private string _cusid;
		private DateTime? _clorderdate;
		private DateTime? _cldate= DateTime.Now;
		private DateTime? _clenterdate;
		private string _clreason;
		private int? _clstate;
		/// <summary>
		/// 
		/// </summary>
		public int CLID
		{
			set{ _clid=value;}
			get{return _clid;}
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
		public DateTime? CLOrderDate
		{
			set{ _clorderdate=value;}
			get{return _clorderdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CLDate
		{
			set{ _cldate=value;}
			get{return _cldate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CLEnterDate
		{
			set{ _clenterdate=value;}
			get{return _clenterdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLReason
		{
			set{ _clreason=value;}
			get{return _clreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLState
		{
			set{ _clstate=value;}
			get{return _clstate;}
		}
        #endregion Model
        public string CusName { get; set; }
    }
}

