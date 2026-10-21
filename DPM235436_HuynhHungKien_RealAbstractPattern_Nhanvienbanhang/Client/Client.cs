using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("===== HỆ THỐNG BÁN LẺ =====");

            ClientMethod(
                new RetailSalesFactory()
            );

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("===== HỆ THỐNG BÁN SỈ =====");

            ClientMethod(
                new WholesaleSalesFactory()
            );
        }

        public void ClientMethod(ISalesFactory factory)
        {
            IInvoice invoice =
                factory.CreateInvoice();

            IDiscountPolicy discountPolicy =
                factory.CreateDiscountPolicy();

            Console.WriteLine(
                invoice.GetInvoiceInfo()
            );

            Console.WriteLine(
                $"Chính sách: {discountPolicy.GetPolicyName()}"
            );

            decimal discount =
                discountPolicy.CalculateDiscount(invoice);

            decimal total =
                invoice.GetProductAmount() - discount;

            Console.WriteLine(
                $"Giảm giá / Chiết khấu: {discount:N0} VNĐ"
            );

            Console.WriteLine(
                $"Tổng thanh toán: {total:N0} VNĐ"
            );
        }
    }
}
