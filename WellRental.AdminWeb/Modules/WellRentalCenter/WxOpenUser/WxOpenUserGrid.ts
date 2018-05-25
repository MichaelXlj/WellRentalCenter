
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class WxOpenUserGrid extends Serenity.EntityGrid<WxOpenUserRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.WxOpenUser'; }
        protected getDialogType() { return WxOpenUserDialog; }
        protected getIdProperty() { return WxOpenUserRow.idProperty; }
        protected getLocalTextPrefix() { return WxOpenUserRow.localTextPrefix; }
        protected getService() { return WxOpenUserService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}