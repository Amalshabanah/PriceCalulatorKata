namespace PriceCalKata.Services;

public interface IProductService
{
    double Tax { get; set; }
    string? ProductName { get; set; }
    double Price { get; set; }
    double Upc { get; set; }

    public double CalculatePriceAfterTax(double price , double tax);

    public void PrintInfo(string? productName , double upc , double price);

    public void PrintTax(double price , double tax , double priceAfterTax);
}