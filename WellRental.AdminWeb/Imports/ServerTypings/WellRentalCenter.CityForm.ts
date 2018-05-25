namespace WellRental.AdminWeb.WellRentalCenter {
    export interface CityForm {
        CityName: Serenity.StringEditor;
        ZipCode: Serenity.StringEditor;
        ProvinceId: Serenity.StringEditor;
        DateCreated: Serenity.DateEditor;
        DateUpdated: Serenity.DateEditor;
    }

    export class CityForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.City';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CityForm.init)  {
                CityForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(CityForm, [
                    'CityName', w0,
                    'ZipCode', w0,
                    'ProvinceId', w0,
                    'DateCreated', w1,
                    'DateUpdated', w1
                ]);
            }
        }
    }
}
