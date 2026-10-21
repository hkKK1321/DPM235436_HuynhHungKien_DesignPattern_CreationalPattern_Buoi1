using System;

namespace DPM235436_HuynhHungKien_Tuan01_Prototype_Real_NhanVien_DP
{
    public class BatchInfo
    {
        public string BatchCode;

        public DateTime ExpiryDate;

        public BatchInfo(
            string batchCode,
            DateTime expiryDate)
        {
            BatchCode = batchCode;
            ExpiryDate = expiryDate;
        }
    }
}