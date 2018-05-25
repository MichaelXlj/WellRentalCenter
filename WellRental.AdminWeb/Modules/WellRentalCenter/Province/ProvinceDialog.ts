
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class ProvinceDialog extends Serenity.EntityDialog<ProvinceRow, any> {
        protected getFormKey() { return ProvinceForm.formKey; }
        protected getIdProperty() { return ProvinceRow.idProperty; }
        protected getLocalTextPrefix() { return ProvinceRow.localTextPrefix; }
        protected getNameProperty() { return ProvinceRow.nameProperty; }
        protected getService() { return ProvinceService.baseUrl; }

        protected form = new ProvinceForm(this.idPrefix);

    }
}