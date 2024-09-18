using System;
namespace BaiTap_KeThua;
class SanPham{
    private string tenSanPham, moTa;
    private float gia;
    private int soLuong;

    public SanPham(string tenSanPham, float gia, string moTa, int soLuong){
        this.tenSanPham = tenSanPham;
        this.gia = gia;
        this.moTa = moTa;
        this.soLuong = soLuong;
    }
    public string getTenSanPham(){
        return this.tenSanPham;
    }
    public float getGia(){
        return this.gia;
    }
    public string getMoTa(){
        return this.moTa;
    }
    public int getSoLuong(){
        return this.soLuong;
    }

    public void setTenSanPham(string tenSanPham){
        this.tenSanPham = tenSanPham;
    }
    public void setGia(float gia){
        this.gia = gia;
    }
    public void setMoTa(string moTa){
        this.moTa = moTa;
    }
    public void setSoLuong(int soLuong){
        this.soLuong = soLuong;
    }

    public void hienThi(){
        Console.WriteLine("Ten san pham: "+this.tenSanPham+", Gia: "+this.gia+", Mo ta: "+this.moTa+", So luong: "+this.soLuong);
    }
}



