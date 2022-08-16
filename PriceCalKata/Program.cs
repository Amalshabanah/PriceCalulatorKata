using PriceCalKata.Models;
using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            var productService = new ProductService();
            var productPrint = new ProductPrintService(productService);
            var product = new Product();

            productPrint.PrintTaxInfo(product);
        }
    }
}