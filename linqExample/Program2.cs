//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace linqExample2
//{
//    class Product
//    {
//        public string Name;
//        public string Category;
//        public double Price;
//        public Product(string name, string category, double price)
//        {
//            Name = name;
//            Category = category;
//            Price = price;
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            List<Product> products = new List<Product>()
//            {
//                new Product("Laptop", "Electronics", 800),
//                new Product("Smartphone", "Electronics", 600),
//                new Product("Table", "Furniture", 150),
//                new Product("Sofa", "Furniture", 500),
//                new Product("Headphones", "Electronics", 50),
//                new Product("Chair", "Furniture", 100),
//                new Product("Refrigerator", "Appliances", 1200),
//                new Product("Microwave", "Appliances", 300)
//            };

//            var groupedProducts = from p in products
//                                  group p by p.Category into g
//                                  orderby g.Count() descending
//                                  select new { Category = g.Key, Count = g.Count() };
//            foreach (var group in groupedProducts)
//            {
//                Console.WriteLine($"Category: {group.Category}, ProductNumbers: {group.Count}");
//            }
//            Console.WriteLine("\nPress any key to exit...");
//            Console.ReadKey();



//        }

//    }
//}
