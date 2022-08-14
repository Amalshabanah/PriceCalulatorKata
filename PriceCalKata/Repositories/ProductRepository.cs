using PriceCalKata.Models;
namespace PriceCalKata.Repositories;

public class ProductRepository :  IProductRepository
{
    public static Product GetProductData()
    {
        List <Product> _products = new List<Product>();
        _products.Add(new Product("The Little Prince", 12345, 20.25 , 20));
        
        return _products[0];
    }
    
    public double ReadTax()
    {
        return 20;
    }
}

