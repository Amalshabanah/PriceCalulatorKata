using PriceCalKata.Models;
using PriceCalKata.Repositories;
using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            //ToDp: Inject Repo and Print service here.
            var productRepo = new ProductRepository();
            var productPrint = new ProductPrintService();
            var productService = new ProductService(productRepo , productPrint);
          
            productService.CalculateAndPrintPriceInfo();
        }
    }
}