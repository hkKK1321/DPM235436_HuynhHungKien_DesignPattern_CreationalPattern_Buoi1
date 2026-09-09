namespace DPM235436_HuynhHungKien_RealBuilderPattern_Nhanvienbanhang
{
    public class InvoiceDirector
    {
        private IInvoiceBuilder _builder;

        public IInvoiceBuilder Builder
        {
            set
            {
                _builder = value;
            }
        }

        public void BuildBasicInvoice()
        {
            _builder.BuildBasicInfo();
        }

        public void BuildFullInvoice()
        {
            _builder.BuildBasicInfo();

            _builder.BuildAdditionalCosts();

            _builder.BuildDiscountPromotion();
        }
    }
}