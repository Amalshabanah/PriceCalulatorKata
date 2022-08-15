using PriceCalKata.Services;
namespace PriceCalKata.Models;
public class Product : ProductServices
{ 
    public double Tax { get; set; }
    public string? ProductName { get; set; }
    public double Price { get; set; }
    public double Upc { get; set; }
    public double Discount { get; set; }
    
    public Product(string name , int upc , double price , double tax , double discount )
    {
        ProductName = name;
        Upc = upc;
        Price = price;
        Tax = tax;
        Discount = discount;
    }
    
    public Product()
    {

    }
}