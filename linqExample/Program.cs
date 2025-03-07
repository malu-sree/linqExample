//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LinqExample
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
//    class Program2
//    {

//        static void Main(string[] args)
//        {
//            List<Product> products = new List<Product>()
//            {
//                new Product("Laptop", "Electronics", 800),
//                new Product("Smartphone", "Electronics", 600),
//                new Product("Table", "Furniture", 150),
//                new Product("Sofa", "Furniture", 500),
//                new Product("Headphones", "Electronics", 50)
//            };
//            string selectedCategory = "Electronics";

//            var filterdProducts = products.Where(p => p.Category == selectedCategory).ToList();
//            foreach (var product in filterdProducts)
//            {
//                Console.WriteLine($"Product name :{product.Name}, Price:{product.Price} ");
//            }
//            double averagePrice = filterdProducts.Average(p => p.Price);

//            Console.WriteLine($"Average price of all products is {averagePrice}");


//            Console.WriteLine("Press any key to exit...");
//            Console.ReadKey();
//        }
//    }

//}

