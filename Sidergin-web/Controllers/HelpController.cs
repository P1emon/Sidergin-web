using Microsoft.AspNetCore.Mvc;

namespace Sidergin_web.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
