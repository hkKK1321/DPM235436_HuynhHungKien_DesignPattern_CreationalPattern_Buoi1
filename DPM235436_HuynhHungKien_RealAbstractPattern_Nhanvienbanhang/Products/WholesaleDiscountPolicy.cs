using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public class WholesaleDiscountPolicy : IDiscountPolicy
    {
        public string GetPolicyName()
        {
            return "Chính sách chiết khấu bán sỉ";
        }

        public decimal CalculateDiscount(IInvoice invoice)
        {
            return invoice.GetProductAmount() * 0.10m;
        }
    }
}
