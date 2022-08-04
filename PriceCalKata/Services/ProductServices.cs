namespace PriceCalKata.Services;

public class ProductServices : IProductService
{
    public double CalculatePriceAfterTax(double price, double tax) => price + price * (tax / 100);
    public void PrintInfo(string? productName , double upc , double price)
    {
        Console.WriteLine($"Sample product : Book with name = {productName} , UPC = {upc}, price = ${price.ToString("0.00")}.");
    }
     public void PrintTax(double price, double tax , double priceAfterTax)
    {
        Console.WriteLine($"Product price reported as ${price.ToString("0.00")} before tax , and ${priceAfterTax.ToString("0.00")} after {tax}% tax.");
    }
}