using System;

namespace DPM235436_HuynhHungKien_PrototypePattern
{
    public class Client
    {
        public void Run()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       PROTOTYPE DESIGN PATTERN");
            Console.WriteLine("========================================\n");

            // Tạo đối tượng gốc
            Person p1 = new Person();

            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Shallow Copy
            Person p2 = p1.ShallowCopy();

            // Deep Copy
            Person p3 = p1.DeepCopy();

            // Hiển thị giá trị ban đầu
            Console.WriteLine("Original values of p1, p2, p3:");

            Console.WriteLine("   p1 instance values:");
            DisplayValues(p1);

            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Thay đổi p1
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;

            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");

            Console.WriteLine("   p1 instance values:");
            DisplayValues(p1);

            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);

            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine(
                "      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name,
                p.Age,
                p.BirthDate
            );

            Console.WriteLine(
                "      ID#: {0:d}",
                p.IdInfo.IdNumber
            );
        }
    }
}