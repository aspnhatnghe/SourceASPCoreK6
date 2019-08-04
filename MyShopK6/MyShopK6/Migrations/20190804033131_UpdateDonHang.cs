using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopK6.Migrations
{
    public partial class UpdateDonHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiaChiGiao",
                table: "DonHang",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiNhan",
                table: "DonHang",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChiGiao",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "NguoiNhan",
                table: "DonHang");
        }
    }
}
