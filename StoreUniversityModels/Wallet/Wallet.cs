using StoreUniversityModels.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.Wallet
{
    public class Wallet
    {
        public Wallet()
        {
            
        }
        [Key]
        public int WalletId { get; set; }
        [Display(Name ="تایید شده ")]
        public bool IsPay { get; set; }
        [Display(Name ="مبلغ")]
        public int Amount { get; set; }
        [Display(Name ="شرح")]
        [MaxLength(500,ErrorMessage ="حداکثر طول {0} می تواند {1} باشد ")]
        public string Description { get; set; }
        [Display(Name ="تاریخ و ساعت")]
        public DateTime CreateTime { get; set; }

        [Display(Name ="نوع تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public int TypeId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد  کنید")]
        public int UserId { get; set; }

        public virtual User.User user { get; set; }
        public virtual WalletType  Type { get; set; }
    }
}
