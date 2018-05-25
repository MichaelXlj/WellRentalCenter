namespace WellRental.AdminWeb.WellRentalCenter {
    export interface DistrictForm {
        DistrictName: Serenity.StringEditor;
        CityId: Serenity.StringEditor;
        DateCreated: Serenity.DateEditor;
        DateUpdated: Serenity.DateEditor;
    }

    export class DistrictForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.District';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DistrictForm.init)  {
                DistrictForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(DistrictForm, [
                    'DistrictName', w0,
                    'CityId', w0,
                    'DateCreated', w1,
                    'DateUpdated', w1
                ]);
            }
        }
    }
}
