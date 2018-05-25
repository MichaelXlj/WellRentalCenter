namespace WellRental.AdminWeb.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'WellRental.AdminWeb.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
