using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Chances:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Chances
	{
		public Chances()
		{}
		#region Model
		private int _chanid;
		private string _channame;
		private int? _chanrate;
		private string _chanlinkman;
		private string _chanlinktel;
		private string _chantitle;
		private string _chandesc;
		private int? _chancreateman;
		private DateTime? _chancreatedate= DateTime.Now;
		private int? _chandueman;
		private DateTime? _chanduedate;
		private int? _chanstate;
		private string _chanerror;
		/// <summary>
		/// 
		/// </summary>
		public int ChanID
		{
			set{ _chanid=value;}
			get{return _chanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChanName
		{
			set{ _channame=value;}
			get{return _channame;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChanRate
		{
			set{ _chanrate=value;}
			get{return _chanrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChanLinkMan
		{
			set{ _chanlinkman=value;}
			get{return _chanlinkman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChanLinkTel
		{
			set{ _chanlinktel=value;}
			get{return _chanlinktel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChanTitle
		{
			set{ _chantitle=value;}
			get{return _chantitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChanDesc
		{
			set{ _chandesc=value;}
			get{return _chandesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChanCreateMan
		{
			set{ _chancreateman=value;}
			get{return _chancreateman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ChanCreateDate
		{
			set{ _chancreatedate=value;}
			get{return _chancreatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChanDueMan
		{
			set{ _chandueman=value;}
			get{return _chandueman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ChanDueDate
		{
			set{ _chanduedate=value;}
			get{return _chanduedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChanState
		{
			set{ _chanstate=value;}
			get{return _chanstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChanError
		{
			set{ _chanerror=value;}
			get{return _chanerror;}
		}
		#endregion Model

	}
}

