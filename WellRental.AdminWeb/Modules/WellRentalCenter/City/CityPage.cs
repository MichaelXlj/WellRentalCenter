
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CityRow))]
    public class CityController : Controller
    {
        [Route("WellRentalCenter/City")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/City/CityIndex.cshtml");
        }
    }
}