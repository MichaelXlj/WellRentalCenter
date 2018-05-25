
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[City]")]
    [DisplayName("City"), InstanceName("City")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CityRow : Row, IIdRow, INameRow
    {
        [DisplayName("City Id"), Column("CityID"), Identity]
        public Int64? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("City Name"), Size(50), QuickSearch]
        public String CityName
        {
            get { return Fields.CityName[this]; }
            set { Fields.CityName[this] = value; }
        }

        [DisplayName("Zip Code"), Size(50)]
        public String ZipCode
        {
            get { return Fields.ZipCode[this]; }
            set { Fields.ZipCode[this] = value; }
        }

        [DisplayName("Province Id"), Column("ProvinceID")]
        public Int64? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [DisplayName("Date Created")]
        public DateTime? DateCreated
        {
            get { return Fields.DateCreated[this]; }
            set { Fields.DateCreated[this] = value; }
        }

        [DisplayName("Date Updated")]
        public DateTime? DateUpdated
        {
            get { return Fields.DateUpdated[this]; }
            set { Fields.DateUpdated[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CityId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CityName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CityRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field CityId;
            public StringField CityName;
            public StringField ZipCode;
            public Int64Field ProvinceId;
            public DateTimeField DateCreated;
            public DateTimeField DateUpdated;
		}
    }
}
