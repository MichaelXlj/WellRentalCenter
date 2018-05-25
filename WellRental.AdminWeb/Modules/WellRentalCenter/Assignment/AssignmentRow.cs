
namespace WellRental.AdminWeb.WellRentalCenter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("WellRentalCenter"), Module("WellRentalCenter"), TableName("[dbo].[Assignment]")]
    [DisplayName("Assignment"), InstanceName("Assignment")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AssignmentRow : Row, IIdRow, INameRow
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

        [DisplayName("Plate Number"), Size(10), NotNull]
        public String PlateNumber
        {
            get { return Fields.PlateNumber[this]; }
            set { Fields.PlateNumber[this] = value; }
        }

        [DisplayName("Driver Name"), Size(20), NotNull]
        public String DriverName
        {
            get { return Fields.DriverName[this]; }
            set { Fields.DriverName[this] = value; }
        }

        [DisplayName("Driver Phone"), Size(50), NotNull]
        public String DriverPhone
        {
            get { return Fields.DriverPhone[this]; }
            set { Fields.DriverPhone[this] = value; }
        }

        [DisplayName("Assignment Status")]
        public Int32? AssignmentStatus
        {
            get { return Fields.AssignmentStatus[this]; }
            set { Fields.AssignmentStatus[this] = value; }
        }

        [DisplayName("Audit User"), Size(50), NotNull]
        public String AuditUser
        {
            get { return Fields.AuditUser[this]; }
            set { Fields.AuditUser[this] = value; }
        }

        [DisplayName("Audit Date Time"), NotNull]
        public DateTime? AuditDateTime
        {
            get { return Fields.AuditDateTime[this]; }
            set { Fields.AuditDateTime[this] = value; }
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

        public AssignmentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField OrderNo;
            public StringField PlateNumber;
            public StringField DriverName;
            public StringField DriverPhone;
            public Int32Field AssignmentStatus;
            public StringField AuditUser;
            public DateTimeField AuditDateTime;
		}
    }
}
