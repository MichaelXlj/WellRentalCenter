namespace WellRental.AdminWeb.WellRentalCenter {
    export interface MerchantTypeRow {
        Id?: number;
        TypeId?: string;
        TypeName?: string;
    }

    export namespace MerchantTypeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'TypeName';
        export const localTextPrefix = 'WellRentalCenter.MerchantType';

        export declare const enum Fields {
            Id = "Id",
            TypeId = "TypeId",
            TypeName = "TypeName"
        }
    }
}
