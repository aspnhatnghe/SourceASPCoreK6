using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopK6.Models
{
    public class CheckoutModelView
    {
        [Display(Name ="Người nhận")]
        public string NguoiNhan { get; set; }
        [Display(Name = "Địa chỉ giao")]
        public string DiaChiGiao { get; set; }
        [Display(Name = "Phương thức thanh toán")]
        public int MaPt { get; set; }
        public int MaTt { get; set; }
    }
}
