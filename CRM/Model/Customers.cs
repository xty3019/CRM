using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Customers:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Customers
	{
		public Customers()
		{}
		#region Model
		private string _cusid;
		private int? _userid;
		private string _cusname;
		private string _cusaddress;
		private string _cuszip;
		private string _cusfax;
		private string _cuswebsite;
		private string _cuslicenceno;
		private string _cuschieftain;
		private int? _cusbankroll;
		private int? _custurnover;
		private string _cusbank;
		private string _cusbankno;
		private string _cuslocaltaxno;
		private string _cusnationaltaxno;
		private DateTime? _cusdate= DateTime.Now;
		private int? _cusstate;
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
		public int? UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusName
		{
			set{ _cusname=value;}
			get{return _cusname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusAddress
		{
			set{ _cusaddress=value;}
			get{return _cusaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusZip
		{
			set{ _cuszip=value;}
			get{return _cuszip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusFax
		{
			set{ _cusfax=value;}
			get{return _cusfax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusWebsite
		{
			set{ _cuswebsite=value;}
			get{return _cuswebsite;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusLicenceNo
		{
			set{ _cuslicenceno=value;}
			get{return _cuslicenceno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusChieftain
		{
			set{ _cuschieftain=value;}
			get{return _cuschieftain;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CusBankroll
		{
			set{ _cusbankroll=value;}
			get{return _cusbankroll;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CusTurnover
		{
			set{ _custurnover=value;}
			get{return _custurnover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBank
		{
			set{ _cusbank=value;}
			get{return _cusbank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBankNo
		{
			set{ _cusbankno=value;}
			get{return _cusbankno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusLocalTaxNo
		{
			set{ _cuslocaltaxno=value;}
			get{return _cuslocaltaxno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusNationalTaxNo
		{
			set{ _cusnationaltaxno=value;}
			get{return _cusnationaltaxno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CusDate
		{
			set{ _cusdate=value;}
			get{return _cusdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CusState
		{
			set{ _cusstate=value;}
			get{return _cusstate;}
		}
        #endregion Model
        public string UserName { get; set; }
    }
}

