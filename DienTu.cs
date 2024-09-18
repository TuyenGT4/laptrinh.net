namespace BaiTap_KeThua;
class DienTu : SanPham{
    private int baoHanh;

    public DienTu(string tenSanPham, float gia, string moTa, int soLuong, int baoHanh) : base(tenSanPham, gia, moTa, soLuong)
    {
        this.baoHanh = baoHanh;
    }
    public void setBaoHanh(int baoHanh){
        this.baoHanh = baoHanh;
    }
    public int getBaoHanh(){
        return this.baoHanh;
    }
}