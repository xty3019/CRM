using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// CustomServices:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CustomServices
    {
        public CustomServices()
        { }
        #region Model
        private int _csid;
        private int? _stid;
        private string _cusid;
        private string _cstitle;
        private int? _csstate;
        private string _csdesc;
        private int? _cscreateid;
        private DateTime? _cscreatedate;
        private int? _csdueid;
        private DateTime? _csduedate;
        private string _csdeal;
        private DateTime? _csdealdate;
        private string _csresult;
        private int? _cssatisfy;
        private string _stname;
        private string _cusname;
        private string _lmname;
        private int _userid;
        private string _userlname;
        private string _userlpwd;
        private string _username;
        private int? _roleid;
        private int? _chancreateman;
        private int _chanid;
        private string _channame;
        private int? _chandueman;
        private string _chanlinkman;
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string ChanLinkMan
        {
            set { _chanlinkman = value; }
            get { return _chanlinkman; }
        }
        public int? ChanDueMan
        {
            set { _chandueman = value; }
            get { return _chandueman; }
        }
        public string ChanName
        {
            set { _channame = value; }
            get { return _channame; }
        }
        public int ChanID
        {
            set { _chanid = value; }
            get { return _chanid; }
        }
        public int CSID
        {
            set { _csid = value; }
            get { return _csid; }
        }
        public int? ChanCreateMan
        {
            set { _chancreateman = value; }
            get { return _chancreateman; }
        }
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserLName
        {
            set { _userlname = value; }
            get { return _userlname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserLPWD
        {
            set { _userlpwd = value; }
            get { return _userlpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? STID
        {
            set { _stid = value; }
            get { return _stid; }
        }

        public string LMName
        {
            set { _lmname = value; }
            get { return _lmname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CusID
        {
            set { _cusid = value; }
            get { return _cusid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CSTitle
        {
            set { _cstitle = value; }
            get { return _cstitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CSState
        {
            set { _csstate = value; }
            get { return _csstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CSDesc
        {
            set { _csdesc = value; }
            get { return _csdesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CSCreateID
        {
            set { _cscreateid = value; }
            get { return _cscreateid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CSCreateDate
        {
            set { _cscreatedate = value; }
            get { return _cscreatedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CSDueID
        {
            set { _csdueid = value; }
            get { return _csdueid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CSDueDate
        {
            set { _csduedate = value; }
            get { return _csduedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CSDeal
        {
            set { _csdeal = value; }
            get { return _csdeal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CSDealDate
        {
            set { _csdealdate = value; }
            get { return _csdealdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CSResult
        {
            set { _csresult = value; }
            get { return _csresult; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CSSatisfy
        {
            set { _cssatisfy = value; }
            get { return _cssatisfy; }
        }
        public string STName
        {
            set { _stname = value; }
            get { return _stname; }
        }
        public string CusName
        {
            set { _cusname = value; }
            get { return _cusname; }
        }
        #endregion Model

    }
}

