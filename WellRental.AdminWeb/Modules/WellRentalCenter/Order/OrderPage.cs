
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.OrderRow))]
    public class OrderController : Controller
    {
        [Route("WellRentalCenter/Order")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/Order/OrderIndex.cshtml");
        }
    }
}