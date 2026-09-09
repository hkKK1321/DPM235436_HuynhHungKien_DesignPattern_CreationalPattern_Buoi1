
namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public class WholesaleSalesFactory : ISalesFactory
    {
        public IInvoice CreateInvoice()
        {
            return new WholesaleInvoice(
                "Đại lý Nông nghiệp An Phú",
                20_000_000
            );
        }

        public IDiscountPolicy CreateDiscountPolicy()
        {
            return new WholesaleDiscountPolicy();
        }
    }
}
