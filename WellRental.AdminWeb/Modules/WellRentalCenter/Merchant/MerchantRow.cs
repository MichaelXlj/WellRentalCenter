
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[Merchant]")]
    [DisplayName("Merchant"), InstanceName("Merchant")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MerchantRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Merchant Id"), PrimaryKey]
        public Guid? MerchantId
        {
            get { return Fields.MerchantId[this]; }
            set { Fields.MerchantId[this] = value; }
        }

        [DisplayName("Merchant Type Id")]
        public Guid? MerchantTypeId
        {
            get { return Fields.MerchantTypeId[this]; }
            set { Fields.MerchantTypeId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Rebate Amount")]
        public Double? RebateAmount
        {
            get { return Fields.RebateAmount[this]; }
            set { Fields.RebateAmount[this] = value; }
        }

        [DisplayName("Respo Person"), Size(50)]
        public String RespoPerson
        {
            get { return Fields.RespoPerson[this]; }
            set { Fields.RespoPerson[this] = value; }
        }

        [DisplayName("Respo Phone"), Size(50)]
        public String RespoPhone
        {
            get { return Fields.RespoPhone[this]; }
            set { Fields.RespoPhone[this] = value; }
        }

        [DisplayName("Attest1")]
        public String Attest1
        {
            get { return Fields.Attest1[this]; }
            set { Fields.Attest1[this] = value; }
        }

        [DisplayName("Attest2")]
        public String Attest2
        {
            get { return Fields.Attest2[this]; }
            set { Fields.Attest2[this] = value; }
        }

        [DisplayName("Attest3")]
        public String Attest3
        {
            get { return Fields.Attest3[this]; }
            set { Fields.Attest3[this] = value; }
        }

        [DisplayName("Attest4")]
        public String Attest4
        {
            get { return Fields.Attest4[this]; }
            set { Fields.Attest4[this] = value; }
        }

        [DisplayName("Attest5")]
        public String Attest5
        {
            get { return Fields.Attest5[this]; }
            set { Fields.Attest5[this] = value; }
        }

        [DisplayName("Ali Pay Account"), Size(100)]
        public String AliPayAccount
        {
            get { return Fields.AliPayAccount[this]; }
            set { Fields.AliPayAccount[this] = value; }
        }

        [DisplayName("Wei Xin Pay Account"), Size(100)]
        public String WeiXinPayAccount
        {
            get { return Fields.WeiXinPayAccount[this]; }
            set { Fields.WeiXinPayAccount[this] = value; }
        }

        [DisplayName("Address")]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Longitude"), Size(18)]
        public Decimal? Longitude
        {
            get { return Fields.Longitude[this]; }
            set { Fields.Longitude[this] = value; }
        }

        [DisplayName("Latitude"), Size(18)]
        public Decimal? Latitude
        {
            get { return Fields.Latitude[this]; }
            set { Fields.Latitude[this] = value; }
        }

        [DisplayName("Contactor"), Size(50)]
        public String Contactor
        {
            get { return Fields.Contactor[this]; }
            set { Fields.Contactor[this] = value; }
        }

        [DisplayName("Contact Phone"), Size(50)]
        public String ContactPhone
        {
            get { return Fields.ContactPhone[this]; }
            set { Fields.ContactPhone[this] = value; }
        }

        [DisplayName("Qr Code"), Column("QRCode"), Size(2147483647)]
        public Stream QrCode
        {
            get { return Fields.QrCode[this]; }
            set { Fields.QrCode[this] = value; }
        }

        [DisplayName("Created By"), NotNull]
        public Int32? CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Create Date Time"), NotNull]
        public DateTime? CreateDateTime
        {
            get { return Fields.CreateDateTime[this]; }
            set { Fields.CreateDateTime[this] = value; }
        }

        [DisplayName("Updated By")]
        public Int32? UpdatedBy
        {
            get { return Fields.UpdatedBy[this]; }
            set { Fields.UpdatedBy[this] = value; }
        }

        [DisplayName("Update Date Time")]
        public DateTime? UpdateDateTime
        {
            get { return Fields.UpdateDateTime[this]; }
            set { Fields.UpdateDateTime[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MerchantRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public GuidField MerchantId;
            public GuidField MerchantTypeId;
            public StringField Name;
            public DoubleField RebateAmount;
            public StringField RespoPerson;
            public StringField RespoPhone;
            public StringField Attest1;
            public StringField Attest2;
            public StringField Attest3;
            public StringField Attest4;
            public StringField Attest5;
            public StringField AliPayAccount;
            public StringField WeiXinPayAccount;
            public StringField Address;
            public DecimalField Longitude;
            public DecimalField Latitude;
            public StringField Contactor;
            public StringField ContactPhone;
            public StreamField QrCode;
            public Int32Field CreatedBy;
            public DateTimeField CreateDateTime;
            public Int32Field UpdatedBy;
            public DateTimeField UpdateDateTime;
		}
    }
}
