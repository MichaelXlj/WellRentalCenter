
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[Province]")]
    [DisplayName("Province"), InstanceName("Province")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProvinceRow : Row, IIdRow, INameRow
    {
        [DisplayName("Province Id"), Column("ProvinceID"), Identity]
        public Int64? ProvinceId
        {
            get { return Fields.ProvinceId[this]; }
            set { Fields.ProvinceId[this] = value; }
        }

        [DisplayName("Province Name"), Size(50), QuickSearch]
        public String ProvinceName
        {
            get { return Fields.ProvinceName[this]; }
            set { Fields.ProvinceName[this] = value; }
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
            get { return Fields.ProvinceId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProvinceName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProvinceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field ProvinceId;
            public StringField ProvinceName;
            public DateTimeField DateCreated;
            public DateTimeField DateUpdated;
		}
    }
}
