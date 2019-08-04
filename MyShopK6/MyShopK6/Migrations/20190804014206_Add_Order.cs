using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopK6.Migrations
{
    public partial class Add_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CTDonHang",
                columns: table => new
                {
                    MaCt = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaHh = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<double>(nullable: false),
                    GiamGia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTDonHang", x => x.MaCt);
                    table.ForeignKey(
                        name: "FK_CTDonHang_HangHoa_MaHh",
                        column: x => x.MaHh,
                        principalTable: "HangHoa",
                        principalColumn: "MaHh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    MaPt = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenPt = table.Column<string>(maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.MaPt);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiDonHang",
                columns: table => new
                {
                    MaTt = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenTt = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiDonHang", x => x.MaTt);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NgayDat = table.Column<DateTime>(nullable: false),
                    NgayGiao = table.Column<DateTime>(nullable: true),
                    MaKh = table.Column<string>(maxLength: 50, nullable: true),
                    TongTien = table.Column<double>(nullable: false),
                    TrangThaiMaTt = table.Column<int>(nullable: true),
                    PhuongThucThanhToanMaPt = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.MaDh);
                    table.ForeignKey(
                        name: "FK_DonHang_KhachHang_MaKh",
                        column: x => x.MaKh,
                        principalTable: "KhachHang",
                        principalColumn: "MaKh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHang_PhuongThucThanhToan_PhuongThucThanhToanMaPt",
                        column: x => x.PhuongThucThanhToanMaPt,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "MaPt",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHang_TrangThaiDonHang_TrangThaiMaTt",
                        column: x => x.TrangThaiMaTt,
                        principalTable: "TrangThaiDonHang",
                        principalColumn: "MaTt",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTDonHang_MaHh",
                table: "CTDonHang",
                column: "MaHh");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaKh",
                table: "DonHang",
                column: "MaKh");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_PhuongThucThanhToanMaPt",
                table: "DonHang",
                column: "PhuongThucThanhToanMaPt");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_TrangThaiMaTt",
                table: "DonHang",
                column: "TrangThaiMaTt");

            //Add giá trị cho Phương thức & Trạng thái
            migrationBuilder.InsertData(
                table: "TrangThaiDonHang",
                columns: new[] { "MaTt", "TenTt" },
                values: new object[]
                {
                    1, "Mới đặt hàng"
                }
            );
            migrationBuilder.InsertData(
                table: "TrangThaiDonHang",
                columns: new[] { "MaTt", "TenTt" },
                values: new object[]
                {
                    2, "Đã xác nhận"
                }
            );
            migrationBuilder.InsertData(
                table: "TrangThaiDonHang",
                columns: new[] { "MaTt", "TenTt" },
                values: new object[]
                {
                    3, "Đã thanh toán"
                }
            );
            migrationBuilder.InsertData(
                table: "TrangThaiDonHang",
                columns: new[] { "MaTt", "TenTt" },
                values: new object[]
                {
                    4, "Hoàn tất"
                }
            );
            migrationBuilder.InsertData(
                table: "TrangThaiDonHang",
                columns: new[] { "MaTt", "TenTt" },
                values: new object[]
                {
                    5, "Hủy đơn hàng"
                }
            );
            migrationBuilder.InsertData(
                table: "PhuongThucThanhToan",
                columns: new[] { "MaPt", "TenPt", "MoTa" },
                values: new object[]
                {
                    1, "Tiền mặt", "Giao hàng nhận tiền"
                }
            );
            migrationBuilder.InsertData(
                table: "PhuongThucThanhToan",
                columns: new[] { "MaPt", "TenPt", "MoTa" },
                values: new object[]
                {
                    2, "Trực tuyến", "Online Banking"
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTDonHang");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DeleteData(
                table: "PhuongThucThanhToan",
                keyColumn: "MaPt",
                keyValue: 1
            );

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "TrangThaiDonHang");
        }
    }
}
