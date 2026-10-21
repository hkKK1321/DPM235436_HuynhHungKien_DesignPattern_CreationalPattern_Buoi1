using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235436_HuynhHungKien_RealAbstractPattern_Nhanvienbanhang
{
    public interface IInvoice
    {
        string GetInvoiceType();

        decimal GetProductAmount();

        string GetInvoiceInfo();
    }
}
