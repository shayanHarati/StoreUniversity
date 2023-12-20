using Microsoft.AspNetCore.Mvc;

namespace StoreUniversity.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}
