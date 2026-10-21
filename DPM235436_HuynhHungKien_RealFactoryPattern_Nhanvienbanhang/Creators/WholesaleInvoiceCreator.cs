namespace DPM235436_HuynhHungKien_RealFactoryPattern_Nhanvienbanhang
{
    public class WholesaleInvoiceCreator : InvoiceCreator
    {
        public override ISalesInvoice CreateInvoice()
        {
            return new WholesaleInvoice(
                "Đại lý Nông nghiệp An Phú",
                20_000_000,
                500_000,
                200_000,
                1_500_000
            );
        }
    }
}