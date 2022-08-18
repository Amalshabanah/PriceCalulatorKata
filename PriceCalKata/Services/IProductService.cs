namespace PriceCalKata.Services;
public interface IProductService
{
    void CalculateAndPrintPriceInfo();
    
    double CalculateDiscountAmount(double price, double discount);
    
    double CalculateTaxAmount(double price, double tax);

    double CalculateFinalPrice(double price, double tax, double discount);
}