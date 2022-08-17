using PriceCalKata.Models;

namespace PriceCalKata.Services;
public interface IProductPrintService 
{ 
    void PrintTaxInfo(Product product, double priceAfterTax);
}