using System.ComponentModel.DataAnnotations;

namespace StoreUniversity.DTOs.Store
{
    public class ProductCartViewModel
    {
        [Display(Name = "تصویر محصول")]
        public string product_Image { get; set; }
        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public string ProductName { get; set; }
        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public int Price { get; set; }
        [Display(Name = "کد تخفیف")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public int percent { get; set; }
    }
}
