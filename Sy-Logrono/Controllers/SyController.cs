using Microsoft.AspNetCore.Mvc;

namespace Sy_Logrono.Controllers
{
    public class SyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
