using Microsoft.AspNetCore.Mvc;
using StoreUniversity.Core;
using StoreUniversity.DTOs.Account;
using StoreUniversity.Services.UserServices;

namespace StoreUniversity.Controllers
{
    public class AccountController : Controller
    {
        private IUser user;
        public AccountController(IUser _user)
        {
            user=_user;
        }
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
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            // userName is Unique
            if (user.IsExistsThisUser(vm.UserName.Normalize_1d()))
            {
                ModelState.AddModelError("UserName", "کاریری با نام کاربری وارد شده ثبت نام گردیده است ");
                return View(vm);
            }

            // Email is Unique
            if (user.IsExistsThisUserEmail(vm.Email.Normalize_2d()))
            {
                ModelState.AddModelError("Email", "کاریری با ایمیل وارد شده ثبت نام گردیده است ");
                return View(vm);
            }

            user.RegisterUser(vm);

            return Redirect("/Login");

        }

        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("/Login")]
        public IActionResult Login(LoginViewModel vm)
        {
            return View();
        }
    }
}

