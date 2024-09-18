namespace BaiTap_KeThua;
class QuanAo : SanPham{
    private int kichThuoc {get; set; }
    private string mauSac{get; set;} 

    public QuanAo(string tenSanPham, float gia, string moTa, int soLuong, int kichThuoc, string mauSac) : base(tenSanPham, gia, moTa, soLuong){
        this.kichThuoc = kichThuoc;
        this.mauSac = mauSac;
    }    
}