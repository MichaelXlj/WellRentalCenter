
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.MerchantTypeRow))]
    public class MerchantTypeController : Controller
    {
        [Route("WellRentalCenter/MerchantType")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/MerchantType/MerchantTypeIndex.cshtml");
        }
    }
}