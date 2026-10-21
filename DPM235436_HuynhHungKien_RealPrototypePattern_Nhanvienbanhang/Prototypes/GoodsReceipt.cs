using System;

namespace DPM235436_HuynhHungKien_Tuan01_Prototype_Real_NhanVien_DP
{
    public class GoodsReceipt
    {
        public string ReceiptCode;

        public string ProductName;

        public int Quantity;

        public DateTime ImportDate;

        public BatchInfo BatchInfo;

        // Shallow Copy
        public GoodsReceipt ShallowCopy()
        {
            return (GoodsReceipt)this.MemberwiseClone();
        }

        // Deep Copy
        public GoodsReceipt DeepCopy()
        {
            GoodsReceipt clone =
                (GoodsReceipt)this.MemberwiseClone();

            clone.BatchInfo =
                new BatchInfo(
                    BatchInfo.BatchCode,
                    BatchInfo.ExpiryDate
                );

            return clone;
        }
    }
}