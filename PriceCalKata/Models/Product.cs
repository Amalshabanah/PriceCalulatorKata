using PriceCalKata.Repositories;
using PriceCalKata.Services;

namespace PriceCalKata.Models;
public class Product : ProductService 
{ 
    public double Tax { get; set; }
    
    public string ProductName { get; set; }
    
    public double Price { get; set; }
    
    public double Upc { get; set; }
}