using Microsoft.AspNetCore.Mvc;
using StoreUniversity.DTOs;

namespace StoreUniversity.Controllers
{
    public class AccountController : Controller
    {
        [Route("/register")]
        public IActionResult Register()
        {
            RegisterViewModel vm= new RegisterViewModel();
            return View(vm);
        }
        [HttpPost]
        [Route("/register")]
        public IActionResult Register(RegisterViewModel vm)
        {
            
            return View(vm);
        }
    }
}
