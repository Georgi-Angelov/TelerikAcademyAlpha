using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace Problem_1
{
    class OrdersSystem
    {
        static void Main(string[] args)
        {
            var products = new Products();
            StringBuilder output = new StringBuilder();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandAndParams = Console.ReadLine().Split(new[] { ' ' }, 2).ToArray();
                string[] commandParams = commandAndParams[1].Split(';').ToArray();
                switch (commandAndParams[0])
                {
                    case "AddOrder":
                        products.AddProduct(commandParams[0], decimal.Parse(commandParams[1]), commandParams[2]);
                        break;
                    case "DeleteOrders":
                        products.DeleteConsumer(commandParams[0]);

                        break;
                    case "FindOrdersByPriceRange":
                        products.FilterFromMinToMax(decimal.Parse(commandParams[0]), decimal.Parse(commandParams[1]));

                        break;
                    case "FindOrdersByConsumer":
                        products.FilterByConsumer(commandParams[0]);
                        break;

                }
            }
            Console.WriteLine(output.ToString());
        }
        public class Products
        {
            private readonly Dictionary<string, OrderedBag<Order>> byConsumer = new Dictionary<string, OrderedBag<Order>>();
            private readonly OrderedBag<Order> byPrice = new OrderedBag<Order>();
            private readonly HashSet<string> products = new HashSet<string>();

            public void AddProduct(string name, decimal price, string consumer)
            {
                var product = new Order(name, price, consumer);

                products.Add(name);
                byPrice.Add(product);

                if (!byConsumer.ContainsKey(consumer))
                {
                    byConsumer.Add(consumer, new OrderedBag<Order>());
                }
                byConsumer[consumer].Add(product);

                Console.WriteLine("Order added");
            }

            public void DeleteConsumer(string consumer)
            {
                if (!byConsumer.ContainsKey(consumer))
                {
                    Console.WriteLine("No orders found");
                }
                else
                {
                    Console.WriteLine(string.Format("{0} orders deleted", byConsumer[consumer].Count));
                    byConsumer.Remove(consumer);
                }
            }
            public void FilterByConsumer(string consumer)
            {
                if (!byConsumer.ContainsKey(consumer))
                {
                    Console.WriteLine("No orders found");
                }
                else
                {
                    Console.WriteLine("{0}", string.Join("\n", byConsumer[consumer].OrderBy(x => x.Consumer)));
                }
            }

            public void FilterFromMinToMax(decimal min, decimal max)
            {
                Console.WriteLine("{0}", string.Join("\n", byPrice.Where(x => x.Price >= min && x.Price <= max).OrderBy(x => x.Price).ThenBy(x => x.Consumer)));
            }


        }
        public class Order : IComparable<Order>
        {

            public string Name { get; set; }

            public decimal Price { get; set; }

            public string Consumer { get; set; }



            public Order(string name, decimal price, string consumer)
            {
                this.Name = name;
                this.Price = price;
                this.Consumer = consumer;
            }
            public int CompareTo(Order other)
            {
                var result = this.Name.CompareTo(other.Name);
                
                return result;
            }

            public override string ToString()
            {
                return "{" + string.Format("{0};{1};{2:F2}", this.Name, this.Consumer, this.Price) + "}";
            }
        }
    }
}
