namespace DPM235436_HuynhHungKien_RealFactoryPattern_Nhanvienbanhang
{
    public interface ISalesInvoice
    {
        string GetInvoiceType();

        decimal CalculateTotal();

        string GetInvoiceInfo();
    }
}