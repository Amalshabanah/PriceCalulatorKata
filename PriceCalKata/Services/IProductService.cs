namespace PriceCalKata.Services;
public interface IProductService
{
    public void CalculateAndPrintPriceInfo();

    public double CalculatePriceAfterTax(double price, double tax);
}