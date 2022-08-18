namespace PriceCalKata.Services;
public interface IProductService
{
    public void CalculateAndPrintPriceInfo();
    
    public double CalculateDiscountAmount(double price, double discount);
    
    public double CalculateTaxAmount(double price, double tax);

    public double CalculateFinalPrice(double price, double tax, double discount);
}