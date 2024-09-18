using System;
using System.Linq;

class Bai1_3_5{
    public int n;
    public int[] arr;

    public Bai1_3_5()
    {
        arr = Array.Empty<int>(); // Khởi tạo với mảng rỗng
    }
    public void nhap_n(){
        Console.Write("Nhap so luong phan tu: ");
        this.n = Convert.ToInt32(Console.ReadLine());
        this.arr = new int[n];
    }

    public void nhapMang(){
        for(int i = 0; i<arr.Length; i++){
            Console.Write("Nhap gia tri cho phan tu thu "+ i+1 +": ");
            this.arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void xuatMang(){
        Console.WriteLine("Hien thi mang: ");
        for(int i = 0; i<this.arr.Length; i++){
            Console.WriteLine(this.arr[i]);
        }
    }

    public int tinhTong(){
        int sum = 0; 
        for(int i = 0; i < this.arr.Length; i++){
            sum+=this.arr[i];
        }
        return sum;
    }

    public void bai1(){
        Console.WriteLine("Tong cac phan tu cua mang la: "+tinhTong());
    }

    public void bai3(){
        Console.WriteLine("Gia tri lon nhat cua mang: "+this.arr.Max());
    }
    public bool kiemTraMangDoiXung(){
        bool check = true;
        int half = n/2;
        for(int i = 0; i < n/2; i++){
            if(arr[i] != arr[n-1-i]){
                check = false;
                break;
            }
        }
        return check;
    }
    public void bai5(){
        if(kiemTraMangDoiXung()){
            Console.WriteLine("Mang da nhap la mang doi xung.");
        } else {
            Console.WriteLine("Mang da nhap khong phai mang doi xung.");
        }
    }
}