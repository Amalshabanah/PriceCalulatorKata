using PriceCalKata.Models;

namespace PriceCalKata.Repositories;
public interface IProductRepository
{ 
    Product GetFirstProductData();
    
    List<Product> GetAllProduct();
}