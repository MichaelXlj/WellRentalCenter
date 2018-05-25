
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class MerchantTypeGrid extends Serenity.EntityGrid<MerchantTypeRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.MerchantType'; }
        protected getDialogType() { return MerchantTypeDialog; }
        protected getIdProperty() { return MerchantTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MerchantTypeRow.localTextPrefix; }
        protected getService() { return MerchantTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}