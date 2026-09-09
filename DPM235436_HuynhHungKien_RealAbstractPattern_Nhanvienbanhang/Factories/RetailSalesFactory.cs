
namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public class RetailSalesFactory : ISalesFactory
    {
        public IInvoice CreateInvoice()
        {
            return new RetailInvoice(
                "Nguyễn Văn An",
                2_000_000
            );
        }

        public IDiscountPolicy CreateDiscountPolicy()
        {
            return new RetailDiscountPolicy();
        }
    }
}
