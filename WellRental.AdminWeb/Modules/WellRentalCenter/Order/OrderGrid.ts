
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class OrderGrid extends Serenity.EntityGrid<OrderRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.Order'; }
        protected getDialogType() { return OrderDialog; }
        protected getIdProperty() { return OrderRow.idProperty; }
        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getService() { return OrderService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}