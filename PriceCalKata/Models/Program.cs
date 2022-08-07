using PriceCalKata.Services;
using PriceCalKata.Repositories;
namespace PriceCalKata.Models
{
    public class program
    {
        public static void Main(string[] args)
        {
            var product = new Product("The Little Prince", 12345, 20.25);
            product.ReadProductData();
            double priceAfterTax = product.CalculatePriceAfterTax(product.Price, product.Tax);
            
            product.PrintInfo(product.ProductName, product.Upc, product.Price);
            product.PrintTax(product.Price, product.Tax, priceAfterTax);
        }
    }
}