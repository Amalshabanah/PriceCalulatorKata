namespace PriceCalKata.Services;
public interface IProductService
{
    public void CalculateAndPrintPriceInfo();

    public double CalculatePriceAfterTaxAndDiscount(double price, double tax , double discount);

    public double DiscountAmount(double price, double discount);
    
    public double TaxAmount(double price, double tax);
}