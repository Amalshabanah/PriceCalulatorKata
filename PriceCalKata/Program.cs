using PriceCalKata.Repositories;
using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            var productRepo = new ProductRepository();
            var product = productRepo.GetFirstProductData();
            IProductPrintService productPrint = new ProductPrintService();

            productPrint.PrintPriceBeforeAndAfterTax(product);
        }
    }
}