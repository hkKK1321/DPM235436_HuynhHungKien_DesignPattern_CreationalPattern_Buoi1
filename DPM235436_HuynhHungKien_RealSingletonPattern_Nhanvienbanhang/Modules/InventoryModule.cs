using System;

namespace DPM235436_HuynhHungKien_RealSingletonPattern_Nhanvienbanhang
{
    public class InventoryModule
    {
        public void ShowInventoryConfiguration()
        {
            StoreConfiguration config =
                StoreConfiguration.GetInstance();

            Console.WriteLine(
                "MODULE KHO:"
            );

            Console.WriteLine(
                $"Đang sử dụng phương pháp xuất: " +
                $"{config.ExportMethod}"
            );
        }
    }
}