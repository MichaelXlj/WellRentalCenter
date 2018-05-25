
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[Payment]")]
    [DisplayName("Payment"), InstanceName("Payment")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PaymentRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Order No"), Size(50), NotNull, QuickSearch]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Payment Method"), NotNull]
        public Int32? PaymentMethod
        {
            get { return Fields.PaymentMethod[this]; }
            set { Fields.PaymentMethod[this] = value; }
        }

        [DisplayName("Paid Date Time"), NotNull]
        public DateTime? PaidDateTime
        {
            get { return Fields.PaidDateTime[this]; }
            set { Fields.PaidDateTime[this] = value; }
        }

        [DisplayName("Amount"), NotNull]
        public Double? Amount
        {
            get { return Fields.Amount[this]; }
            set { Fields.Amount[this] = value; }
        }

        [DisplayName("Payment Catalog")]
        public Int32? PaymentCatalog
        {
            get { return Fields.PaymentCatalog[this]; }
            set { Fields.PaymentCatalog[this] = value; }
        }

        [DisplayName("Sequnce No"), Column("SequnceNO"), Size(50)]
        public String SequnceNo
        {
            get { return Fields.SequnceNo[this]; }
            set { Fields.SequnceNo[this] = value; }
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

        public PaymentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField OrderNo;
            public Int32Field PaymentMethod;
            public DateTimeField PaidDateTime;
            public DoubleField Amount;
            public Int32Field PaymentCatalog;
            public StringField SequnceNo;
		}
    }
}
