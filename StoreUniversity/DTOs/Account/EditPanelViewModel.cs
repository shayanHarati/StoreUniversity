using System.ComponentModel.DataAnnotations;

namespace StoreUniversity.DTOs.Account
{
    public class EditPanelViewModel
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public string UserName { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        [MinLength(8, ErrorMessage = "حداقل طول {0} باید برابر {1} باشد ")]
        public string Password { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        [EmailAddress(ErrorMessage = "{0} وارد شده معتبر نمی باشد")]
        public string Email { get; set; }


        public IFormFile ImageFile { get; set; }
        public string ImageName { get; set; }
    }
}
