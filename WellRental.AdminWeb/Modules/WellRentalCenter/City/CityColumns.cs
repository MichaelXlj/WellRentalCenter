
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.City")]
    [BasedOnRow(typeof(Entities.CityRow), CheckNames = true)]
    public class CityColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 CityId { get; set; }
        [EditLink]
        public String CityName { get; set; }
        public String ZipCode { get; set; }
        public Int64 ProvinceId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}