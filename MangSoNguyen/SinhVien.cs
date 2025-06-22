using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangSoNguyen
{
    public class SinhVien
    {
        private string MaSinhVien;
        private string Ten;
        private int tuoi;
        private double DiemTrungBinh;
        private int kyHoc;
        private string ChuyenNghanh;
        public SinhVien()
        {
                
        }

        public SinhVien(string maSinhVien, string ten, int tuoi, double diemTrungBinh, int kyHoc, string chuyenNghanh)
        {
            MaSinhVien = maSinhVien;
            Ten = ten;
            this.tuoi = tuoi;
            DiemTrungBinh = diemTrungBinh;
            this.kyHoc = kyHoc;
            ChuyenNghanh = chuyenNghanh;
        }

        public string MaSinhVien1 { get => MaSinhVien; set => MaSinhVien = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double DiemTrungBinh1 { get => DiemTrungBinh; set => DiemTrungBinh = value; }
        public int KyHoc { get => kyHoc; set => kyHoc = value; }
        public string ChuyenNghanh1 { get => ChuyenNghanh; set => ChuyenNghanh = value; }
    }
}
