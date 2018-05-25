
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.Payment")]
    [BasedOnRow(typeof(Entities.PaymentRow), CheckNames = true)]
    public class PaymentForm
    {
        public String OrderNo { get; set; }
        public Int32 PaymentMethod { get; set; }
        public DateTime PaidDateTime { get; set; }
        public Double Amount { get; set; }
        public Int32 PaymentCatalog { get; set; }
        public String SequnceNo { get; set; }
    }
}