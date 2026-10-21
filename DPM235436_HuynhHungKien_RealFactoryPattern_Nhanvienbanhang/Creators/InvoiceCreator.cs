using System;

namespace DPM235436_HuynhHungKien_RealFactoryPattern_Nhanvienbanhang
{
    public abstract class InvoiceCreator
    {
        public abstract ISalesInvoice CreateInvoice();

        public void ProcessInvoice()
        {
            ISalesInvoice invoice = CreateInvoice();

            Console.WriteLine("THÔNG TIN HÓA ĐƠN");
            Console.WriteLine("------------------------------");

            Console.WriteLine(
                invoice.GetInvoiceInfo()
            );

            Console.WriteLine(
                $"TỔNG THANH TOÁN: " +
                $"{invoice.CalculateTotal():N0} VNĐ"
            );

            Console.WriteLine(
                "=============================="
            );
        }
    }
}