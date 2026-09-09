using System;

namespace DPM235492_TranMinhTruong_Tuan01_Prototype_Real_NhanVien_DP
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