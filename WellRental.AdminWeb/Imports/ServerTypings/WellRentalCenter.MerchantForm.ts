namespace WellRental.AdminWeb.WellRentalCenter {
    export interface MerchantForm {
        MerchantId: Serenity.StringEditor;
        MerchantTypeId: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        RebateAmount: Serenity.DecimalEditor;
        RespoPerson: Serenity.StringEditor;
        RespoPhone: Serenity.StringEditor;
        Attest1: Serenity.StringEditor;
        Attest2: Serenity.StringEditor;
        Attest3: Serenity.StringEditor;
        Attest4: Serenity.StringEditor;
        Attest5: Serenity.StringEditor;
        AliPayAccount: Serenity.StringEditor;
        WeiXinPayAccount: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Longitude: Serenity.DecimalEditor;
        Latitude: Serenity.DecimalEditor;
        Contactor: Serenity.StringEditor;
        ContactPhone: Serenity.StringEditor;
        QrCode: Serenity.StringEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreateDateTime: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdateDateTime: Serenity.DateEditor;
    }

    export class MerchantForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.Merchant';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MerchantForm.init)  {
                MerchantForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;

                Q.initFormType(MerchantForm, [
                    'MerchantId', w0,
                    'MerchantTypeId', w0,
                    'Name', w0,
                    'RebateAmount', w1,
                    'RespoPerson', w0,
                    'RespoPhone', w0,
                    'Attest1', w0,
                    'Attest2', w0,
                    'Attest3', w0,
                    'Attest4', w0,
                    'Attest5', w0,
                    'AliPayAccount', w0,
                    'WeiXinPayAccount', w0,
                    'Address', w0,
                    'Longitude', w1,
                    'Latitude', w1,
                    'Contactor', w0,
                    'ContactPhone', w0,
                    'QrCode', w0,
                    'CreatedBy', w2,
                    'CreateDateTime', w3,
                    'UpdatedBy', w2,
                    'UpdateDateTime', w3
                ]);
            }
        }
    }
}
