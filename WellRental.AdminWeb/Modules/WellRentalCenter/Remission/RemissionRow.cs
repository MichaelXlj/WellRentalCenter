
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[Remission]")]
    [DisplayName("Remission"), InstanceName("Remission")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RemissionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Sequence No"), Size(50), PrimaryKey, QuickSearch]
        public String SequenceNo
        {
            get { return Fields.SequenceNo[this]; }
            set { Fields.SequenceNo[this] = value; }
        }

        [DisplayName("Merchant Id"), NotNull]
        public Guid? MerchantId
        {
            get { return Fields.MerchantId[this]; }
            set { Fields.MerchantId[this] = value; }
        }

        [DisplayName("Withdraw Amount"), NotNull]
        public Double? WithdrawAmount
        {
            get { return Fields.WithdrawAmount[this]; }
            set { Fields.WithdrawAmount[this] = value; }
        }

        [DisplayName("Withdraw Date Time"), NotNull]
        public DateTime? WithdrawDateTime
        {
            get { return Fields.WithdrawDateTime[this]; }
            set { Fields.WithdrawDateTime[this] = value; }
        }

        [DisplayName("Withdraw Status")]
        public Int32? WithdrawStatus
        {
            get { return Fields.WithdrawStatus[this]; }
            set { Fields.WithdrawStatus[this] = value; }
        }

        [DisplayName("Arrival Date Time")]
        public DateTime? ArrivalDateTime
        {
            get { return Fields.ArrivalDateTime[this]; }
            set { Fields.ArrivalDateTime[this] = value; }
        }

        [DisplayName("Description")]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SequenceNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RemissionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SequenceNo;
            public GuidField MerchantId;
            public DoubleField WithdrawAmount;
            public DateTimeField WithdrawDateTime;
            public Int32Field WithdrawStatus;
            public DateTimeField ArrivalDateTime;
            public StringField Description;
		}
    }
}
