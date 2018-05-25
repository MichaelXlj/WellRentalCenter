
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class PaymentGrid extends Serenity.EntityGrid<PaymentRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.Payment'; }
        protected getDialogType() { return PaymentDialog; }
        protected getIdProperty() { return PaymentRow.idProperty; }
        protected getLocalTextPrefix() { return PaymentRow.localTextPrefix; }
        protected getService() { return PaymentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}