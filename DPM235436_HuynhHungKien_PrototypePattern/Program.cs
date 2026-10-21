using System;
using System.Text;

namespace DPM235436_HuynhHungKien_PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Client client = new Client();
            client.Run();

            Console.WriteLine("\n========================================");
            Console.WriteLine("          KẾT THÚC CHƯƠNG TRÌNH");
            Console.WriteLine("========================================");

            Console.ReadKey();
        }
    }
}