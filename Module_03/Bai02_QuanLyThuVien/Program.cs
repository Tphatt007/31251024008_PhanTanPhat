namespace Bai02_QuanLyThuVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================================
            // 1. TẠO CÁC SÁCH
            // =========================================

            SachGiaoKhoa sgk1 = new SachGiaoKhoa(
                "SGK001",
                new DateTime(2026, 9, 20),
                100000,
                10,
                "NXB Giao Duc",
                Tinhtrang.Moi
            );

            SachGiaoKhoa sgk2 = new SachGiaoKhoa(
                "SGK002",
                new DateTime(2026, 9, 21),
                120000,
                5,
                "NXB Kim Dong",
                Tinhtrang.Cu
            );

            SachThamKhao stk1 = new SachThamKhao(
                "STK001",
                new DateTime(2026, 9, 22),
                200000,
                3,
                "NXB Giao Duc",
                0.1
            );

            SachThamKhao stk2 = new SachThamKhao(
                "STK002",
                new DateTime(2026, 9, 22),
                300000,
                2,
                "NXB Tre",
                0.15
            );


            // =========================================
            // 2. TẠO DANH SÁCH
            // =========================================

            ListSach ds = new ListSach(10);


            // =========================================
            // 3. THÊM SÁCH
            // =========================================

            Console.WriteLine("===== TEST THEM SACH =====");

            Console.WriteLine("Them SGK1: " + ds.them(sgk1));
            Console.WriteLine("Them SGK2: " + ds.them(sgk2));
            Console.WriteLine("Them STK1: " + ds.them(stk1));
            Console.WriteLine("Them STK2: " + ds.them(stk2));


            // =========================================
            // 4. TEST THEM SACH TRUNG MA
            // =========================================

            Console.WriteLine("\n===== TEST SACH TRUNG MA =====");

            SachGiaoKhoa sachTrung = new SachGiaoKhoa(
                "SGK001",                 // trùng MaSach với sgk1
                DateTime.Now,
                999999,
                99,
                "NXB ABC",
                Tinhtrang.Cu
            );

            Console.WriteLine("Them sach trung MaSach: " + ds.them(sachTrung));


            // =========================================
            // 5. TEST THEM NULL
            // =========================================

            Console.WriteLine("\n===== TEST THEM NULL =====");

            Console.WriteLine("Them null: " + ds.them(null));


            // =========================================
            // 6. IN TOAN BO DANH SACH
            // =========================================

            Console.WriteLine("\n===== DANH SACH SACH =====");

            Console.WriteLine(ds.toString());


            // =========================================
            // 7. TEST Equals()
            // =========================================

            Console.WriteLine("\n===== TEST EQUALS =====");

            SachGiaoKhoa sgkTrungMa = new SachGiaoKhoa(
                "SGK001",
                DateTime.Now,
                999999,
                999,
                "ABC",
                Tinhtrang.Cu
            );

            Console.WriteLine(
                "sgk1 Equals sgkTrungMa: "
                + sgk1.Equals(sgkTrungMa)
            );

            Console.WriteLine(
                "sgk1 Equals sgk2: "
                + sgk1.Equals(sgk2)
            );


            // =========================================
            // 8. TEST GetHashCode()
            // =========================================

            Console.WriteLine("\n===== TEST HASH CODE =====");

            Console.WriteLine(
                "HashCode sgk1: "
                + sgk1.GetHashCode()
            );

            Console.WriteLine(
                "HashCode sgkTrungMa: "
                + sgkTrungMa.GetHashCode()
            );


            // =========================================
            // 9. TÌM SGK THEO NXB
            // =========================================

            Console.WriteLine("\n===== TIM SGK THEO NXB =====");

            List<Sach> ketQua = ds.timSGKTheoNXB("NXB Giao Duc");

            if (ketQua != null)
            {
                foreach (Sach sach in ketQua)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine(sach.ToString());
                }
            }


            // =========================================
            // 10. TÌM THÀNH TIỀN CAO NHẤT
            // =========================================

            Console.WriteLine("\n===== THANH TIEN CAO NHAT =====");

            Console.WriteLine(
                ds.timThanhTienCaoNhat()
            );


            // =========================================
            // 11. TỔNG THÀNH TIỀN SGK
            // =========================================

            Console.WriteLine("\n===== TONG THANH TIEN SGK =====");

            Console.WriteLine(
                ds.tinhTongThanhTienSGK()
            );


            // =========================================
            // 12. TỔNG THÀNH TIỀN STK
            // =========================================

            Console.WriteLine("\n===== TONG THANH TIEN STK =====");

            Console.WriteLine(
                ds.tinhTongThanhTienSTK()
            );


            // =========================================
            // 13. TEST GETTER / SETTER
            // =========================================

            Console.WriteLine("\n===== TEST GETTER / SETTER =====");

            Console.WriteLine(
                "Ma sach sgk1: "
                + sgk1.getMaSach()
            );

            Console.WriteLine(
                "Don gia sgk1: "
                + sgk1.getDonGia()
            );

            Console.WriteLine(
                "So luong sgk1: "
                + sgk1.getSoLuong()
            );

            Console.WriteLine(
                "Tinh trang sgk1: "
                + sgk1.getTinhTrang()
            );


            // =========================================
            // 14. TEST SETTER
            // =========================================

            Console.WriteLine("\n===== TEST SETTER =====");

            sgk1.setSoLuong(20);
            sgk1.setDonGia(150000);
            sgk1.setTinhTrang(Tinhtrang.Cu);

            Console.WriteLine(sgk1.ToString());


            // =========================================
            // 15. TEST THANH TIEN
            // =========================================

            Console.WriteLine("\n===== TEST THANH TIEN =====");

            Console.WriteLine(
                "Thanh tien SGK1: "
                + sgk1.getThanhTien()
            );

            Console.WriteLine(
                "Thanh tien STK1: "
                + stk1.getThanhTien()
            );


            Console.ReadKey();
        }
    }
}
