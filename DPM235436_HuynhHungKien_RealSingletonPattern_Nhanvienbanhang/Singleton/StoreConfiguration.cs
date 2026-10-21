using System;

namespace DPM235436_HuynhHungKien_Tuan01_Singleton_Real_NhanVien_DP
{
    public sealed class StoreConfiguration
    {
        private static StoreConfiguration _instance;

        public string ExportMethod { get; set; }

        public string PriceMethod { get; set; }

        // Constructor private
        private StoreConfiguration()
        {
            ExportMethod =
                "Nhập trước xuất trước (FIFO)";

            PriceMethod =
                "Bình quân gia quyền";
        }

        // Lấy instance duy nhất
        public static StoreConfiguration GetInstance()
        {
            if (_instance == null)
            {
                _instance =
                    new StoreConfiguration();
            }

            return _instance;
        }

        public void ShowConfiguration()
        {
            Console.WriteLine(
                "===== CẤU HÌNH CỬA HÀNG ====="
            );

            Console.WriteLine(
                $"Phương pháp xuất kho: " +
                $"{ExportMethod}"
            );

            Console.WriteLine(
                $"Phương pháp tính giá xuất: " +
                $"{PriceMethod}"
            );

            Console.WriteLine(
                "============================="
            );
        }
    }
}