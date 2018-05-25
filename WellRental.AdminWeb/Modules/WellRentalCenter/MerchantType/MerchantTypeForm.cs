
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.MerchantType")]
    [BasedOnRow(typeof(Entities.MerchantTypeRow), CheckNames = true)]
    public class MerchantTypeForm
    {
        public Guid TypeId { get; set; }
        public String TypeName { get; set; }
    }
}