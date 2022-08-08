using PriceCalKata.Repositories;
namespace PriceCalKata.Services;
public class ProductServices : ProductRepository , IProductService 
{
    public double CalculatePriceAfterTax(double price, double tax) =>
        price + price * (tax / 100);

    public void PrintInfo(string? productName , double upc , double price)
    {
        Console.WriteLine($"Sample product : Book with name = {productName} , UPC = {upc}, price = ${price.ToString("0.00")}.");
    }
    
     public void PrintTax(double price , double tax , double priceAfterTax)
    {
        Console.WriteLine($"Product price reported as ${price.ToString("0.00")} before tax , and ${priceAfterTax.ToString("0.00")} after {tax}% tax.");
    }

     public double CalcualteTaxAmount(double price , double tax) => price * (tax / 100);

     public double CalculateDiscountAmount(double price, double discount, double upcDisount) =>
         price * (discount / 100) + price * (upcDisount / 100);

     public double CalculateFinalPrice(double price, double tax, double discount , double upcDiscount) =>
         price + CalcualteTaxAmount(price, tax) - CalculateDiscountAmount(price, discount , upcDiscount);
    
     public void  PrintFinalPrice(double price, double tax, double discount , double upcDiscount)
     {
         if (discount == 0)
         {
             
             Console.WriteLine($"Price : ${CalculateFinalPrice(price, tax, discount , upcDiscount)}");
         }
         else
         {
             Console.WriteLine($"Price : ${CalculateFinalPrice(price ,tax ,discount  , upcDiscount).ToString("0.00")} \n" +
             $"Dicount Amount :${CalculateDiscountAmount(price ,discount , upcDiscount).ToString("0.00")}.");
         }
     }
     
     
     public int DiscountAfterCheckUpc(int upc , int upcToCheck)
     {
         if (upc == upcToCheck)
             return 7;
         else
             return 0;
     }
}