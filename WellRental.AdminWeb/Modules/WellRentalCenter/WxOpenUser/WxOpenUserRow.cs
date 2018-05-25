
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[WxOpenUser]")]
    [DisplayName("Wx Open User"), InstanceName("Wx Open User")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class WxOpenUserRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Open Id"), Size(150), PrimaryKey, QuickSearch]
        public String OpenId
        {
            get { return Fields.OpenId[this]; }
            set { Fields.OpenId[this] = value; }
        }

        [DisplayName("Nick Name"), Size(50), NotNull]
        public String NickName
        {
            get { return Fields.NickName[this]; }
            set { Fields.NickName[this] = value; }
        }

        [DisplayName("Sex")]
        public Int32? Sex
        {
            get { return Fields.Sex[this]; }
            set { Fields.Sex[this] = value; }
        }

        [DisplayName("City"), Size(50)]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        [DisplayName("Province"), Size(50)]
        public String Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }

        [DisplayName("Country"), Size(50)]
        public String Country
        {
            get { return Fields.Country[this]; }
            set { Fields.Country[this] = value; }
        }

        [DisplayName("Head Imh Url")]
        public String HeadImhUrl
        {
            get { return Fields.HeadImhUrl[this]; }
            set { Fields.HeadImhUrl[this] = value; }
        }

        [DisplayName("Entrance Merchant")]
        public Guid? EntranceMerchant
        {
            get { return Fields.EntranceMerchant[this]; }
            set { Fields.EntranceMerchant[this] = value; }
        }

        [DisplayName("Mobile"), Size(50)]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("Visit Count")]
        public Int32? VisitCount
        {
            get { return Fields.VisitCount[this]; }
            set { Fields.VisitCount[this] = value; }
        }

        [DisplayName("Last Visit Date Time")]
        public DateTime? LastVisitDateTime
        {
            get { return Fields.LastVisitDateTime[this]; }
            set { Fields.LastVisitDateTime[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.OpenId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public WxOpenUserRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField OpenId;
            public StringField NickName;
            public Int32Field Sex;
            public StringField City;
            public StringField Province;
            public StringField Country;
            public StringField HeadImhUrl;
            public GuidField EntranceMerchant;
            public StringField Mobile;
            public Int32Field VisitCount;
            public DateTimeField LastVisitDateTime;
		}
    }
}
