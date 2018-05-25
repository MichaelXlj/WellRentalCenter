namespace WellRental.AdminWeb.WellRentalCenter {
    export interface RemissionRow {
        Id?: number;
        SequenceNo?: string;
        MerchantId?: string;
        WithdrawAmount?: number;
        WithdrawDateTime?: string;
        WithdrawStatus?: number;
        ArrivalDateTime?: string;
        Description?: string;
    }

    export namespace RemissionRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SequenceNo';
        export const localTextPrefix = 'WellRentalCenter.Remission';

        export declare const enum Fields {
            Id = "Id",
            SequenceNo = "SequenceNo",
            MerchantId = "MerchantId",
            WithdrawAmount = "WithdrawAmount",
            WithdrawDateTime = "WithdrawDateTime",
            WithdrawStatus = "WithdrawStatus",
            ArrivalDateTime = "ArrivalDateTime",
            Description = "Description"
        }
    }
}
