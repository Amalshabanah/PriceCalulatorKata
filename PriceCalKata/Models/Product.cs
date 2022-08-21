namespace PriceCalKata.Models;
public class Product 
{ 
    public double Tax { get; set; }
    
    public string ProductName { get; set; }
    
    public double Price { get; set; }

    public double Upc { get; set; }
    
    public double Discount { get; set; }
    
    public double UpcWithDiscount { get; } = 12345;
    
    public  double UpcDiscount { get; set; }
}