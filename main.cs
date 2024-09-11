class Program
{
    static void Main()
    {
        Bai1_3_5 obj = new Bai1_3_5();

        // Nhập số lượng phần tử và sau đó  nhập các phần tử của mảng
        obj.nhap_n();
        obj.nhapMang();

        // Hiển thị mảng
        obj.xuatMang();

        // Tính tổng các phần tử của mảng
        obj.bai1();

        // Tìm giá trị lớn nhất trong mảng
        obj.bai3();

        // Kiểm tra mảng có phải là mảng đối xứng không
        obj.bai5();
        // Tạo đối tượng của lớp bai2_4_6
        bai2_4_6 obj1 = new bai2_4_6();
        
        // Nhập chuỗi từ người dùng
        obj1.nhapChuoi();
        
        // Thực hiện các hành động
        obj1.bai4();  // Đảo chuỗi và hiển thị
        obj1.Bai2();  // Đếm số lượng ký tự (không tính khoảng cách và dấu câu)
        obj1.bai6();  // Đếm số lần xuất hiện của ký tự
    }
}