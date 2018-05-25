namespace WellRental.AdminWeb.WellRentalCenter {
    export interface ProvinceRow {
        ProvinceId?: number;
        ProvinceName?: string;
        DateCreated?: string;
        DateUpdated?: string;
    }

    export namespace ProvinceRow {
        export const idProperty = 'ProvinceId';
        export const nameProperty = 'ProvinceName';
        export const localTextPrefix = 'WellRentalCenter.Province';

        export declare const enum Fields {
            ProvinceId = "ProvinceId",
            ProvinceName = "ProvinceName",
            DateCreated = "DateCreated",
            DateUpdated = "DateUpdated"
        }
    }
}
