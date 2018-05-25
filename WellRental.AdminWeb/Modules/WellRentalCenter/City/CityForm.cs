
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.City")]
    [BasedOnRow(typeof(Entities.CityRow), CheckNames = true)]
    public class CityForm
    {
        public String CityName { get; set; }
        public String ZipCode { get; set; }
        public Int64 ProvinceId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}