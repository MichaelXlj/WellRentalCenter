
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.Assignment")]
    [BasedOnRow(typeof(Entities.AssignmentRow), CheckNames = true)]
    public class AssignmentForm
    {
        public String OrderNo { get; set; }
        public String PlateNumber { get; set; }
        public String DriverName { get; set; }
        public String DriverPhone { get; set; }
        public Int32 AssignmentStatus { get; set; }
        public String AuditUser { get; set; }
        public DateTime AuditDateTime { get; set; }
    }
}