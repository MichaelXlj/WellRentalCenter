
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class MerchantGrid extends Serenity.EntityGrid<MerchantRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.Merchant'; }
        protected getDialogType() { return MerchantDialog; }
        protected getIdProperty() { return MerchantRow.idProperty; }
        protected getLocalTextPrefix() { return MerchantRow.localTextPrefix; }
        protected getService() { return MerchantService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}