namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ChuyenXe> dsChuyenXe = new List<ChuyenXe>();

            // 2 chuyến xe nội thành
            dsChuyenXe.Add(new ChuyenXeNoiThanh(
                500000,
                "Nguyen Van An",
                "NT01",
                "51A-12345",
                25,
                3
            ));

            dsChuyenXe.Add(new ChuyenXeNoiThanh(
                700000,
                "Tran Van Binh",
                "NT02",
                "51A-67890",
                35,
                5
            ));

            // 2 chuyến xe ngoại thành
            dsChuyenXe.Add(new ChuyenXeNgoaiThanh(
                1500000,
                "Le Van Cuong",
                "NG01",
                "51B-11111",
                "Vung Tau",
                2
            ));

            dsChuyenXe.Add(new ChuyenXeNgoaiThanh(
                2000000,
                "Pham Van Dung",
                "NG02",
                "51B-22222",
                "Da Lat",
                3
            ));

            // Tổng doanh thu tất cả chuyến xe
            double tongTatCa = 0;

            // Tổng doanh thu từng loại
            double tongNoiThanh = 0;
            double tongNgoaiThanh = 0;

            foreach (ChuyenXe xe in dsChuyenXe)
            {
                tongTatCa += xe.DoanhThu;

                if (xe is ChuyenXeNoiThanh)
                {
                    tongNoiThanh += xe.DoanhThu;
                }
                else if (xe is ChuyenXeNgoaiThanh)
                {
                    tongNgoaiThanh += xe.DoanhThu;
                }
            }

            Console.WriteLine($"Tổng doanh thu tất cả: {tongTatCa:N0}");
            Console.WriteLine($"Tổng doanh thu nội thành: {tongNoiThanh:N0}");
            Console.WriteLine($"Tổng doanh thu ngoại thành: {tongNgoaiThanh:N0}");
            Console.ReadKey();
        }
    }
}
