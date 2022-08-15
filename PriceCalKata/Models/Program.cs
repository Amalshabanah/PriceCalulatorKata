using PriceCalKata.Repositories;
namespace PriceCalKata.Models
{
    public class program
    { 
        public static void Main(string[] args)
        {
            Product product = null;
            ProductRepository productRepo = new ProductRepository();
            product = productRepo.GetFirstProductData();
             
            double priceAfterTax = product.CalculatePriceAfterTax(product.Price , product.Tax);
            
            product.PrintInfo(product.ProductName, product.Upc , product.Price);
            product.PrintTax(product.Price, product.Tax , priceAfterTax);
        }
    }
}