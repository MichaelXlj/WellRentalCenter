
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.DistrictRow))]
    public class DistrictController : Controller
    {
        [Route("WellRentalCenter/District")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/District/DistrictIndex.cshtml");
        }
    }
}