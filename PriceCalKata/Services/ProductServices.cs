using PriceCalKata.Repositories;
namespace PriceCalKata.Services;
public class ProductServices : ProductRepository , IProductService 
{
    public double CalculatePriceAfterTax(double price, double tax) => Math.Round(
        price + price * (tax / 100) , 2);

    public void PrintInfo(string? productName , double upc , double price)
    {
        Console.WriteLine($"Sample product : Book with name = {productName} , UPC = {upc}, price = ${price.ToString("0.00")}.");
    }
    
     public void PrintTax(double price , double tax , double priceAfterTax)
    {
        Console.WriteLine($"Product price reported as ${price.ToString("0.00")} before tax ," +
                          $" and ${priceAfterTax.ToString("0.00")} after {tax}% tax.");
    }

     public double CalcualteTaxAmount(double price , double tax) => Math.Round(price * (tax / 100),2);

     public double CalculateDiscountAmount(double price , double discount) => Math.Round(price * (discount / 100) , 2);

     public double CalculateFinalPrice(double price, double tax, double discount) =>Math.Round(
         CalculatePriceAfterTax(price,  tax) - CalculateDiscountAmount(price, discount) , 2);
     
     public void PrintFinalPrice(double price , double tax , double discount)
     {
         Console.WriteLine($"Price before = ${price}, Price after = ${CalculateFinalPrice(price , tax ,discount).ToString("0.00")}");
     }
}