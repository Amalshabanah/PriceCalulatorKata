namespace PriceCalKata.Services;
public interface IProductService 
{ 
    public double CalculatePriceAfterTax(double price , double tax);
}