using System.Collections.Generic;

namespace DPM235436_HuynhHungKien_RealBuilderPattern_Nhanvienbanhang
{
    public class SalesInvoice
    {
        private List<string> _parts =
            new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string result = "";

            foreach (string part in _parts)
            {
                result += part + "\n";
            }

            return result;
        }
    }
}