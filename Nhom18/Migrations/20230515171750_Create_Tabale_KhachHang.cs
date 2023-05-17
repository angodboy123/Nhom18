using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom18.Migrations
{
    /// <inheritdoc />
    public partial class CreateTabaleKhachHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khachhang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "TEXT", nullable: false),
                    TenKH = table.Column<string>(type: "TEXT", nullable: true),
                    NgaysinhKH = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiachiKH = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "Nhacungcap",
                columns: table => new
                {
                    MaNCC = table.Column<string>(type: "TEXT", nullable: false),
                    TenNCC = table.Column<string>(type: "TEXT", nullable: true),
                    SdtNCC = table.Column<string>(type: "TEXT", nullable: true),
                    DiachiNCC = table.Column<string>(type: "TEXT", nullable: true),
                    EmailNCC = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhacungcap", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "TEXT", nullable: false),
                    TenNV = table.Column<string>(type: "TEXT", nullable: true),
                    NgaysinhNV = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SdtNV = table.Column<string>(type: "TEXT", nullable: true),
                    DiachiNV = table.Column<string>(type: "TEXT", nullable: true),
                    EmailNV = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "Sanpham",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "TEXT", nullable: false),
                    TenSP = table.Column<string>(type: "TEXT", nullable: true),
                    GiaSP = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanpham", x => x.MaSP);
                });

            migrationBuilder.CreateTable(
                name: "Hoadon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "TEXT", nullable: false),
                    TenKH = table.Column<string>(type: "TEXT", nullable: true),
                    TenSP = table.Column<string>(type: "TEXT", nullable: true),
                    SoluongHD = table.Column<int>(type: "INTEGER", nullable: false),
                    Ngayban = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_Hoadon_Khachhang_TenKH",
                        column: x => x.TenKH,
                        principalTable: "Khachhang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK_Hoadon_Sanpham_TenSP",
                        column: x => x.TenSP,
                        principalTable: "Sanpham",
                        principalColumn: "MaSP");
                });

            migrationBuilder.CreateTable(
                name: "Nhaphang",
                columns: table => new
                {
                    IDNH = table.Column<string>(type: "TEXT", nullable: false),
                    TenSP = table.Column<string>(type: "TEXT", nullable: true),
                    SoluongSP = table.Column<string>(type: "TEXT", nullable: true),
                    TenNCC = table.Column<string>(type: "TEXT", nullable: true),
                    TenNV = table.Column<string>(type: "TEXT", nullable: true),
                    NgaynhapSP = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhaphang", x => x.IDNH);
                    table.ForeignKey(
                        name: "FK_Nhaphang_Nhacungcap_TenNCC",
                        column: x => x.TenNCC,
                        principalTable: "Nhacungcap",
                        principalColumn: "MaNCC");
                    table.ForeignKey(
                        name: "FK_Nhaphang_Nhanvien_TenNV",
                        column: x => x.TenNV,
                        principalTable: "Nhanvien",
                        principalColumn: "MaNV");
                    table.ForeignKey(
                        name: "FK_Nhaphang_Sanpham_TenSP",
                        column: x => x.TenSP,
                        principalTable: "Sanpham",
                        principalColumn: "MaSP");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_TenKH",
                table: "Hoadon",
                column: "TenKH");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_TenSP",
                table: "Hoadon",
                column: "TenSP");

            migrationBuilder.CreateIndex(
                name: "IX_Nhaphang_TenNCC",
                table: "Nhaphang",
                column: "TenNCC");

            migrationBuilder.CreateIndex(
                name: "IX_Nhaphang_TenNV",
                table: "Nhaphang",
                column: "TenNV");

            migrationBuilder.CreateIndex(
                name: "IX_Nhaphang_TenSP",
                table: "Nhaphang",
                column: "TenSP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hoadon");

            migrationBuilder.DropTable(
                name: "Nhaphang");

            migrationBuilder.DropTable(
                name: "Khachhang");

            migrationBuilder.DropTable(
                name: "Nhacungcap");

            migrationBuilder.DropTable(
                name: "Nhanvien");

            migrationBuilder.DropTable(
                name: "Sanpham");
        }
    }
}
