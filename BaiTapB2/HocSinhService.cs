using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapB2
{
    public class HocSinhService
    {
        public List<HocSinh> TaoDanhSachHocSinh()
        {
            return new List<HocSinh>
        {
            new HocSinh { Id = 1, Name = "An", Age = 16 },
            new HocSinh { Id = 2, Name = "Bình", Age = 17 },
            new HocSinh { Id = 3, Name = "Huy", Age = 19 },
            new HocSinh { Id = 4, Name = "Hoàng", Age = 15 },
            new HocSinh { Id = 5, Name = "Quỳnh", Age = 18 }
        };
        }

        public void HienThiDanhSachHocSinh(List<HocSinh> danhSachHocSinh)
        {
            Console.WriteLine("Danh sách toàn bộ học sinh:");
            foreach (var hocSinh in danhSachHocSinh)
            {
                Console.WriteLine($"Id: {hocSinh.Id}, Name: {hocSinh.Name}, Age: {hocSinh.Age}");
            }
        }

        public void TimHocSinhTheoTuoi(List<HocSinh> danhSachHocSinh)
        {
            var tuoi1518 = danhSachHocSinh.Where(hs => hs.Age >= 15 && hs.Age <= 18).ToList();
            Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
            foreach (var hocSinh in tuoi1518)
            {
                Console.WriteLine($"Id: {hocSinh.Id}, Name: {hocSinh.Name}, Age: {hocSinh.Age}");
            }
        }

        public void TimHocSinhTheoTen(List<HocSinh> danhSachHocSinh)
        {
            var tenBatDauA = danhSachHocSinh.Where(hs => hs.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
            foreach (var hocSinh in tenBatDauA)
            {
                Console.WriteLine($"Id: {hocSinh.Id}, Name: {hocSinh.Name}, Age: {hocSinh.Age}");
            }
        }

        public void TinhTongTuoiHocSinh(List<HocSinh> danhSachHocSinh)
        {
            int tongTuoi = danhSachHocSinh.Sum(hs => hs.Age);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {tongTuoi}");
        }

        public void HocSinhTuoiLonNhat(List<HocSinh> danhSachHocSinh)
        {
            var hocSinhLonNhat = danhSachHocSinh.OrderByDescending(hs => hs.Age).FirstOrDefault();
            Console.WriteLine("\nHọc sinh có tuổi lớn nhất:");
            if (hocSinhLonNhat != null)
            {
                Console.WriteLine($"Id: {hocSinhLonNhat.Id}, Name: {hocSinhLonNhat.Name}, Age: {hocSinhLonNhat.Age}");
            }
        }

        public void SapXepHocSinhTheoTuoi(List<HocSinh> danhSachHocSinh)
        {
            var danhSachSapXep = danhSachHocSinh.OrderBy(hs => hs.Age).ToList();
            Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
            foreach (var hocSinh in danhSachSapXep)
            {
                Console.WriteLine($"Id: {hocSinh.Id}, Name: {hocSinh.Name}, Age: {hocSinh.Age}");
            }
        }
    }
}
