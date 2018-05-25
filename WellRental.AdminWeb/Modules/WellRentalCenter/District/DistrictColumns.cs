
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.District")]
    [BasedOnRow(typeof(Entities.DistrictRow), CheckNames = true)]
    public class DistrictColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 DistrictId { get; set; }
        [EditLink]
        public String DistrictName { get; set; }
        public Int64 CityId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}