using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nhom18.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<Nhom18.Models.Nhacungcap> Nhacungcap { get; set; } = default!;

        public DbSet<Nhom18.Models.Sanpham> Sanpham { get; set; } = default!;

        public DbSet<Nhom18.Models.Nhanvien> Nhanvien { get; set; } = default!;

        public DbSet<Nhom18.Models.Nhaphang> Nhaphang { get; set; } = default!;

        public DbSet<Nhom18.Models.Khachhang> Khachhang { get; set; } = default!;

        public DbSet<Nhom18.Models.Hoadon> Hoadon { get; set; } = default!;

       
    }
