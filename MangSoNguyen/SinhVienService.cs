using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangSoNguyen
{
    public class SinhVienService
    {
        List<SinhVien> lstSinhVien;
        public SinhVienService()
        {
            lstSinhVien = new List<SinhVien>()
            {
                new SinhVien("1", "1", 1, 1, 1, "1"),
                new SinhVien("2", "1", 1, 1, 1, "1"),
                new SinhVien("3", "1", 1, 1, 1, "1"),
                new SinhVien("4", "1", 1, 1, 1, "1"),
                
            };
        }
        public bool Update(SinhVien sinhVien)
        {
            if (! CheckValidate(sinhVien))
            {
                return false;
            }
            int index = lstSinhVien.FindIndex(sv => sv.MaSinhVien1 == sinhVien.MaSinhVien1);
            if (index < 0 )
            {
                return false;
            }
            lstSinhVien[index] = sinhVien;
            return true;
        }
        public bool CheckValidate(SinhVien sinhVien)
        {
            return !string.IsNullOrEmpty(sinhVien.MaSinhVien1) &&
                   !string.IsNullOrEmpty(sinhVien.Ten1) &&
                   sinhVien.Tuoi > 0 &&
                   sinhVien.DiemTrungBinh1 >= 0 &&
                   sinhVien.KyHoc > 0 &&
                   !string.IsNullOrEmpty(sinhVien.ChuyenNghanh1);
        }
    }
}
