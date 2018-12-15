using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Users
	{
		public Users()
		{}
		#region Model
		private int _userid;
		private string _userlname;
		private string _userlpwd;
		private string _username;
		private int? _roleid;
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserLName
		{
			set{ _userlname=value;}
			get{return _userlname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserLPWD
		{
			set{ _userlpwd=value;}
			get{return _userlpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}

        public string RoleName { get; set; }
		#endregion Model

	}
}

