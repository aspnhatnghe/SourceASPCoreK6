using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopK6.Models
{
    public class LoginViewModel
    {
        [MaxLength(150)]
        [Required(ErrorMessage = "*")]        
        public string Email { get; set; }
        [MaxLength(150)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
    }
}
