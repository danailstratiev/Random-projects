using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GroceryStore
{
    public class Start
    {
        static void Main(string[] args)
        {
            var firstVegetable = new Vegetable("Cucumber", 1.5m, 5, "Cucumber is summer vegetable", "2020-02-29");
        }
    }

    public class Vegetable
    {
        public Vegetable()
        {

        } 
        public Vegetable(string name, decimal priceWithoutVat, int quantity, 
            string description, string expireDate)
        {
            this.Name = name;
            this.PriceWithoutVat = priceWithoutVat;
            this.Quantity = quantity;
            this.Desctiption = description;
            this.ExpireDate = expireDate;
        }

        public string Name { get; set; }

        public decimal PriceWithoutVat { get; set; }

        public int Quantity { get; set; }

        public string Desctiption { get; set; }

        public string ExpireDate { get; set; }

        public void SetQuantity(int someQuantity)
        {
            if (someQuantity < 0)
            {
                throw new ArgumentException("Quantity can not be negative");
            }
            this.Quantity = someQuantity;
        }

        public void SellQuantity(int someQuantity)
        {
            if (someQuantity < 0)
            {
                throw new ArgumentException("Quantity can not be negative");
            }

            if (this.Quantity - someQuantity >= 0)
            {
                Console.WriteLine($"Sold out {this.Quantity - someQuantity} of {this.Name}");
            }
            else
            {
                throw new ArgumentException($"Not enough quantity of {this.Name}");
            }

            this.Quantity -= someQuantity;
        }

        public decimal GetPrice()
        {
            return this.PriceWithoutVat * 1.22m;
        }
    }

    public class Store
    {
        public Store()
        {
            this.Vegetables = new List<Vegetable>();
        }

        public List<Vegetable> Vegetables { get; set; }
        public Vegetable CreateVegetable(string name, decimal priceWithoutVat, int quantity,
            string description, string expireDate)
        {
            return new Vegetable(name, priceWithoutVat, quantity, description, expireDate);
        }

        public void SellVegetables(int quantity)
        {

        }

        public void PrintVegetablesInfo()
        {
            var sb = new StringBuilder();
            foreach (var vegetable in this.Vegetables)
            {
                sb.AppendLine(vegetable.Name);
                sb.AppendLine($"{vegetable.Quantity}");
                sb.AppendLine($"{vegetable.PriceWithoutVat}");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }

    public class VegetableOrder
    {
        public VegetableOrder()
        {
            this.QuantityNeeded = 10;
        }
        public Vegetable VegetableToOrder { get; set; }

        public int QuantityNeeded { get; set; }

        public decimal Price { get; set; }

        public void Print()
        {
            Console.WriteLine(VegetableToOrder.Name);
            Console.WriteLine(VegetableToOrder.PriceWithoutVat);
            Console.WriteLine(VegetableToOrder.Quantity);
            Console.WriteLine(VegetableToOrder.ExpireDate);
        }

        public decimal CalculateTotalPriceWithVat()
        {
            var finalPrice = 0m;

            for (int i = 1; i <= QuantityNeeded; i++)
            {
                finalPrice += this.VegetableToOrder.GetPrice();
            }

            return finalPrice;
        }
    }
}
