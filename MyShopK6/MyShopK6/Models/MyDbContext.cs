using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopK6.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Loai> Loais { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<TrangThai> TrangThais { get; set; }
        public DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}
