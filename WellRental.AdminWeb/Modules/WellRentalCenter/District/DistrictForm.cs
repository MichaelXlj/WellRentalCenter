
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.District")]
    [BasedOnRow(typeof(Entities.DistrictRow), CheckNames = true)]
    public class DistrictForm
    {
        public String DistrictName { get; set; }
        public Int64 CityId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}