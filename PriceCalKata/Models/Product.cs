using PriceCalKata.Services;
namespace PriceCalKata.Models;
public class Product : ProductServices
{
    public string ProductName { get; set; }
    public int Upc { get; set; }
    public double Price { get; set; }
    public double Tax { get; set; }
    public Product(string name, int upc, double price)
    {
        ProductName = name;
        Upc = upc;
        Price = price;
    }
}