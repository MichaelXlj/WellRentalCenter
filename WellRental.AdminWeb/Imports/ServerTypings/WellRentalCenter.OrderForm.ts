namespace WellRental.AdminWeb.WellRentalCenter {
    export interface OrderForm {
        OrderNo: Serenity.StringEditor;
        OpenId: Serenity.StringEditor;
        EstimateLeaveTime: Serenity.DateEditor;
        LastestLeaveTime: Serenity.DateEditor;
        PassengerCount: Serenity.IntegerEditor;
        ProceedPlace: Serenity.StringEditor;
        DestinationPlace: Serenity.StringEditor;
        HasPet: Serenity.BooleanEditor;
        HasLargeLuggage: Serenity.BooleanEditor;
        LuggageWeight: Serenity.DecimalEditor;
        VehicleTypeReq: Serenity.StringEditor;
        RentingType: Serenity.IntegerEditor;
        CustomerPhone: Serenity.StringEditor;
        OrderStatus: Serenity.IntegerEditor;
        SubscribeDateTime: Serenity.DateEditor;
        AuditUser: Serenity.StringEditor;
        AuditDateTime: Serenity.DateEditor;
        TransactionAmount: Serenity.DecimalEditor;
        PrePayAmount: Serenity.DecimalEditor;
    }

    export class OrderForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.Order';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderForm.init)  {
                OrderForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;
                var w4 = s.DecimalEditor;

                Q.initFormType(OrderForm, [
                    'OrderNo', w0,
                    'OpenId', w0,
                    'EstimateLeaveTime', w1,
                    'LastestLeaveTime', w1,
                    'PassengerCount', w2,
                    'ProceedPlace', w0,
                    'DestinationPlace', w0,
                    'HasPet', w3,
                    'HasLargeLuggage', w3,
                    'LuggageWeight', w4,
                    'VehicleTypeReq', w0,
                    'RentingType', w2,
                    'CustomerPhone', w0,
                    'OrderStatus', w2,
                    'SubscribeDateTime', w1,
                    'AuditUser', w0,
                    'AuditDateTime', w1,
                    'TransactionAmount', w4,
                    'PrePayAmount', w4
                ]);
            }
        }
    }
}
