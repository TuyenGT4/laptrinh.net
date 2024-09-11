using System;
class bai2_4_6{
    public string chuoikitu="";

    public void nhapChuoi(){
        Console.WriteLine("Nhap chuoi: ");
        this.chuoikitu = Console.ReadLine() ?? string.Empty;  // Đảm bảo chuỗi không phải null
    }
    
    public void bai4(){
        char[] charx = chuoikitu.ToCharArray();
        Array.Reverse(charx);
        string rString=new string(charx);
        Console.WriteLine("chuoi dao nguoc la:"+rString);
    }

    public void Bai2(){
        int count = chuoikitu.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));
        Console.WriteLine("So luong ky tu trong chuoi (khong tinh khoang cach va dau): " + count);
    }

    public int demSoLanXuatHien(char kyTu){
         int dem = 0;
        foreach (char c in chuoikitu)
        {
            if (c == kyTu)
            {
                dem++;
            }
        }
        return dem;
    }
    public void bai6(){
        Console.WriteLine("Nhap ky tu can kiem tra:");
        char kyTu = Console.ReadKey().KeyChar;
        int soLanXuatHien = demSoLanXuatHien(kyTu);
        Console.WriteLine($"Ký tự '{kyTu}' xuất hiện {soLanXuatHien} lần trong chuỗi.");
    }

}