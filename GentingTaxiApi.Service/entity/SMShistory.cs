//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GentingTaxiApi.Service.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SMShistory
    {
        public int smshistoryId { get; set; }
        public string message { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> driverId { get; set; }
        public Nullable<int> userId { get; set; }
        public string phoneNo { get; set; }
    }
}
