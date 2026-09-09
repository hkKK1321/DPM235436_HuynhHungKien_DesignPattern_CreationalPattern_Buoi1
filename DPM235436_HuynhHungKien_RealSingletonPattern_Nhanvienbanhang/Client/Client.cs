using System;

namespace DPM235436_HuynhHungKien_RealSingletonPattern_Nhanvienbanhang
{
    public class Client
    {
        public void Run()
        {
            // Lấy Singleton instance lần thứ nhất
            StoreConfiguration config1 =
                StoreConfiguration.GetInstance();

            Console.WriteLine(
                "CẤU HÌNH BAN ĐẦU:"
            );

            config1.ShowConfiguration();

            Console.WriteLine();

            // Thay đổi cấu hình
            Console.WriteLine(
                "THAY ĐỔI CẤU HÌNH..."
            );

            config1.ExportMethod =
                "Xuất hàng theo lô chỉ định";

            config1.PriceMethod =
                "Nhập trước xuất trước (FIFO)";

            // Lấy Singleton instance lần thứ hai
            StoreConfiguration config2 =
                StoreConfiguration.GetInstance();

            Console.WriteLine();

            Console.WriteLine(
                "CẤU HÌNH ĐỌC TỪ config2:"
            );

            config2.ShowConfiguration();

            Console.WriteLine();

            // Kiểm tra Singleton
            if (config1 == config2)
            {
                Console.WriteLine(
                    "Singleton hoạt động:"
                );

                Console.WriteLine(
                    "config1 và config2 " +
                    "là cùng một instance."
                );
            }
            else
            {
                Console.WriteLine(
                    "Singleton thất bại:"
                );

                Console.WriteLine(
                    "config1 và config2 " +
                    "là hai instance khác nhau."
                );
            }

            Console.WriteLine();

            // Các module sử dụng cùng Singleton
            InventoryModule inventory =
                new InventoryModule();

            SalesModule sales =
                new SalesModule();

            inventory.ShowInventoryConfiguration();

            Console.WriteLine();

            sales.ShowSalesConfiguration();
        }
    }
}