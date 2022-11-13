using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Dashboard.Controllers
{
    public class CryptoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
