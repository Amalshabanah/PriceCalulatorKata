using PriceCalKata.Repositories;
namespace PriceCalKata.Models
{
    public class program
    { 
        public static void Main(string[] args)
        {
            ProductRepository productRepo = new ProductRepository();
            var product = productRepo.GetFirstProductData();
            
            product.UpcDiscount = product.CalculateDiscountAfterCheckUpc(product.UpcWithDiscount , product.Upc);

            product.PrintInfo(product.ProductName, product.Upc , product.Price);
            product.PrintFinalPrice(product.Price, product.Tax , product.Discount , product.UpcDiscount , product.PackagingCost , product.TransportCost);
        }
    }
}