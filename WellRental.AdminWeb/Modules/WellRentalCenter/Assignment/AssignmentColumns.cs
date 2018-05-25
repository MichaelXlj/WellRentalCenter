
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.Assignment")]
    [BasedOnRow(typeof(Entities.AssignmentRow), CheckNames = true)]
    public class AssignmentColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String OrderNo { get; set; }
        public String PlateNumber { get; set; }
        public String DriverName { get; set; }
        public String DriverPhone { get; set; }
        public Int32 AssignmentStatus { get; set; }
        public String AuditUser { get; set; }
        public DateTime AuditDateTime { get; set; }
    }
}