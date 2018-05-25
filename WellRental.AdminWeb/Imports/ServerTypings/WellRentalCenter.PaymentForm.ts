namespace WellRental.AdminWeb.WellRentalCenter {
    export interface PaymentForm {
        OrderNo: Serenity.StringEditor;
        PaymentMethod: Serenity.IntegerEditor;
        PaidDateTime: Serenity.DateEditor;
        Amount: Serenity.DecimalEditor;
        PaymentCatalog: Serenity.IntegerEditor;
        SequnceNo: Serenity.StringEditor;
    }

    export class PaymentForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.Payment';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PaymentForm.init)  {
                PaymentForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;
                var w3 = s.DecimalEditor;

                Q.initFormType(PaymentForm, [
                    'OrderNo', w0,
                    'PaymentMethod', w1,
                    'PaidDateTime', w2,
                    'Amount', w3,
                    'PaymentCatalog', w1,
                    'SequnceNo', w0
                ]);
            }
        }
    }
}
