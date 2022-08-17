using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            var productService = new ProductService();
            productService.CalculateAndPrintPriceInfo();
        }
    }
}