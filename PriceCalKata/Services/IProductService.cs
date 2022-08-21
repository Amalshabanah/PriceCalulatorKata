namespace PriceCalKata.Services;
public interface IProductService
{
    double CalculateDiscountAmount(double price, double discount);

    double CalculateTaxAmount(double price, double tax);

    double CalculatePriceAfterTax(double price, double tax);

    void CalculateAndPrintPriceInfoAfterTax();

    void CalculateAndPrintPriceInfoAfterDiscount();
    
    double CalculateDiscountAfterCheckUpc(double upc, double upcToCheck);

    void CalculateAndPrintPriceAfterPrecedenceDiscount();
    public double CalculateFinalPriceWithExpenses(double price , double tax , double discount , double upcDiscount , double packaging , double transport);

    public double CalculateCostAmount(double price, double amount);
}
