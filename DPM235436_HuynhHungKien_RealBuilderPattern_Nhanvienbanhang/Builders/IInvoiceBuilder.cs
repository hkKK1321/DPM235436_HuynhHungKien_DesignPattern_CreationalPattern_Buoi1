namespace DPM235436_HuynhHungKien_RealBuilderPattern_Nhanvienbanhang
{
    public interface IInvoiceBuilder
    {
        void BuildBasicInfo();

        void BuildAdditionalCosts();

        void BuildDiscountPromotion();
    }
}