
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.Merchant")]
    [BasedOnRow(typeof(Entities.MerchantRow), CheckNames = true)]
    public class MerchantColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public Guid MerchantId { get; set; }
        public Guid MerchantTypeId { get; set; }
        [EditLink]
        public String Name { get; set; }
        public Double RebateAmount { get; set; }
        public String RespoPerson { get; set; }
        public String RespoPhone { get; set; }
        public String Attest1 { get; set; }
        public String Attest2 { get; set; }
        public String Attest3 { get; set; }
        public String Attest4 { get; set; }
        public String Attest5 { get; set; }
        public String AliPayAccount { get; set; }
        public String WeiXinPayAccount { get; set; }
        public String Address { get; set; }
        public Decimal Longitude { get; set; }
        public Decimal Latitude { get; set; }
        public String Contactor { get; set; }
        public String ContactPhone { get; set; }
        public Stream QrCode { get; set; }
        public Int32 CreatedBy { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Int32 UpdatedBy { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}