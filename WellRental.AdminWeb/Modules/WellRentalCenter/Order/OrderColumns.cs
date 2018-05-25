
namespace WellRental.AdminWeb.WellRentalCenter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("WellRentalCenter.Order")]
    [BasedOnRow(typeof(Entities.OrderRow), CheckNames = true)]
    public class OrderColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String OrderNo { get; set; }
        public String OpenId { get; set; }
        public DateTime EstimateLeaveTime { get; set; }
        public DateTime LastestLeaveTime { get; set; }
        public Int32 PassengerCount { get; set; }
        public String ProceedPlace { get; set; }
        public String DestinationPlace { get; set; }
        public Boolean HasPet { get; set; }
        public Boolean HasLargeLuggage { get; set; }
        public Double LuggageWeight { get; set; }
        public String VehicleTypeReq { get; set; }
        public Int32 RentingType { get; set; }
        public String CustomerPhone { get; set; }
        public Int32 OrderStatus { get; set; }
        public DateTime SubscribeDateTime { get; set; }
        public String AuditUser { get; set; }
        public DateTime AuditDateTime { get; set; }
        public Double TransactionAmount { get; set; }
        public Double PrePayAmount { get; set; }
    }
}