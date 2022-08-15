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
            product.PrintInfo(product.ProductName, product.Upc , product.Price);
            product.PrintFinalPrice(product.Price, product.Tax , product.Discount );
        }
    }
}