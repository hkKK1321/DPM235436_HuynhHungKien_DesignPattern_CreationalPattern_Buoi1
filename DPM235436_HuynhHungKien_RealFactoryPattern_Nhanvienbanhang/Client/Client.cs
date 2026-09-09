using System;

namespace DPM235436_HuynhHungKien_RealFactoryPattern_Nhanvienbanhang
{
    public class Client
    {
        public void Run()
        {
            Console.WriteLine(
                "===== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC =====\n"
            );

            InvoiceCreator retailCreator =
                new RetailInvoiceCreator();

            retailCreator.ProcessInvoice();

            Console.WriteLine();

            InvoiceCreator wholesaleCreator =
                new WholesaleInvoiceCreator();

            wholesaleCreator.ProcessInvoice();
        }
    }
}