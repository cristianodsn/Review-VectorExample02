using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the quantity of products: ");
            int quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Product[] products = new Product[quantity];

            double sum = 0.0;
            Console.WriteLine("Enter the produch data:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product #" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products[i] = new Product(name, price);
                sum += price;
            }
            double average = sum / products.Length;
            Console.WriteLine("Avarege price: " + average.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
