using PriceCalKata.Services;
namespace PriceCalKata.Models;
public class Product : ProductServices
{
    public Product(string name , int upc , double price)
    {
        ProductName = name;
        Upc = upc;
        Price = price;
    }
}