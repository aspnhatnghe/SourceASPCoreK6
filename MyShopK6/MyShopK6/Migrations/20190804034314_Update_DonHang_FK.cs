using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopK6.Migrations
{
    public partial class Update_DonHang_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_PhuongThucThanhToanMaPt",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_TrangThaiMaTt",
                table: "DonHang");

            migrationBuilder.DropIndex(
                name: "IX_DonHang_PhuongThucThanhToanMaPt",
                table: "DonHang");

            migrationBuilder.DropIndex(
                name: "IX_DonHang_TrangThaiMaTt",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "PhuongThucThanhToanMaPt",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "TrangThaiMaTt",
                table: "DonHang");

            migrationBuilder.AddColumn<int>(
                name: "MaPt",
                table: "DonHang",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaTt",
                table: "DonHang",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaPt",
                table: "DonHang",
                column: "MaPt");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaTt",
                table: "DonHang",
                column: "MaTt");

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_MaPt",
                table: "DonHang",
                column: "MaPt",
                principalTable: "PhuongThucThanhToan",
                principalColumn: "MaPt",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_MaTt",
                table: "DonHang",
                column: "MaTt",
                principalTable: "TrangThaiDonHang",
                principalColumn: "MaTt",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_MaPt",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_MaTt",
                table: "DonHang");

            migrationBuilder.DropIndex(
                name: "IX_DonHang_MaPt",
                table: "DonHang");

            migrationBuilder.DropIndex(
                name: "IX_DonHang_MaTt",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "MaPt",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "MaTt",
                table: "DonHang");

            migrationBuilder.AddColumn<int>(
                name: "PhuongThucThanhToanMaPt",
                table: "DonHang",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrangThaiMaTt",
                table: "DonHang",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_PhuongThucThanhToanMaPt",
                table: "DonHang",
                column: "PhuongThucThanhToanMaPt");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_TrangThaiMaTt",
                table: "DonHang",
                column: "TrangThaiMaTt");

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_PhuongThucThanhToanMaPt",
                table: "DonHang",
                column: "PhuongThucThanhToanMaPt",
                principalTable: "PhuongThucThanhToan",
                principalColumn: "MaPt",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_TrangThaiMaTt",
                table: "DonHang",
                column: "TrangThaiMaTt",
                principalTable: "TrangThaiDonHang",
                principalColumn: "MaTt",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
