
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class RemissionDialog extends Serenity.EntityDialog<RemissionRow, any> {
        protected getFormKey() { return RemissionForm.formKey; }
        protected getIdProperty() { return RemissionRow.idProperty; }
        protected getLocalTextPrefix() { return RemissionRow.localTextPrefix; }
        protected getNameProperty() { return RemissionRow.nameProperty; }
        protected getService() { return RemissionService.baseUrl; }

        protected form = new RemissionForm(this.idPrefix);

    }
}