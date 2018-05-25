
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class DistrictGrid extends Serenity.EntityGrid<DistrictRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.District'; }
        protected getDialogType() { return DistrictDialog; }
        protected getIdProperty() { return DistrictRow.idProperty; }
        protected getLocalTextPrefix() { return DistrictRow.localTextPrefix; }
        protected getService() { return DistrictService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}