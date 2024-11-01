using System;

namespace BaiTapQLSV
{
    public class SinhVien
    {
        public int maSV { get; set; }
        public string tenSV { get; set; }
        public string gioiTinh { get; set; }
        public DateOnly ngaySinh { get; set; } // chỉ lưu ngày tháng năm
        public string diaChi { get; set; }
        public string email { get; set; }
        public string soDienThoai { get; set; }

        public SinhVien(int masv, string tensv, string gioiTinh, DateOnly ngaysinh, string diachi, string email, string sodienthoai)
        {
            this.maSV = masv;
            this.tenSV = tensv;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaysinh;
            this.diaChi = diachi;
            this.email = email;
            this.soDienThoai = sodienthoai;
        }

    }
}

