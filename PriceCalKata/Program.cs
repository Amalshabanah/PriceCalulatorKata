using PriceCalKata.Repositories;
using PriceCalKata.Services;

namespace PriceCalKata.Models
{
    public class program
    { 
        public static void Main(string[] args)
        {
            var productRepo = new ProductRepository();
            var product = productRepo.GetFirstProductData();
             
            double priceAfterTax = product.CalculatePriceAfterTax(product.Price , product.Tax);
            IPrintService productPrint = new Product(); 
            
            productPrint.PrintInfo(product.ProductName, product.Upc , product.Price);
            productPrint.PrintTax(product.Price, product.Tax , priceAfterTax);
            
        }
    }
}