using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using StoreUniversity.Core;
using StoreUniversity.DTOs.Account;
using StoreUniversity.Services.UserServices;
using System.Security.Claims;
using StoreUniversityModels.User;

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
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            if (!user.IsExistsThisUser(vm.Password.Normalize_1d(),vm.UserName.Normalize_1d()))
            {
                ModelState.AddModelError("Password","رمز عبور یا نام کاربری درست وارد نشده است");
                return View(vm);
            }
            var user_selected = user.FindUser(vm.UserName);
            List<Claim> info = new List<Claim>()
            {
                new Claim (ClaimTypes.NameIdentifier,user_selected.Id.ToString()),
                new Claim(ClaimTypes.Name,vm.UserName)

            };

            var identity = new ClaimsIdentity(info, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var propeties = new AuthenticationProperties()
            {
                AllowRefresh = true
            };
            HttpContext.SignInAsync(principal, propeties);

            return Redirect("/");
        }
        [Route("/logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }

        [Route("/panel")]
        public IActionResult panel(string Username)
        {
            PanelViewModel vm = new PanelViewModel();
            vm.User = user.FindUser(Username);
            return View(vm);
        }
        [HttpPost]
        public IActionResult EditInfo(PanelViewModel _user)
        {
            User us = new User()
            {
                UserName = _user.User.UserName,
                Email = _user.User.Email,
                Password = _user.User.Password,
                Id = _user.User.Id
            };
            user.UpdateUser(us);

            PanelViewModel ee = new PanelViewModel();
            ee.User = user.FindUser(us.UserName);
            return RedirectToAction("panel", ee);
        }
    }
}

