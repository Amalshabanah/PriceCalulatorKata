using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            
            //ToDp: Inject Repo and Print service here.
            var productService = new ProductService();
            
            productService.CalculateAndPrintPriceInfo();
        }
    }
}