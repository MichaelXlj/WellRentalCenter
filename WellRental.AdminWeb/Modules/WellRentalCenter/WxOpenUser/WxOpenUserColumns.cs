
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.WxOpenUser")]
    [BasedOnRow(typeof(Entities.WxOpenUserRow), CheckNames = true)]
    public class WxOpenUserColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String OpenId { get; set; }
        public String NickName { get; set; }
        public Int32 Sex { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public String Country { get; set; }
        public String HeadImhUrl { get; set; }
        public Guid EntranceMerchant { get; set; }
        public String Mobile { get; set; }
        public Int32 VisitCount { get; set; }
        public DateTime LastVisitDateTime { get; set; }
    }
}