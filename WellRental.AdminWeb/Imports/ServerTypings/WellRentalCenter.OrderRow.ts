namespace WellRental.AdminWeb.WellRentalCenter {
    export interface OrderRow {
        Id?: number;
        OrderNo?: string;
        OpenId?: string;
        EstimateLeaveTime?: string;
        LastestLeaveTime?: string;
        PassengerCount?: number;
        ProceedPlace?: string;
        DestinationPlace?: string;
        HasPet?: boolean;
        HasLargeLuggage?: boolean;
        LuggageWeight?: number;
        VehicleTypeReq?: string;
        RentingType?: number;
        CustomerPhone?: string;
        OrderStatus?: number;
        SubscribeDateTime?: string;
        AuditUser?: string;
        AuditDateTime?: string;
        TransactionAmount?: number;
        PrePayAmount?: number;
    }

    export namespace OrderRow {
        export const idProperty = 'Id';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'WellRentalCenter.Order';

        export declare const enum Fields {
            Id = "Id",
            OrderNo = "OrderNo",
            OpenId = "OpenId",
            EstimateLeaveTime = "EstimateLeaveTime",
            LastestLeaveTime = "LastestLeaveTime",
            PassengerCount = "PassengerCount",
            ProceedPlace = "ProceedPlace",
            DestinationPlace = "DestinationPlace",
            HasPet = "HasPet",
            HasLargeLuggage = "HasLargeLuggage",
            LuggageWeight = "LuggageWeight",
            VehicleTypeReq = "VehicleTypeReq",
            RentingType = "RentingType",
            CustomerPhone = "CustomerPhone",
            OrderStatus = "OrderStatus",
            SubscribeDateTime = "SubscribeDateTime",
            AuditUser = "AuditUser",
            AuditDateTime = "AuditDateTime",
            TransactionAmount = "TransactionAmount",
            PrePayAmount = "PrePayAmount"
        }
    }
}
