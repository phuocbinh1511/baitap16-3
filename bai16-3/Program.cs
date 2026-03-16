using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThuchanhCS
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> dsSanPham = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1200, Category = "Dien tu" },
                new Product { Id = 2, Name = "Chuot", Price = 25, Category = "Phu kien" },
                new Product { Id = 3, Name = "Ban phim", Price = 45, Category = "Phu kien" },
                new Product { Id = 4, Name = "Man hinh", Price = 600, Category = "Dien tu" },
                new Product { Id = 5, Name = "Tai nghe", Price = 150, Category = "Phu kien" },
                new Product { Id = 6, Name = "Dien thoai", Price = 800, Category = "Dien tu" }
            };
            Console.WriteLine("--- San pham gia > 500 ---");
            var dsGiaLon = dsSanPham.Where(p => p.Price > 500);
            foreach (var p in dsGiaLon) Console.WriteLine($"{p.Name} - {p.Price}");

            Console.WriteLine("\n--- Sap xep theo Price tang dan ---");
            var dsSapXep = dsSanPham.OrderBy(p => p.Price);
            foreach (var p in dsSapXep) Console.WriteLine($"{p.Name} - {p.Price}");

            Console.WriteLine("\n--- 3 san pham re nhat ---");
            var dsReNhat = dsSanPham.OrderBy(p => p.Price).Take(3);
            foreach (var p in dsReNhat) Console.WriteLine($"{p.Name} - {p.Price}");

            Console.Write("\nNhap ten san pham can tim: ");
            string tuKhoa = Console.ReadLine();
            var dsTimKiem = dsSanPham.Where(p => p.Name.ToLower().Contains(tuKhoa.ToLower()));
            foreach (var p in dsTimKiem) Console.WriteLine($"Tim thay: {p.Name} - {p.Price}");

            double tongGia = dsSanPham.Sum(p => p.Price);
            double giaTB = dsSanPham.Average(p => p.Price);

            Console.WriteLine("\n--- Thong ke ---");
            Console.WriteLine("Tong gia tri: " + tongGia);
            Console.WriteLine("Gia trung binh: " + giaTB);

            Console.ReadKey();
        }
    }
}