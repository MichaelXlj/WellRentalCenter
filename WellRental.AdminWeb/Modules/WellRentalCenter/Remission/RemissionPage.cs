
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.RemissionRow))]
    public class RemissionController : Controller
    {
        [Route("WellRentalCenter/Remission")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/Remission/RemissionIndex.cshtml");
        }
    }
}