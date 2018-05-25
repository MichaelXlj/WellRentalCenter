namespace WellRental.AdminWeb.WellRentalCenter {
    export interface WxOpenUserRow {
        Id?: number;
        OpenId?: string;
        NickName?: string;
        Sex?: number;
        City?: string;
        Province?: string;
        Country?: string;
        HeadImhUrl?: string;
        EntranceMerchant?: string;
        Mobile?: string;
        VisitCount?: number;
        LastVisitDateTime?: string;
    }

    export namespace WxOpenUserRow {
        export const idProperty = 'Id';
        export const nameProperty = 'OpenId';
        export const localTextPrefix = 'WellRentalCenter.WxOpenUser';

        export declare const enum Fields {
            Id = "Id",
            OpenId = "OpenId",
            NickName = "NickName",
            Sex = "Sex",
            City = "City",
            Province = "Province",
            Country = "Country",
            HeadImhUrl = "HeadImhUrl",
            EntranceMerchant = "EntranceMerchant",
            Mobile = "Mobile",
            VisitCount = "VisitCount",
            LastVisitDateTime = "LastVisitDateTime"
        }
    }
}
