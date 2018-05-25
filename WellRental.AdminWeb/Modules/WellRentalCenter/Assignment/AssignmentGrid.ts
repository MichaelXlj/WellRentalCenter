
namespace WellRental.AdminWeb.WellRentalCenter {

    @Serenity.Decorators.registerClass()
    export class AssignmentGrid extends Serenity.EntityGrid<AssignmentRow, any> {
        protected getColumnsKey() { return 'WellRentalCenter.Assignment'; }
        protected getDialogType() { return AssignmentDialog; }
        protected getIdProperty() { return AssignmentRow.idProperty; }
        protected getLocalTextPrefix() { return AssignmentRow.localTextPrefix; }
        protected getService() { return AssignmentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}