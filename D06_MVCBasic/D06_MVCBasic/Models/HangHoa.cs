using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D06_MVCBasic.Models
{
    public class HangHoa
    {
        [Key]
        [Display(Name ="Mã hàng hóa")]
        public int MaHh { get; set; }
        [Display(Name = "Tên hàng hóa")]
        public string TenHh { get; set; }
        [Display(Name = "Hình")]
        public string Hinh { get; set; }
        [Display(Name = "Đơn giá")]
        public double DonGia { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
    }
}
