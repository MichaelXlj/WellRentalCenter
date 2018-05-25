
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class AssignmentDialog extends Serenity.EntityDialog<AssignmentRow, any> {
        protected getFormKey() { return AssignmentForm.formKey; }
        protected getIdProperty() { return AssignmentRow.idProperty; }
        protected getLocalTextPrefix() { return AssignmentRow.localTextPrefix; }
        protected getNameProperty() { return AssignmentRow.nameProperty; }
        protected getService() { return AssignmentService.baseUrl; }

        protected form = new AssignmentForm(this.idPrefix);

    }
}