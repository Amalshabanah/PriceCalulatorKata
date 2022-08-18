using PriceCalKata.Models;

namespace PriceCalKata.Services;
public interface IProductPrintService
{
    void PrintTaxInfo(Product product, double priceAfterTax);

    void PrintPriceInfo(Product product , double priceAfterTax);

    void PrintDeductedAmount(double discountAmount);
}