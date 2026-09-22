namespace Bai02_QuanLyThuVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SachGiaoKhoa sachGiaoKhoa = new SachGiaoKhoa("SGK001", DateTime.Now, 100000, 10, "NXB Giao Duc", Tinhtrang.Moi);
            Console.WriteLine(sachGiaoKhoa.ToString());
            Console.ReadKey();
        }
    }
}
