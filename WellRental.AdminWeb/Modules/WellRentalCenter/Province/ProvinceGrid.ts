
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class ProvinceGrid extends Serenity.EntityGrid<ProvinceRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.Province'; }
        protected getDialogType() { return ProvinceDialog; }
        protected getIdProperty() { return ProvinceRow.idProperty; }
        protected getLocalTextPrefix() { return ProvinceRow.localTextPrefix; }
        protected getService() { return ProvinceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}