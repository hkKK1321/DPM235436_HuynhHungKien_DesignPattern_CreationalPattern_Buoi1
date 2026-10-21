namespace DPM235436_HuynhHungKien_RealFactoryPattern_Nhanvienbanhang
{
    public class RetailInvoice : ISalesInvoice
    {
        private string customerName;
        private decimal productAmount;
        private decimal shippingCost;
        private decimal serviceCost;
        private decimal discount;

        public RetailInvoice(
            string customerName,
            decimal productAmount,
            decimal shippingCost,
            decimal serviceCost,
            decimal discount)
        {
            this.customerName = customerName;
            this.productAmount = productAmount;
            this.shippingCost = shippingCost;
            this.serviceCost = serviceCost;
            this.discount = discount;
        }

        public string GetInvoiceType()
        {
            return "Hóa đơn bán lẻ";
        }

        public decimal CalculateTotal()
        {
            return productAmount
                   + shippingCost
                   + serviceCost
                   - discount;
        }

        public string GetInvoiceInfo()
        {
            return
                $"Loại hóa đơn: {GetInvoiceType()}\n" +
                $"Khách hàng: {customerName}\n" +
                $"Tiền hàng: {productAmount:N0} VNĐ\n" +
                $"Phí vận chuyển: {shippingCost:N0} VNĐ\n" +
                $"Phí dịch vụ: {serviceCost:N0} VNĐ\n" +
                $"Giảm giá: {discount:N0} VNĐ";
        }
    }
}