namespace PriceCalKata.Services;

public static class ProductServices
{
    public static double PriceAfterTax(double price, double tax) => price + price * (tax / 100);
    public static void PrintInfo(string? productName , double upc , double price)
    {
        Console.WriteLine($"Sample product : Book with name = {productName} , UPC = {upc}, price = ${price.ToString("0.00")}.");
    }
    public static void PrintTax(double price, double tax , double priceAfterTax)
    {
        Console.WriteLine($"Product price reported as ${price.ToString("0.00")}  before tax , and ${priceAfterTax.ToString("0.00")} after {tax}% tax.");
    }
}