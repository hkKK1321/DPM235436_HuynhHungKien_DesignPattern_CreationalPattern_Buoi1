using System;

namespace DPM235436_HuynhHungKien_RealSingletonPattern_Nhanvienbanhang
{
    public class SalesModule
    {
        public void ShowSalesConfiguration()
        {
            StoreConfiguration config =
                StoreConfiguration.GetInstance();

            Console.WriteLine(
                "MODULE BÁN HÀNG:"
            );

            Console.WriteLine(
                $"Đang sử dụng phương pháp tính giá: " +
                $"{config.PriceMethod}"
            );
        }
    }
}