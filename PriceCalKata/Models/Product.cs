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
    
    public string PackagingCost { get; set; }

    public string TransportCost { get; set; }
    
    public string Cap { get; set; }
    
    public string PriceWithCurrency { get; set; }
}