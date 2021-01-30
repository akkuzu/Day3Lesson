using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Lesson
{
    class ShoppingBag
    {
        // naming convention
        // normal parenthesis means method
        //syntax
        //parameter
        public void Add( Product product ) 
        {

            Console.WriteLine("Sepete Eklendi. : " + product.ProductName);


        }

        public void Add2(string ProductName, string Feature, double Price, int Stock)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + ProductName);
        }
    }
}
