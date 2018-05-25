namespace WellRental.AdminWeb.WellRentalCenter {
    export interface MerchantRow {
        Id?: number;
        MerchantId?: string;
        MerchantTypeId?: string;
        Name?: string;
        RebateAmount?: number;
        RespoPerson?: string;
        RespoPhone?: string;
        Attest1?: string;
        Attest2?: string;
        Attest3?: string;
        Attest4?: string;
        Attest5?: string;
        AliPayAccount?: string;
        WeiXinPayAccount?: string;
        Address?: string;
        Longitude?: number;
        Latitude?: number;
        Contactor?: string;
        ContactPhone?: string;
        QrCode?: number[];
        CreatedBy?: number;
        CreateDateTime?: string;
        UpdatedBy?: number;
        UpdateDateTime?: string;
    }

    export namespace MerchantRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'WellRentalCenter.Merchant';

        export declare const enum Fields {
            Id = "Id",
            MerchantId = "MerchantId",
            MerchantTypeId = "MerchantTypeId",
            Name = "Name",
            RebateAmount = "RebateAmount",
            RespoPerson = "RespoPerson",
            RespoPhone = "RespoPhone",
            Attest1 = "Attest1",
            Attest2 = "Attest2",
            Attest3 = "Attest3",
            Attest4 = "Attest4",
            Attest5 = "Attest5",
            AliPayAccount = "AliPayAccount",
            WeiXinPayAccount = "WeiXinPayAccount",
            Address = "Address",
            Longitude = "Longitude",
            Latitude = "Latitude",
            Contactor = "Contactor",
            ContactPhone = "ContactPhone",
            QrCode = "QrCode",
            CreatedBy = "CreatedBy",
            CreateDateTime = "CreateDateTime",
            UpdatedBy = "UpdatedBy",
            UpdateDateTime = "UpdateDateTime"
        }
    }
}
