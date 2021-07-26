using Microsoft.AspNetCore.Mvc;

namespace IndiaMart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}