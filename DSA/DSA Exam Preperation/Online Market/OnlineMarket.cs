using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Market
{
    class OnlineMarket
    {
        static void Main(string[] args)
        {
            Dictionary<decimal, Product> byPrice = new Dictionary<decimal, Product>();
            Dictionary<string, ICollection<Product>> byType = new Dictionary<string, ICollection<Product>>();
            StringBuilder output = new StringBuilder();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParams = command.Split();
                switch (commandParams[0])
                {
                    case "add":
                        Product productToAdd = new Product(commandParams[1], commandParams[2], int.Parse(commandParams[3]));
                        if (byPrice.ContainsKey(productToAdd.Price))
                        {
                            output.AppendLine("Error: Product " + productToAdd.Name + " already exists");
                            break;
                        }

                        byPrice.Add(productToAdd.Price, productToAdd);

                        if (!byType.ContainsKey(productToAdd.Type))
                        {
                            byType.Add(productToAdd.Type, new List<Product>());
                        }

                        byType[productToAdd.Type].Add(productToAdd);
                        
                        output.AppendLine("Ok: Product " + productToAdd.Name + " added successfully");

                        break;
                    
                    case "filter":
                        
                        break;
                }
            }
        }

        public class Product
        {
            public string Name { get; set; }

            public string Type { get; set; }

            public int Price { get; set; }

            public Product(string name, string type, int price)
            {
                this.Name = name;
                this.Type = type;
                this.Price = price;
            }
        }
    }
}
