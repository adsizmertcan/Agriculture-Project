using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
