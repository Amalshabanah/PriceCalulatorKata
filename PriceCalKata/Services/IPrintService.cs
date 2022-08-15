namespace PriceCalKata.Services;

public interface IPrintService
{
    public  void  PrintInfo(string productName, double upc, double price);

    public  void PrintTax(double price, double tax, double priceAfterTax);
}