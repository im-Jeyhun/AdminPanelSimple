using Microsoft.AspNetCore.Mvc;

namespace AdminPanelSimple.Apps.Controllers
{
    public class ChatController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
