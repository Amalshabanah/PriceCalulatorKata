using PriceCalKata.Repositories;
namespace PriceCalKata.Services;
public class ProductService : PrintService, IProductService 
{
    public double CalculatePriceAfterTax(double price, double tax) => Math.Round(price + price * (tax / 100) , 2);
}