using System;
using System.Text;

namespace DPM235436_HuynhHungKien_RealPrototypePattern_Nhanvienbanhang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =
                Encoding.UTF8;

            Console.InputEncoding =
                Encoding.UTF8;

            Client client =
                new Client();

            client.Run();

            Console.WriteLine();

            Console.WriteLine(
                "=================================="
            );

            Console.WriteLine(
                "KẾT THÚC CHƯƠNG TRÌNH"
            );

            Console.WriteLine(
                "=================================="
            );

            Console.ReadKey();
        }
    }
}