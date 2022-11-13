using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Dashboard.Controllers
{
    public class EcommerceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
