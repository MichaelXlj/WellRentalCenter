
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class DistrictDialog extends Serenity.EntityDialog<DistrictRow, any> {
        protected getFormKey() { return DistrictForm.formKey; }
        protected getIdProperty() { return DistrictRow.idProperty; }
        protected getLocalTextPrefix() { return DistrictRow.localTextPrefix; }
        protected getNameProperty() { return DistrictRow.nameProperty; }
        protected getService() { return DistrictService.baseUrl; }

        protected form = new DistrictForm(this.idPrefix);

    }
}