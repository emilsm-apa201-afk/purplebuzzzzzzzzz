using Microsoft.AspNetCore.Mvc;

namespace purplebuzzzzzzzz.Controllers
{
    public class SinglePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
