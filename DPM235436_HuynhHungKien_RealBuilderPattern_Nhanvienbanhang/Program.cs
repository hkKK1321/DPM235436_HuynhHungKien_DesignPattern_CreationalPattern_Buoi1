using System;
using System.Text;

namespace DPM235436_HuynhHungKien_RealBuilderPattern_Nhanvienbanhang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            InvoiceDirector director =
                new InvoiceDirector();

            SalesInvoiceBuilder builder =
                new SalesInvoiceBuilder();

            director.Builder = builder;

            Console.WriteLine(
                "===== HÓA ĐƠN CƠ BẢN ====="
            );

            director.BuildBasicInvoice();

            SalesInvoice basicInvoice =
                builder.GetProduct();

            Console.WriteLine(
                basicInvoice.ListParts()
            );

            Console.WriteLine(
                "===== HÓA ĐƠN ĐẦY ĐỦ ====="
            );

            director.BuildFullInvoice();

            SalesInvoice fullInvoice =
                builder.GetProduct();

            Console.WriteLine(
                fullInvoice.ListParts()
            );

            Console.WriteLine(
                "===== HÓA ĐƠN TÙY CHỈNH ====="
            );

            builder.BuildBasicInfo();

            builder.BuildDiscountPromotion();

            SalesInvoice customInvoice =
                builder.GetProduct();

            Console.WriteLine(
                customInvoice.ListParts()
            );
        }
    }
}