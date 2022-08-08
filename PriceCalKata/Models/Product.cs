using System.Security.AccessControl;
using System.Security.AccessControl;
using PriceCalKata.Repositories;
using PriceCalKata.Services;
namespace PriceCalKata.Models;

public class Product : ProductServices
{ 
    public double Tax { get; set; }
    public string? ProductName { get; set; }
    public double Price { get; set; }
    public int Upc { get; set; }
    public double Discount { get; set; }
    public int UpcWithDiscount { get; } = 12345;
    public  double UpcDiscount { get; set; }
    public double PackagingCost { get; set; }
    public double TransportCost { get; set; }

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