
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class RemissionGrid extends Serenity.EntityGrid<RemissionRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.Remission'; }
        protected getDialogType() { return RemissionDialog; }
        protected getIdProperty() { return RemissionRow.idProperty; }
        protected getLocalTextPrefix() { return RemissionRow.localTextPrefix; }
        protected getService() { return RemissionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}