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
    
    public partial class AdminNotification
    {
        public int notificationId { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string message { get; set; }
        public string notification_type { get; set; }
    }
}
