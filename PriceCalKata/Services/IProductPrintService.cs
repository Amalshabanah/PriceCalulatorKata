using PriceCalKata.Models;

namespace PriceCalKata.Services;
public interface IProductPrintService
{
    public void PrintPriceBeforeAndAfterTax(Product product);
}