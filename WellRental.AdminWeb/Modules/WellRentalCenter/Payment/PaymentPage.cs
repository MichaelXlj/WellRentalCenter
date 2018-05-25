
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PaymentRow))]
    public class PaymentController : Controller
    {
        [Route("WellRentalCenter/Payment")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/Payment/PaymentIndex.cshtml");
        }
    }
}