using System;

namespace Task2
{
    class Task11_2
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[2];

            products[0] = new Product();
            products[0].Name = "Cola";
            products[0].Store = "Metro";
            products[0].Price = 2.20;
            products[0].Count = 12;

            products[1] = new Product();
            products[1].Name = "Fanta";
            products[1].Store = "Billa";
            products[1].Price = 2.10;
            products[1].Count = 20;

            string searchProduct = Console.ReadLine();

            string foundProduct = "";

            for (int i = 0; i < 2; i++)
            {
                if (products[i].Name == searchProduct)
                {
                    foundProduct = searchProduct;
                    Console.WriteLine($"{foundProduct}: {products[i].Price} {products[i].Count}");
                }
            }

            if (foundProduct == "")
            {
                Console.WriteLine($"{searchProduct} not found.");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }

        public string Store { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }
    }
}
