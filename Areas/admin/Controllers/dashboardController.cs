using Microsoft.AspNetCore.Mvc;

namespace Project.Areas.admin.Controllers
{
    public class dashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
