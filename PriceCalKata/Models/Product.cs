using PriceCalKata.Services;
namespace PriceCalKata.Models;
public class Product : ProductServices 
{
    public double Tax { get; set; }
    public string? ProductName { get; set; }
    public double Price { get; set; }
    public double Upc { get; set; }
    public Product(string name , int upc , double price)
    {
        ProductName = name;
        Upc = upc;
        Price = price;
    }
}