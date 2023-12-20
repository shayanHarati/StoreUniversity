using System.ComponentModel.DataAnnotations;

namespace StoreUniversity.DTOs
{
    public class RegisterViewModel
    {
        [Display(Name ="نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public string UserName { get; set; }
        [Display(Name ="رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public string Password { get; set; } 
        [Display(Name ="تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        [Compare("Password",ErrorMessage ="{0} با {1} یکسان نیست")]
        public string RePassword { get; set; }
        [Display(Name ="ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        [EmailAddress(ErrorMessage ="{0} وارد شده معتبر نمی باشد")]
        public string Email { get; set; }
    }
}
