using PriceCalKata.Services;

namespace PriceCalKata
{
    public class program
    { 
        public static void Main(string[] args)
        {
            var product = new ProductDataPrint().GetProductData();
            var productPrint = new ProductPrintService();

            productPrint.PrintTaxInfo(product);
        }
    }
}