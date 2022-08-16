using PriceCalKata.Models;

namespace PriceCalKata.Services;
public interface IProductService 
{ 
    public double CalculatePriceAfterTax(double price , double tax);
    Product CalculateAndPrintTaxInfo();
}