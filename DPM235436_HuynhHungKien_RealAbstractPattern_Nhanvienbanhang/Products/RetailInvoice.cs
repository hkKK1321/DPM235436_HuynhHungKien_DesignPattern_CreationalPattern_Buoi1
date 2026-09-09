using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public class RetailInvoice : IInvoice
    {
        private string _customerName;
        private decimal _productAmount;

        public RetailInvoice(
            string customerName,
            decimal productAmount)
        {
            _customerName = customerName;
            _productAmount = productAmount;
        }

        public string GetInvoiceType()
        {
            return "Hóa đơn bán lẻ";
        }

        public decimal GetProductAmount()
        {
            return _productAmount;
        }

        public string GetInvoiceInfo()
        {
            return
                $"Loại: {GetInvoiceType()}\n" +
                $"Khách hàng: {_customerName}\n" +
                $"Tiền hàng: {_productAmount:N0} VNĐ";
        }
    }
}
