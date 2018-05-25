namespace WellRental.AdminWeb.WellRentalCenter {
    export interface CityRow {
        CityId?: number;
        CityName?: string;
        ZipCode?: string;
        ProvinceId?: number;
        DateCreated?: string;
        DateUpdated?: string;
    }

    export namespace CityRow {
        export const idProperty = 'CityId';
        export const nameProperty = 'CityName';
        export const localTextPrefix = 'WellRentalCenter.City';

        export declare const enum Fields {
            CityId = "CityId",
            CityName = "CityName",
            ZipCode = "ZipCode",
            ProvinceId = "ProvinceId",
            DateCreated = "DateCreated",
            DateUpdated = "DateUpdated"
        }
    }
}
