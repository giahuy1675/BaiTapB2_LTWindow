using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            HocSinhService hocSinhService = new HocSinhService();
            List<HocSinh> danhSachHocSinh = hocSinhService.TaoDanhSachHocSinh();

            hocSinhService.HienThiDanhSachHocSinh(danhSachHocSinh);
            hocSinhService.TimHocSinhTheoTuoi(danhSachHocSinh);
            hocSinhService.TimHocSinhTheoTen(danhSachHocSinh);
            hocSinhService.TinhTongTuoiHocSinh(danhSachHocSinh);
            hocSinhService.HocSinhTuoiLonNhat(danhSachHocSinh);
            hocSinhService.SapXepHocSinhTheoTuoi(danhSachHocSinh);
            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc");
            Console.ReadKey();
        }
    }
}
