using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Measures:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Measures
	{
		public Measures()
		{}
		#region Model
		private int _meid;
		private int? _clid;
		private DateTime? _medate;
		private string _medesc;
		/// <summary>
		/// 
		/// </summary>
		public int MeID
		{
			set{ _meid=value;}
			get{return _meid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLID
		{
			set{ _clid=value;}
			get{return _clid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MeDate
		{
			set{ _medate=value;}
			get{return _medate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeDesc
		{
			set{ _medesc=value;}
			get{return _medesc;}
		}
        #endregion Model
        public string CusName { get; set; }
        public string CusID { get; set; }
    }
}

