using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Dashboard.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
