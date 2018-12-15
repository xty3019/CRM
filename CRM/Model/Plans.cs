using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Plans:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Plans
	{
		public Plans()
		{}
		#region Model
		private string _planid;
		private int? _chanid;
		private DateTime? _plandate= DateTime.Now;
		private string _plancontent;
		private DateTime? _planresultdate;
		private string _planresult;
		/// <summary>
		/// 
		/// </summary>
		public string PlanID
		{
			set{ _planid=value;}
			get{return _planid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChanID
		{
			set{ _chanid=value;}
			get{return _chanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PlanDate
		{
			set{ _plandate=value;}
			get{return _plandate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PlanContent
		{
			set{ _plancontent=value;}
			get{return _plancontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PlanResultDate
		{
			set{ _planresultdate=value;}
			get{return _planresultdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PlanResult
		{
			set{ _planresult=value;}
			get{return _planresult;}
		}
		#endregion Model

	}
}

