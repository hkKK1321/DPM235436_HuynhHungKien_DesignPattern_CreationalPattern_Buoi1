namespace DPM235436_HuynhHungKien_SingletonPattern
{
    public sealed class Singleton
    {
        // Constructor private
        // Không cho phép tạo Singleton bằng new
        private Singleton()
        {
        }

        // Lưu instance duy nhất
        private static Singleton _instance;

        // Lấy instance Singleton
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        // Business Logic
        public void SomeBusinessLogic()
        {
            // Business logic của Singleton
        }
    }
}