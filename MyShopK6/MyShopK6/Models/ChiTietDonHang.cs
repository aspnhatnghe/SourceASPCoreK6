using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopK6.Models
{
    [Table("CTDonHang")]
    public class ChiTietDonHang
    {
        [Key]
        public int MaCt { get; set; }
        public int MaHh { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public int GiamGia{ get; set; }
        public double GiaBan => DonGia * (100 - GiamGia) / 100.0;
        public double ThanhTien => SoLuong * GiaBan;
        [ForeignKey("MaHh")]
        public HangHoa HangHoa { get; set; }
    }
}
