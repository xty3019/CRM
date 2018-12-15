using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ServiceType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ServiceType
	{
		public ServiceType()
		{}
		#region Model
		private int _stid;
		private string _stname;
		/// <summary>
		/// 
		/// </summary>
		public int STID
		{
			set{ _stid=value;}
			get{return _stid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STName
		{
			set{ _stname=value;}
			get{return _stname;}
		}
		#endregion Model

	}
}

