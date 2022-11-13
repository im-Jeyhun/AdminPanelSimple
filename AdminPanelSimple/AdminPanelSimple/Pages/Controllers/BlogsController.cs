using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Pages.Controllers
{
    public class BlogsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
