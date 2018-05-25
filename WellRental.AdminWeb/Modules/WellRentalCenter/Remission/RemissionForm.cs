
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.Remission")]
    [BasedOnRow(typeof(Entities.RemissionRow), CheckNames = true)]
    public class RemissionForm
    {
        public String SequenceNo { get; set; }
        public Guid MerchantId { get; set; }
        public Double WithdrawAmount { get; set; }
        public DateTime WithdrawDateTime { get; set; }
        public Int32 WithdrawStatus { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public String Description { get; set; }
    }
}