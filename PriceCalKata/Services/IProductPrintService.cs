using PriceCalKata.Models;

namespace PriceCalKata.Services;
public interface IProductPrintService
{
    public void PrintTaxInfo(Product product, double priceAfterTax);
    
    void PrintPriceInfo(Product product, double finalPrice);
}