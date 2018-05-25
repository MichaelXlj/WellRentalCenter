using Serenity.Services;

namespace WellRental.AdminWeb.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}