using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace D14_EFCore_CodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        //Khai báo các thuộc tính bên trong (tương ứng tạo thành các bảng)
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        //hàm tạo có tham số sử dụng chuỗi kết nối ở ConfigureService() trong class StartUp
        public MyDbContext(DbContextOptions opt): base(opt)
        {
        }

        public MyDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //chỉ định loại CSDL dùng và chuỗi kết nối
            //đọc chuỗi kết nối từ appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("EFCodeFirst"));
            //optionsBuilder.UseSqlServer("Server=.; Database=EFCodeFirst; Integrated Security=True;");            
        }
    }
}
