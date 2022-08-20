using PriceCalKata.Models;

namespace PriceCalKata.Repositories;
public class ProductRepository : IProductRepository
{
    private static  List<Product> _products = new List<Product>
    {
        new Product { ProductName = "The Little Prince", Upc = 12345, Price = 20.25, Tax = 20 , Discount = 15},
        new Product { ProductName = "The Big Prince", Upc = 123, Price = 45.25 , Discount = 12},
        new Product { ProductName = "The A Prince", Upc = 15, Price = 5.5, Tax = 80 , Discount = 50},
        new Product { ProductName = "The W Prince", Upc = 125, Price = 90, Tax = 70 , Discount = 10}
    };
    
    public Product GetFirstProductData()
  {
      return _products.FirstOrDefault();
  }

    public List <Product> GetAllProduct()
    {
        return _products;
    }
}