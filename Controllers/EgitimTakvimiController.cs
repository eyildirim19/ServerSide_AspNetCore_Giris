using Microsoft.AspNetCore.Mvc;

namespace Giris.Controllers
{
    public class EgitimTakvimiController : Controller
    {
        public IActionResult Index()
        {
            // view name belirtiyoruz...
            return View("benimsayfam");
        }
    }
}
