﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Model_Class
{
    class Class_NguyenLieu_MonAn
    {
        private string MaMonAn;
        private string MaNguyenLieu;
        private string SoLuong;
        public Class_NguyenLieu_MonAn()
        {

        }
        public Class_NguyenLieu_MonAn(string MaMonAn, string MaNguyenLieu, string SoLuong)
        {
            this.MaMonAn = MaMonAn;
            this.MaNguyenLieu = MaNguyenLieu;
            this.SoLuong = SoLuong;
        }

        public string MaMonAn1 { get => MaMonAn; set => MaMonAn = value; }
        public string MaNguyenLieu1 { get => MaNguyenLieu; set => MaNguyenLieu = value; }
        public string SoLuong1 { get => SoLuong; set => SoLuong = value; }
    }
}
