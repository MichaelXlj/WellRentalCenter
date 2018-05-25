
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class CityGrid extends Serenity.EntityGrid<CityRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.City'; }
        protected getDialogType() { return CityDialog; }
        protected getIdProperty() { return CityRow.idProperty; }
        protected getLocalTextPrefix() { return CityRow.localTextPrefix; }
        protected getService() { return CityService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}