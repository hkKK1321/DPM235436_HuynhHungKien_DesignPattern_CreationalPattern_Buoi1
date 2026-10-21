using System;

namespace DPM235436_HuynhHungKien_SingletonPattern
{
    public class Client
    {
        public void Run()
        {
            Console.WriteLine("===== SINGLETON DESIGN PATTERN =====");

            // Lấy instance lần thứ nhất
            Singleton s1 = Singleton.GetInstance();

            // Lấy instance lần thứ hai
            Singleton s2 = Singleton.GetInstance();

            // Kiểm tra hai biến có cùng instance hay không
            if (s1 == s2)
            {
                Console.WriteLine(
                    "Singleton works, both variables contain the same instance."
                );
            }
            else
            {
                Console.WriteLine(
                    "Singleton failed, variables contain different instances."
                );
            }

            // Gọi business logic
            s1.SomeBusinessLogic();
        }
    }
}