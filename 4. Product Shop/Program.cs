﻿using System.Globalization;

namespace _4._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>(); 

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2], CultureInfo.InvariantCulture);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var shop in shops.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {

                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
            
        }
    }
}