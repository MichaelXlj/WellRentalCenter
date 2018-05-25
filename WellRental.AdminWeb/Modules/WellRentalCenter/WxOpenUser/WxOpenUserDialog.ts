
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class WxOpenUserDialog extends Serenity.EntityDialog<WxOpenUserRow, any> {
        protected getFormKey() { return WxOpenUserForm.formKey; }
        protected getIdProperty() { return WxOpenUserRow.idProperty; }
        protected getLocalTextPrefix() { return WxOpenUserRow.localTextPrefix; }
        protected getNameProperty() { return WxOpenUserRow.nameProperty; }
        protected getService() { return WxOpenUserService.baseUrl; }

        protected form = new WxOpenUserForm(this.idPrefix);

    }
}