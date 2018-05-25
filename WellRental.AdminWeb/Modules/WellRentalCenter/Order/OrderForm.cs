
namespace WellRental.AdminWeb.WellRentalCenter.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("WellRentalCenter.Order")]
    [BasedOnRow(typeof(Entities.OrderRow), CheckNames = true)]
    public class OrderForm
    {
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