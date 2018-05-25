
namespace WellRental.AdminWeb.WellRentalCenter.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.AssignmentRow))]
    public class AssignmentController : Controller
    {
        [Route("WellRentalCenter/Assignment")]
        public ActionResult Index()
        {
            return View("~/Modules/WellRentalCenter/Assignment/AssignmentIndex.cshtml");
        }
    }
}