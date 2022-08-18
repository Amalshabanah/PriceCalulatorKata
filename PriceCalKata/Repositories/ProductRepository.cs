using PriceCalKata.Models;

namespace PriceCalKata.Repositories;
public class ProductRepository : IProductRepository
{
    private static  List<Product> _products = new List<Product>
    {
        new Product { ProductName = "The Little Prince", Upc = 1245, Price = 20.25, Tax = 20 , Discount = 15},
        new Product { ProductName = "The j Prince", Upc = 12345, Price = 45.25, Tax = 21 , Discount = 25},
        new Product { ProductName = "The A Prince", Upc = 15, Price = 5.5, Tax = 80 , Discount = 50},
        new Product { ProductName = "The W Prince", Upc = 125, Price = 90, Tax = 70 , Discount = 10}
    };
    
    public Product GetFirstProductData()
  {
      return _products.FirstOrDefault();
  }
}