namespace PriceCalKata.Services;
public class ProductService : IProductService 
{
    public double CalculatePriceAfterTax(double price, double tax) => Math.Round(price + price * (tax / 100) , 2);
}