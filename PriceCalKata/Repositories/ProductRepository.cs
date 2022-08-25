using PriceCalKata.Models;

namespace PriceCalKata.Repositories;
public class ProductRepository : IProductRepository
{
    private static  List<Product> _products = new List<Product>
    {
        new Product { ProductName = "The Big Prince", Upc = 123, Tax = 21 ,Price = 20.25},
        new Product { ProductName = "The Huge Prince" , Upc = 12345, Price = 20.25 ,Tax = 21, Discount = 15, PackagingCost = "1%" , TransportCost = "$2.2"},
        new Product { ProductName = "The A Prince", Upc = 789, Price = 20.25, Tax = 21 , Discount = 15},
        new Product { ProductName = "The W Prince", Upc = 125, Price = 90, Tax = 70 , Discount = 10},
        new Product {ProductName = "The Prince", Upc = 12345, Price = 20.25, Tax = 21, Discount = 15, Cap = "20%"},
        new Product {ProductName = "The Prince", Upc = 12345, Price = 20.25, Tax = 21, Discount = 15, Cap = "$4"}, 
        new Product {ProductName = "The Prince", Upc = 12345, Price = 20.25, Tax = 21, Discount = 15, Cap = "30%"},
        new Product {ProductName = "The S Prince", Upc = 111, Tax = 20, PriceWithCurrency = "20.25 USD"},
        new Product {ProductName = "The ww Prince", Upc = 13, Tax = 20, PriceWithCurrency = "17.76 GBP"},
        new Product {ProductName = "T", Upc = 12345, Tax = 21, Discount = 15, PriceWithCurrency = "20.25 USD", TransportCost = "3%"}
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