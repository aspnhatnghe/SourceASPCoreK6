using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopK6.Models
{
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public int MaDh { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        [MaxLength(50)]
        public string MaKh { get; set; }
        public double TongTien { get; set; }
        public TrangThai TrangThai { get; set; }
        public PhuongThucThanhToan PhuongThucThanhToan { get; set; }
        [ForeignKey("MaKh")]
        public KhachHang KhachHang { get; set; }
    }

    [Table("PhuongThucThanhToan")]
    public class PhuongThucThanhToan
    {
        [Key]
        public int MaPt { get; set; }
        [MaxLength(50)]
        [Required]
        public string TenPt { get; set; }
        public string MoTa { get; set; }
    }

    [Table("TrangThaiDonHang")]
    public class TrangThai
    {
        [Key]
        public int MaTt { get; set; }
        [MaxLength(50)]
        [Required]
        public string TenTt { get; set; }
    }
}
