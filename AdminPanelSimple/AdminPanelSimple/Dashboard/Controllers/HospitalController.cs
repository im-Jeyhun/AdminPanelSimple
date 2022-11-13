using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Dashboard.Controllers
{
    public class HospitalController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
