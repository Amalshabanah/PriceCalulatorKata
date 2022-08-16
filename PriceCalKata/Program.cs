using PriceCalKata.Models;
using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            var productPrint = new ProductPrintService();
            var product = new Product();

            productPrint.PrintTaxInfo(product);
        }
    }
}