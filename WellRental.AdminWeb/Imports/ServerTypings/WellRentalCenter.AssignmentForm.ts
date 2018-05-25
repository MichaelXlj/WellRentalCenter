namespace WellRental.AdminWeb.WellRentalCenter {
    export interface AssignmentForm {
        OrderNo: Serenity.StringEditor;
        PlateNumber: Serenity.StringEditor;
        DriverName: Serenity.StringEditor;
        DriverPhone: Serenity.StringEditor;
        AssignmentStatus: Serenity.IntegerEditor;
        AuditUser: Serenity.StringEditor;
        AuditDateTime: Serenity.DateEditor;
    }

    export class AssignmentForm extends Serenity.PrefixedContext {
        static formKey = 'WellRentalCenter.Assignment';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AssignmentForm.init)  {
                AssignmentForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(AssignmentForm, [
                    'OrderNo', w0,
                    'PlateNumber', w0,
                    'DriverName', w0,
                    'DriverPhone', w0,
                    'AssignmentStatus', w1,
                    'AuditUser', w0,
                    'AuditDateTime', w2
                ]);
            }
        }
    }
}
