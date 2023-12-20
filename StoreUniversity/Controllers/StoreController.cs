using Microsoft.AspNetCore.Mvc;

namespace StoreUniversity.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
