using System;
using System.Collections.Generic;

namespace BaiTapQLSV
{
    public class DanhSachSinhVien
    {
        public List<SinhVien> obj { get; set; }

        public DanhSachSinhVien()
        {
            obj = new List<SinhVien>();
        }

        // thêm sinh viên vào list
        public void themSinhVien(SinhVien sv)
        {
            obj.Add(sv);
        }

        //xóa sinh viên khỏi list
        public void xoaSinhVien(SinhVien sv)
        {
            obj.Remove(sv);
        }

        //xóa toàn bộ danh sách
        public void xoaDanhSach()
        {
            obj.Clear();
        }

    }
}

