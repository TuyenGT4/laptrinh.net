
namespace BaiTap_KeThua;
class ThucPham : SanPham{
    private DateTime ExpirationDate { get; set; }
    public ThucPham(string tenSanPham, float gia, string moTa, int soLuong, DateTime expirationDate) : base(tenSanPham, gia, moTa, soLuong)
    {
        this.ExpirationDate = expirationDate;
    }
}