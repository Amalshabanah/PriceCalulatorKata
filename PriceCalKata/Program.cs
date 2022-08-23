using PriceCalKata.Repositories;
using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            var productRepo = new ProductRepository();
            var productPrint = new ProductPrintService();
            var productService = new ProductService(productRepo, productPrint);

            productService.CalculateAndPrintPriceWithCurrencyInfoAfterTax();  
        }
    }
}