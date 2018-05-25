
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.Province")]
    [BasedOnRow(typeof(Entities.ProvinceRow), CheckNames = true)]
    public class ProvinceForm
    {
        public String ProvinceName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}