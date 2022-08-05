namespace PriceCalKata.Services;
public interface IProductService
{
    public double CalculatePriceAfterTax(double price, double tax) ;
    
    public void PrintInfo(string? productName, double upc, double price);
    
    public void PrintTax(double price, double tax, double priceAfterTax);

    public double CalcualteTaxAmount(double price, double tax);

    public double CalculateDiscountAmount(double price, double discount);

    public void PrintFinalPrice(double price, double tax, double discount);

    public double CalculateFinalPrice(double price, double tax, double discount);
}