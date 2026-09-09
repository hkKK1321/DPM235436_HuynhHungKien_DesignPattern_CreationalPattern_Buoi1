namespace DPM235436_HuynhHungKien_RealFactoryPattern_Nhanvienbanhang
{
    public class RetailInvoiceCreator : InvoiceCreator
    {
        public override ISalesInvoice CreateInvoice()
        {
            return new RetailInvoice(
                "Nguyễn Văn An",
                2_000_000,
                100_000,
                50_000,
                100_000
            );
        }
    }
}