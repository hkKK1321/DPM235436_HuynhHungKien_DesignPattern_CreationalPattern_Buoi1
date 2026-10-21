using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM235436_HuynhHungKien_AbstractPattern.Factories;
using DPM235436_HuynhHungKien_AbstractPattern.Products;

namespace DPM235436_HuynhHungKien_AbstractPattern
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine(
                "Client: Testing client code with the first factory type..."
            );

            ClientMethod(new ConcreteFactory1());

            Console.WriteLine();

            Console.WriteLine(
                "Client: Testing the same client code with the second factory type..."
            );

            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());

            Console.WriteLine(
                productB.AnotherUsefulFunctionB(productA)
            );
        }
    }
}
