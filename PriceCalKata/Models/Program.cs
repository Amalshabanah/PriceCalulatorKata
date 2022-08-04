using PriceCalKata.Services;
namespace PriceCalKata.Models

{
    public class program
    { 
        public static void Main(string[] args)
        {
            Product product = new Product("The Little Prince", 12345, 20.25);
            Console.WriteLine("Please Specify The Tax");
            product.Tax = Convert.ToDouble(Console.ReadLine());
            string priceAfter = product.CalculatePriceAfterTax(product.Price, product.Tax).ToString("0.00");
            Console.WriteLine($"Sample product: Book with name = {product.ProductName}, UPC= {product.Upc}, price= ${product.Price}.");
            Console.WriteLine($"Product price reported as ${product.Price}  before tax, and {priceAfter} after {product.Tax}% tax.");
        }
    }
}