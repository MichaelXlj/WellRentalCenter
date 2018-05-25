
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.Payment")]
    [BasedOnRow(typeof(Entities.PaymentRow), CheckNames = true)]
    public class PaymentColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String OrderNo { get; set; }
        public Int32 PaymentMethod { get; set; }
        public DateTime PaidDateTime { get; set; }
        public Double Amount { get; set; }
        public Int32 PaymentCatalog { get; set; }
        public String SequnceNo { get; set; }
    }
}