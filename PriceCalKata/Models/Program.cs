// See https://aka.ms/new-console-template for more information

using System;

namespace Price_Calculator_Kata
{
    public class program
    {
        public static void Main(string[] args)
        {
            Product product = new Product("The Little Prince", 12345, 20.25);
            Console.WriteLine("Please Specify The Tax");
            product.Tax = Convert.ToDouble(Console.ReadLine());
            double PriceAfter = product.PriceAfterTax(product.Price, product.Tax);
            var pprice = PriceAfter.ToString("0.00");
            

        }
    }

}