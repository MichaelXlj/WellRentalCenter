namespace WellRental.AdminWeb.WellRentalCenter {
    export interface MerchantTypeForm {
        TypeId: Serenity.StringEditor;
        TypeName: Serenity.StringEditor;
    }

    export class MerchantTypeForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.MerchantType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MerchantTypeForm.init)  {
                MerchantTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MerchantTypeForm, [
                    'TypeId', w0,
                    'TypeName', w0
                ]);
            }
        }
    }
}
