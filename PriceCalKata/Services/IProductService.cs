namespace PriceCalKata.Services;
public interface IProductService 
{ 
    public double CalculatePriceAfterTax(double price , double tax);

    public void PrintInfo(string? productName , double upc , double price);
    
    public void PrintTax(double price , double tax , double priceAfterTax);
}