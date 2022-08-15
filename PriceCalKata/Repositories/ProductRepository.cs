using PriceCalKata.Models;
namespace PriceCalKata.Repositories;
public class ProductRepository : IProductRepository
{
    public Product GetFirstProductData()
  {
      var _products= CreateList();
     return _products.FirstOrDefault();
  }
    
    public List<Product> CreateList()
  {
      List<Product?> _products = new List<Product?>
      {
          new Product { ProductName = "The Little Prince", Upc = 1245, Price = 20.25, Tax = 20 , Discount = 15 },
          new Product { ProductName = "The j Prince", Upc = 12345, Price = 20.25, Tax = 21 , Discount = 15},
          new Product { ProductName = "The A Prince", Upc = 15, Price = 20.25, Tax = 80,  Discount = 15 },
          new Product { ProductName = "The W Prince", Upc = 125, Price = 20.25, Tax = 70 , Discount = 15 }
      };
      return _products;
  }

  public ProductRepository()
    {
        
    }
}


