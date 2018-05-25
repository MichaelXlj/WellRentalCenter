
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class MerchantTypeDialog extends Serenity.EntityDialog<MerchantTypeRow, any> {
        protected getFormKey() { return MerchantTypeForm.formKey; }
        protected getIdProperty() { return MerchantTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MerchantTypeRow.localTextPrefix; }
        protected getNameProperty() { return MerchantTypeRow.nameProperty; }
        protected getService() { return MerchantTypeService.baseUrl; }

        protected form = new MerchantTypeForm(this.idPrefix);

    }
}