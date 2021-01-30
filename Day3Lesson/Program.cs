using System;

namespace Day3Lesson
{
    class Program

    {
        static void Main(string[] args)
        {
           
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.Price = 5;
            product1.Feature = "Amasya Elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.Price = 20;
            product2.Feature = "Adana Karpuzu";

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Feature);
                Console.WriteLine();
            }

            //instance
            ShoppingBag shoppingBag = new ShoppingBag();
            shoppingBag.Add(product1);
            shoppingBag.Add(product2);

            shoppingBag.Add2("Armut", "Sarı Armut", 12, 25);
            shoppingBag.Add2("Elma", "Yeşil Elma", 12, 5);
            shoppingBag.Add2("Karpuz", "Adana Karpuzu", 12, 8);
        }

        

    }

}
