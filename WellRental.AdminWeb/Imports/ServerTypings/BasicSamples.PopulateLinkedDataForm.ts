namespace WellRental.AdminWeb.BasicSamples {
    export interface PopulateLinkedDataForm {
        CustomerID: AdminWeb.Northwind.CustomerEditor;
        CustomerContactName: Serenity.StringEditor;
        CustomerContactTitle: Serenity.StringEditor;
        CustomerCity: Serenity.StringEditor;
        CustomerRegion: Serenity.StringEditor;
        CustomerCountry: Serenity.StringEditor;
        CustomerPhone: Serenity.StringEditor;
        CustomerFax: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        RequiredDate: Serenity.DateEditor;
        EmployeeID: Serenity.LookupEditor;
        DetailList: AdminWeb.Northwind.OrderDetailsEditor;
    }

    export class PopulateLinkedDataForm extends Serenity.PrefixedContext {
        static formKey = 'BasicSamples.PopulateLinkedData';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PopulateLinkedDataForm.init)  {
                PopulateLinkedDataForm.init = true;

                var s = Serenity;
                var w0 = AdminWeb.Northwind.CustomerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.LookupEditor;
                var w4 = AdminWeb.Northwind.OrderDetailsEditor;

                Q.initFormType(PopulateLinkedDataForm, [
                    'CustomerID', w0,
                    'CustomerContactName', w1,
                    'CustomerContactTitle', w1,
                    'CustomerCity', w1,
                    'CustomerRegion', w1,
                    'CustomerCountry', w1,
                    'CustomerPhone', w1,
                    'CustomerFax', w1,
                    'OrderDate', w2,
                    'RequiredDate', w2,
                    'EmployeeID', w3,
                    'DetailList', w4
                ]);
            }
        }
    }
}
