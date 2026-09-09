using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public class RetailDiscountPolicy : IDiscountPolicy
    {
        public string GetPolicyName()
        {
            return "Chính sách giảm giá bán lẻ";
        }

        public decimal CalculateDiscount(IInvoice invoice)
        {
            return invoice.GetProductAmount() * 0.05m;
        }
    }
}
