namespace WellRental.AdminWeb.WellRentalCenter {
    export interface DistrictRow {
        DistrictId?: number;
        DistrictName?: string;
        CityId?: number;
        DateCreated?: string;
        DateUpdated?: string;
    }

    export namespace DistrictRow {
        export const idProperty = 'DistrictId';
        export const nameProperty = 'DistrictName';
        export const localTextPrefix = 'WellRentalCenter.District';

        export declare const enum Fields {
            DistrictId = "DistrictId",
            DistrictName = "DistrictName",
            CityId = "CityId",
            DateCreated = "DateCreated",
            DateUpdated = "DateUpdated"
        }
    }
}
