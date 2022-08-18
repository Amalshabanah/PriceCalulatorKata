using PriceCalKata.Models;

namespace PriceCalKata.Repositories;
public interface IProductRepository
{ 
    public  Product GetFirstProductData();

    public List<Product> GetAllProduct();
}