
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProvinceRow))]
    public class ProvinceController : Controller
    {
        [Route("WellRentalCenter/Province")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/Province/ProvinceIndex.cshtml");
        }
    }
}