﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Model_Class
{
    class Class_HoaDonNhap
    {
        private string MaHoaDonNhap;
        private string NgayNhap;
        private string MaNhanVien;
        private string MaNhaCungCap;
        private string TongTien;
        public Class_HoaDonNhap()
        {
                
        }
        public Class_HoaDonNhap(string MaHoaDonNhap, string NgayNhap, string MaNhanVien, string MaNhaCungCap, string TongTien)
        {
            this.MaHoaDonNhap = MaHoaDonNhap;
            this.NgayNhap = NgayNhap;
            this.MaNhanVien = MaNhanVien;
            this.MaNhaCungCap = MaNhaCungCap;
            this.TongTien = TongTien;
        
        }

        public string MaHoaDonNhap1 { get => MaHoaDonNhap; set => MaHoaDonNhap = value; }
        public string NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string MaNhaCungCap1 { get => MaNhaCungCap; set => MaNhaCungCap = value; }
        public string TongTien1 { get => TongTien; set => TongTien = value; }
    }


}
