namespace PriceCalKata.Services;
public interface IProductService
{
    double CalculateDiscountAmount(double price, double discount);

    double CalculateTaxAmount(double price, double tax);

    double CalculatePriceAfterTax(double price, double tax);

    void CalculateAndPrintPriceInfoAfterTax();

    void CalculateAndPrintPriceInfoAfterDiscount();
}