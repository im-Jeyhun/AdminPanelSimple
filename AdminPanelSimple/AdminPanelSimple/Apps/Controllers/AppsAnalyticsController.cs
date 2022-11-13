using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Apps.Controllers
{
    public class AppsAnalyticsController : Controller
    {
        public ActionResult Customers()
        {
            return View();
        }
        public ActionResult Reports()
        {
            return View();
        }
    }
}
