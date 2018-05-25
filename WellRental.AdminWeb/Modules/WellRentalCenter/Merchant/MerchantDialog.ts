
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class MerchantDialog extends Serenity.EntityDialog<MerchantRow, any> {
        protected getFormKey() { return MerchantForm.formKey; }
        protected getIdProperty() { return MerchantRow.idProperty; }
        protected getLocalTextPrefix() { return MerchantRow.localTextPrefix; }
        protected getNameProperty() { return MerchantRow.nameProperty; }
        protected getService() { return MerchantService.baseUrl; }

        protected form = new MerchantForm(this.idPrefix);

    }
}