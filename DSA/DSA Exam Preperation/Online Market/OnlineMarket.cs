using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace Online_Market
{
    class OnlineMarket
    {
        static void Main(string[] args)
        {
            var products = new Products();
            StringBuilder output = new StringBuilder();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParams = command.Split();
                switch (commandParams[0])
                {
                    case "add":
                        products.AddProduct(commandParams[1], decimal.Parse(commandParams[2]), commandParams[3]);
                        break;
                    
                    case "filter":
                        if (commandParams[2] == "type")
                        {
                            products.FilterByType(commandParams[3]);
                        }
                        if (commandParams[2] == "price")
                        {
                            if (commandParams.Length > 5)
                            {
                                products.FilterFromMinToMax(decimal.Parse(commandParams[4]), decimal.Parse(commandParams[6]));
                            }
                            else if (commandParams[3] == "from")
                            {
                                products.FilterFromMin(decimal.Parse(commandParams[4]));
                            }
                            else if (commandParams[3] == "to")
                            {
                                products.FilterToMax(decimal.Parse(commandParams[4]));
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(output.ToString());
        }
        public class Products
        {
            private readonly Dictionary<string, SortedSet<Product>> byType = new Dictionary<string, SortedSet<Product>>();
            private readonly SortedSet<Product> byPrice = new SortedSet<Product>();
            private readonly HashSet<string> products = new HashSet<string>();

            public void AddProduct(string name, decimal price, string type)
            {
                var product = new Product(name, price, type);

                if (products.Contains(name))
                {
                    Console.WriteLine("Error: Product {0} already exists", name);
                }
                else
                {
                    products.Add(name);
                    byPrice.Add(product);

                    if (!byType.ContainsKey(type))
                    {
                        byType.Add(type, new SortedSet<Product>());
                    }
                    byType[type].Add(product);

                    Console.WriteLine("Ok: Product {0} added successfully", name);
                }
            }

            public void FilterByType(string type)
            {
                if (!byType.ContainsKey(type))
                {
                    Console.WriteLine("Error: Type {0} does not exists", type);
                }
                else
                {
                    Console.WriteLine("Ok: {0}", string.Join(", ", byType[type].Take(10)));
                }
            }

            public void FilterFromMinToMax(decimal min, decimal max)
            {
                Console.WriteLine("Ok: {0}", string.Join(", ", byPrice.Where(x => x.Price >= min && x.Price <= max).Take(10)));
            }

            public void FilterFromMin(decimal min)
            {
                Console.WriteLine("Ok: {0}", string.Join(", ", byPrice.Where(x => x.Price >= min).Take(10)));
            }

            public void FilterToMax(decimal max)
            {
                Console.WriteLine("Ok: {0}", string.Join(", ", byPrice.Where(x => x.Price <= max).Take(10)));
            }
        }
        public class Product : IComparable<Product>
        {

            public string Name { get; set; }

            public decimal Price { get; set; }

            public string Type { get; set; }

           

            public Product(string name, decimal price,string type )
            {
                this.Name = name;
                this.Price = price;
                this.Type = type;
                
            }
            public int CompareTo(Product other)
            {
                var result = this.Price.CompareTo(other.Price);


                if (result == 0)
                {
                    result = 1;
                }

                return result;
            }

            public override string ToString()
            {
                return string.Format("{0}({1:G25})", this.Name, this.Price);
            }
        }
    }
}
