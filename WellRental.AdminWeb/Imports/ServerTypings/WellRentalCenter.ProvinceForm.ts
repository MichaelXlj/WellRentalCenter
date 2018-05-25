namespace WellRental.AdminWeb.WellRentalCenter {
    export interface ProvinceForm {
        ProvinceName: Serenity.StringEditor;
        DateCreated: Serenity.DateEditor;
        DateUpdated: Serenity.DateEditor;
    }

    export class ProvinceForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.Province';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProvinceForm.init)  {
                ProvinceForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(ProvinceForm, [
                    'ProvinceName', w0,
                    'DateCreated', w1,
                    'DateUpdated', w1
                ]);
            }
        }
    }
}
