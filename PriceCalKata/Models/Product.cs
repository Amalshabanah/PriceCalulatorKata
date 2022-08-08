using PriceCalKata.Services;
namespace PriceCalKata.Models;
public class Product : ProductServices
{ 
    public double Tax { get; set; }
    public string? ProductName { get; set; }
    public double Price { get; set; }
    public int Upc { get; set; }
    public double Discount { get; set; }
    public Product(string name , int upc , double price)
    {
        ProductName = name;
        Upc = upc;
        Price = price;
    }
    public Product()
    {
        
    }
}