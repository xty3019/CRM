﻿using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Role
	{
		public Role()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		/// <summary>
		/// 
		/// </summary>
		public int RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		#endregion Model

	}
}

