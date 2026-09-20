namespace Bai03_QuanLyGiaoDich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GiaoDich> list = new List<GiaoDich>();
            list.Add(new GiaoDichVang("GDV001", 20230920, 5000000, 2, "24K"));
            list.Add(new GiaoDichVang("GDV002", 20230925, 7000000, 1, "24K"));
            list.Add(new GiaoDichVang("GDV003", 20230921, 6000000, 3, "18K"));
            list.Add(new GiaoDichTienTe("GDT001", 20230922, 23000, 100, 1, LoaiTien.TienUSD));
            list.Add(new GiaoDichTienTe("GDT002", 20230923, 27000, 200, 1, LoaiTien.TienEuro));
            list.Add(new GiaoDichTienTe("GDT003", 20230924, 1, 5000000, 1, LoaiTien.TienViet));
            int TongSLGDVang = 0, TongSLGDTien = 0, sogdtt = 0;
            decimal TongThanhTiengdtt = 0;
            
            Console.WriteLine("Cac giao dich co don gia >1000000: ");
            Console.WriteLine("=================================================");

            foreach (var gd in list)
            {
                if(gd is GiaoDichTienTe)
                {
                    TongSLGDTien += gd.SoLuong;
                    sogdtt++;
                    TongThanhTiengdtt += gd.ThanhTien();
                }
                if(gd is GiaoDichVang) TongSLGDVang += gd.SoLuong;
                if (gd.dongia > 1000000)
                {
                    GiaoDich.ToString(gd);
                    Console.WriteLine("===============================================");
                }
            }
            Console.WriteLine("Tong so luong giao dich vang: "+TongSLGDVang);
            Console.WriteLine("Tong so luong giao dich tien te: "+TongSLGDTien);
            Console.WriteLine("Trung binh thanh tien giao dich tien te: "+(TongThanhTiengdtt/sogdtt).ToString("F3"));

        }
    }
}
