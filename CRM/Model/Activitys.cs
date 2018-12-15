using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Activitys:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Activitys
	{
		public Activitys()
		{}
		#region Model
		private int _actid;
		private string _cusid;
		private DateTime? _actdate= DateTime.Now;
		private string _actadd;
		private string _acttitle;
		private string _actmemo;
		private string _actdesc;
		/// <summary>
		/// 
		/// </summary>
		public int ActID
		{
			set{ _actid=value;}
			get{return _actid;}
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
		public DateTime? ActDate
		{
			set{ _actdate=value;}
			get{return _actdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActAdd
		{
			set{ _actadd=value;}
			get{return _actadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActTitle
		{
			set{ _acttitle=value;}
			get{return _acttitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActMemo
		{
			set{ _actmemo=value;}
			get{return _actmemo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActDesc
		{
			set{ _actdesc=value;}
			get{return _actdesc;}
		}
		#endregion Model

	}
}

