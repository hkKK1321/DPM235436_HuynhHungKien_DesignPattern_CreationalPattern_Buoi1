namespace DPM235436_HuynhHungKien_RealBuilderPattern_Nhanvienbanhang
{
    public class SalesInvoiceBuilder : IInvoiceBuilder
    {
        private SalesInvoice _invoice;

        public SalesInvoiceBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _invoice = new SalesInvoice();
        }

        public void BuildBasicInfo()
        {
            _invoice.Add(
                "Khách hàng: Đại lý Nông nghiệp An Phú"
            );

            _invoice.Add(
                "Nhân viên bán hàng: Nguyễn Văn An"
            );

            _invoice.Add(
                "Tiền hàng: 20,000,000 VNĐ"
            );
        }

        public void BuildAdditionalCosts()
        {
            _invoice.Add(
                "Chi phí vận chuyển: 500,000 VNĐ"
            );

            _invoice.Add(
                "Chi phí dịch vụ: 200,000 VNĐ"
            );
        }

        public void BuildDiscountPromotion()
        {
            _invoice.Add(
                "Chiết khấu: 1,500,000 VNĐ"
            );

            _invoice.Add(
                "Khuyến mãi: Khuyến mãi dành cho đại lý"
            );
        }

        public SalesInvoice GetProduct()
        {
            SalesInvoice result = _invoice;

            Reset();

            return result;
        }
    }
}