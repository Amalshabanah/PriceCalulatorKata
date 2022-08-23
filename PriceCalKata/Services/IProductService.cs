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
    
    double CalculateFinalPriceWithExpenses(double price , double tax , double discount , double upcDiscount , string packaging , string transport);
    
    double CalculateCostAmount(double price, double amount);
    
    double CalculatePackagingAndTransportCost(string packaging, string transport, double price);

    double RemovePercentage(String amount);

    double RemoveDollar(String amount);
}