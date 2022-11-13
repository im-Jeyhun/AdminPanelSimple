using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Dashboard.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
