namespace WellRental.AdminWeb.WellRentalCenter {
    export interface AssignmentRow {
        Id?: number;
        OrderNo?: string;
        PlateNumber?: string;
        DriverName?: string;
        DriverPhone?: string;
        AssignmentStatus?: number;
        AuditUser?: string;
        AuditDateTime?: string;
    }

    export namespace AssignmentRow {
        export const idProperty = 'Id';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'WellRentalCenter.Assignment';

        export declare const enum Fields {
            Id = "Id",
            OrderNo = "OrderNo",
            PlateNumber = "PlateNumber",
            DriverName = "DriverName",
            DriverPhone = "DriverPhone",
            AssignmentStatus = "AssignmentStatus",
            AuditUser = "AuditUser",
            AuditDateTime = "AuditDateTime"
        }
    }
}
