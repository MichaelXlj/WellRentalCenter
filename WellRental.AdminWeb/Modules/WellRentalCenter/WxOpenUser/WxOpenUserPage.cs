
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.WxOpenUserRow))]
    public class WxOpenUserController : Controller
    {
        [Route("WellRentalCenter/WxOpenUser")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/WxOpenUser/WxOpenUserIndex.cshtml");
        }
    }
}