namespace WellRental.AdminWeb.WellRentalCenter {
    export interface RemissionForm {
        SequenceNo: Serenity.StringEditor;
        MerchantId: Serenity.StringEditor;
        WithdrawAmount: Serenity.DecimalEditor;
        WithdrawDateTime: Serenity.DateEditor;
        WithdrawStatus: Serenity.IntegerEditor;
        ArrivalDateTime: Serenity.DateEditor;
        Description: Serenity.StringEditor;
    }

    export class RemissionForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.Remission';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RemissionForm.init)  {
                RemissionForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.DateEditor;
                var w3 = s.IntegerEditor;

                Q.initFormType(RemissionForm, [
                    'SequenceNo', w0,
                    'MerchantId', w0,
                    'WithdrawAmount', w1,
                    'WithdrawDateTime', w2,
                    'WithdrawStatus', w3,
                    'ArrivalDateTime', w2,
                    'Description', w0
                ]);
            }
        }
    }
}
