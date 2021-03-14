using Microsoft.AspNetCore.Mvc;

namespace Green4Ever.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
