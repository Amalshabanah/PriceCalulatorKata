using PriceCalKata.Models;

namespace PriceCalKata.Services;
public interface IProductPrintService
{
    public void PrintTaxInfo(Product product);
}