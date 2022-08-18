using PriceCalKata.Models;

namespace PriceCalKata.Services;
public interface IProductPrintService 
{ 
    void PrintPriceInfo(Product product , double priceAfterTax);

    public void PrintDeductedAmount(double discountAmount);
}