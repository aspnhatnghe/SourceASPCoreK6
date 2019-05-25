using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D05_MVCBasic.Models
{
    public class Product
    {
        [Display(Name="Mã hàng hóa")]
        public int Id { get; set; }
        [Display(Name = "Tên hàng hóa")]
        public string Name { get; set; }
        [Display(Name = "Đơn giá")]
        public double Price { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        [Display(Name = "Hết hàng")]
        public bool Empty => Quantity == 0;
    }
}
