
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[Order]")]
    [DisplayName("Order"), InstanceName("Order")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrderRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Order No"), Size(50), PrimaryKey, QuickSearch]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Open Id"), Size(150), NotNull]
        public String OpenId
        {
            get { return Fields.OpenId[this]; }
            set { Fields.OpenId[this] = value; }
        }

        [DisplayName("Estimate Leave Time"), NotNull]
        public DateTime? EstimateLeaveTime
        {
            get { return Fields.EstimateLeaveTime[this]; }
            set { Fields.EstimateLeaveTime[this] = value; }
        }

        [DisplayName("Lastest Leave Time"), NotNull]
        public DateTime? LastestLeaveTime
        {
            get { return Fields.LastestLeaveTime[this]; }
            set { Fields.LastestLeaveTime[this] = value; }
        }

        [DisplayName("Passenger Count"), NotNull]
        public Int32? PassengerCount
        {
            get { return Fields.PassengerCount[this]; }
            set { Fields.PassengerCount[this] = value; }
        }

        [DisplayName("Proceed Place"), Size(100), NotNull]
        public String ProceedPlace
        {
            get { return Fields.ProceedPlace[this]; }
            set { Fields.ProceedPlace[this] = value; }
        }

        [DisplayName("Destination Place"), Size(100), NotNull]
        public String DestinationPlace
        {
            get { return Fields.DestinationPlace[this]; }
            set { Fields.DestinationPlace[this] = value; }
        }

        [DisplayName("Has Pet"), NotNull]
        public Boolean? HasPet
        {
            get { return Fields.HasPet[this]; }
            set { Fields.HasPet[this] = value; }
        }

        [DisplayName("Has Large Luggage"), NotNull]
        public Boolean? HasLargeLuggage
        {
            get { return Fields.HasLargeLuggage[this]; }
            set { Fields.HasLargeLuggage[this] = value; }
        }

        [DisplayName("Luggage Weight")]
        public Double? LuggageWeight
        {
            get { return Fields.LuggageWeight[this]; }
            set { Fields.LuggageWeight[this] = value; }
        }

        [DisplayName("Vehicle Type Req"), Size(50)]
        public String VehicleTypeReq
        {
            get { return Fields.VehicleTypeReq[this]; }
            set { Fields.VehicleTypeReq[this] = value; }
        }

        [DisplayName("Renting Type")]
        public Int32? RentingType
        {
            get { return Fields.RentingType[this]; }
            set { Fields.RentingType[this] = value; }
        }

        [DisplayName("Customer Phone"), Size(50), NotNull]
        public String CustomerPhone
        {
            get { return Fields.CustomerPhone[this]; }
            set { Fields.CustomerPhone[this] = value; }
        }

        [DisplayName("Order Status"), NotNull]
        public Int32? OrderStatus
        {
            get { return Fields.OrderStatus[this]; }
            set { Fields.OrderStatus[this] = value; }
        }

        [DisplayName("Subscribe Date Time")]
        public DateTime? SubscribeDateTime
        {
            get { return Fields.SubscribeDateTime[this]; }
            set { Fields.SubscribeDateTime[this] = value; }
        }

        [DisplayName("Audit User"), Size(50)]
        public String AuditUser
        {
            get { return Fields.AuditUser[this]; }
            set { Fields.AuditUser[this] = value; }
        }

        [DisplayName("Audit Date Time")]
        public DateTime? AuditDateTime
        {
            get { return Fields.AuditDateTime[this]; }
            set { Fields.AuditDateTime[this] = value; }
        }

        [DisplayName("Transaction Amount")]
        public Double? TransactionAmount
        {
            get { return Fields.TransactionAmount[this]; }
            set { Fields.TransactionAmount[this] = value; }
        }

        [DisplayName("Pre Pay Amount")]
        public Double? PrePayAmount
        {
            get { return Fields.PrePayAmount[this]; }
            set { Fields.PrePayAmount[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.OrderNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField OrderNo;
            public StringField OpenId;
            public DateTimeField EstimateLeaveTime;
            public DateTimeField LastestLeaveTime;
            public Int32Field PassengerCount;
            public StringField ProceedPlace;
            public StringField DestinationPlace;
            public BooleanField HasPet;
            public BooleanField HasLargeLuggage;
            public DoubleField LuggageWeight;
            public StringField VehicleTypeReq;
            public Int32Field RentingType;
            public StringField CustomerPhone;
            public Int32Field OrderStatus;
            public DateTimeField SubscribeDateTime;
            public StringField AuditUser;
            public DateTimeField AuditDateTime;
            public DoubleField TransactionAmount;
            public DoubleField PrePayAmount;
		}
    }
}
