//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace zSession.Base.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session_LogIn
    {
        public long serialno { get; set; }
        public string userID { get; set; }
        public string userPSD { get; set; }
        public string lastLogMacID { get; set; }
        public string lastLogTime { get; set; }
        public string Remark { get; set; }
        public string WorkStatus { get; set; }
    }
}
