using PriceCalKata.Services;
namespace PriceCalKata.Models
{
    public class program
    {
        public static void Main(string[] args)
        {
            Product product = new Product("The Little Prince", 12345, 20.25 );
            Console.WriteLine("Please Specify The Tax");
            product.Tax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Specify The Discount");
            product.Discount= Convert.ToDouble(Console.ReadLine());
            double priceAfterTax = product.CalculatePriceAfterTax(product.Price , product.Tax);
            product.PrintInfo(product.ProductName , product.Upc , product.Price);
           product.PrintFinalPrice(product.Price , product.Tax , product.Discount);
        }
    }

}