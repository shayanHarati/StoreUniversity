using System.ComponentModel.DataAnnotations;

namespace StoreUniversity.DTOs.Account
{
    public class LoginViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public string UserName { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public string Password { get; set; }
    }
}
