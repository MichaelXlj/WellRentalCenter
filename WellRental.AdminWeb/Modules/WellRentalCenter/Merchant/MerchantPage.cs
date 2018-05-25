
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.MerchantRow))]
    public class MerchantController : Controller
    {
        [Route("WellRentalCenter/Merchant")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/Merchant/MerchantIndex.cshtml");
        }
    }
}