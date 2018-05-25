
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[District]")]
    [DisplayName("District"), InstanceName("District")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DistrictRow : Row, IIdRow, INameRow
    {
        [DisplayName("District Id"), Column("DistrictID"), Identity]
        public Int64? DistrictId
        {
            get { return Fields.DistrictId[this]; }
            set { Fields.DistrictId[this] = value; }
        }

        [DisplayName("District Name"), Size(50), QuickSearch]
        public String DistrictName
        {
            get { return Fields.DistrictName[this]; }
            set { Fields.DistrictName[this] = value; }
        }

        [DisplayName("City Id"), Column("CityID")]
        public Int64? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
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
            get { return Fields.DistrictId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DistrictName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DistrictRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field DistrictId;
            public StringField DistrictName;
            public Int64Field CityId;
            public DateTimeField DateCreated;
            public DateTimeField DateUpdated;
		}
    }
}
