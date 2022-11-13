using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Pages.Controllers
{
    public class StarterPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
