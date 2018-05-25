namespace WellRental.AdminWeb.WellRentalCenter {
    export interface PaymentRow {
        Id?: number;
        OrderNo?: string;
        PaymentMethod?: number;
        PaidDateTime?: string;
        Amount?: number;
        PaymentCatalog?: number;
        SequnceNo?: string;
    }

    export namespace PaymentRow {
        export const idProperty = 'Id';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'WellRentalCenter.Payment';

        export declare const enum Fields {
            Id = "Id",
            OrderNo = "OrderNo",
            PaymentMethod = "PaymentMethod",
            PaidDateTime = "PaidDateTime",
            Amount = "Amount",
            PaymentCatalog = "PaymentCatalog",
            SequnceNo = "SequnceNo"
        }
    }
}
