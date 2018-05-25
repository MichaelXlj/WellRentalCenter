
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.MerchantType")]
    [BasedOnRow(typeof(Entities.MerchantTypeRow), CheckNames = true)]
    public class MerchantTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public Guid TypeId { get; set; }
        [EditLink]
        public String TypeName { get; set; }
    }
}