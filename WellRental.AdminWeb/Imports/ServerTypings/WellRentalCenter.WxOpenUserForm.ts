namespace WellRental.AdminWeb.WellRentalCenter {
    export interface WxOpenUserForm {
        OpenId: Serenity.StringEditor;
        NickName: Serenity.StringEditor;
        Sex: Serenity.IntegerEditor;
        City: Serenity.StringEditor;
        Province: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        HeadImhUrl: Serenity.StringEditor;
        EntranceMerchant: Serenity.StringEditor;
        Mobile: Serenity.StringEditor;
        VisitCount: Serenity.IntegerEditor;
        LastVisitDateTime: Serenity.DateEditor;
    }

    export class WxOpenUserForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.WxOpenUser';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!WxOpenUserForm.init)  {
                WxOpenUserForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(WxOpenUserForm, [
                    'OpenId', w0,
                    'NickName', w0,
                    'Sex', w1,
                    'City', w0,
                    'Province', w0,
                    'Country', w0,
                    'HeadImhUrl', w0,
                    'EntranceMerchant', w0,
                    'Mobile', w0,
                    'VisitCount', w1,
                    'LastVisitDateTime', w2
                ]);
            }
        }
    }
}
