﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Nhom18.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20221206145740_Khachhang")]
    partial class Khachhang
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Nhom18.Models.Hoadon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Ngayban")
                        .HasColumnType("TEXT");

                    b.Property<int>("SoluongHD")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenKH")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSP")
                        .HasColumnType("TEXT");

                    b.HasKey("MaHD");

                    b.HasIndex("TenKH");

                    b.HasIndex("TenSP");

                    b.ToTable("Hoadon");
                });

            modelBuilder.Entity("Nhom18.Models.Khachhang", b =>
                {
                    b.Property<string>("MaKH")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiachiKH")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaysinhKH")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKH")
                        .HasColumnType("TEXT");

                    b.HasKey("MaKH");

                    b.ToTable("Khachhang");
                });

            modelBuilder.Entity("Nhom18.Models.Nhacungcap", b =>
                {
                    b.Property<string>("MaNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiachiNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("SdtNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNCC")
                        .HasColumnType("TEXT");

                    b.HasKey("MaNCC");

                    b.ToTable("Nhacungcap");
                });

            modelBuilder.Entity("Nhom18.Models.Nhanvien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiachiNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailNV")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaysinhNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("SdtNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .HasColumnType("TEXT");

                    b.HasKey("MaNV");

                    b.ToTable("Nhanvien");
                });

            modelBuilder.Entity("Nhom18.Models.Nhaphang", b =>
                {
                    b.Property<string>("IDNH")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaynhapSP")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoluongSP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSP")
                        .HasColumnType("TEXT");

                    b.HasKey("IDNH");

                    b.HasIndex("TenNCC");

                    b.HasIndex("TenNV");

                    b.HasIndex("TenSP");

                    b.ToTable("Nhaphang");
                });

            modelBuilder.Entity("Nhom18.Models.Sanpham", b =>
                {
                    b.Property<string>("MaSP")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("GiaSP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSP")
                        .HasColumnType("TEXT");

                    b.HasKey("MaSP");

                    b.ToTable("Sanpham");
                });

            modelBuilder.Entity("Nhom18.Models.Hoadon", b =>
                {
                    b.HasOne("Nhom18.Models.Khachhang", "Khachhang")
                        .WithMany()
                        .HasForeignKey("TenKH");

                    b.HasOne("Nhom18.Models.Sanpham", "Sanpham")
                        .WithMany()
                        .HasForeignKey("TenSP");

                    b.Navigation("Khachhang");

                    b.Navigation("Sanpham");
                });

            modelBuilder.Entity("Nhom18.Models.Nhaphang", b =>
                {
                    b.HasOne("Nhom18.Models.Nhacungcap", "Nhacungcap")
                        .WithMany()
                        .HasForeignKey("TenNCC");

                    b.HasOne("Nhom18.Models.Nhanvien", "Nhanvien")
                        .WithMany()
                        .HasForeignKey("TenNV");

                    b.HasOne("Nhom18.Models.Sanpham", "Sanpham")
                        .WithMany()
                        .HasForeignKey("TenSP");

                    b.Navigation("Nhacungcap");

                    b.Navigation("Nhanvien");

                    b.Navigation("Sanpham");
                });
#pragma warning restore 612, 618
        }
    }
}
