
namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public interface ISalesFactory
    {
        IInvoice CreateInvoice();

        IDiscountPolicy CreateDiscountPolicy();
    }
}