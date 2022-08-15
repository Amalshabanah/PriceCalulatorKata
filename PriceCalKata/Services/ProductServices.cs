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

     public double CalculateUpcDiscountAmount(double price , double discount , double upcDiscount) => Math.Round(price * (upcDiscount / 100) , 2);

     public double CalculateFinalPrice(double price, double tax, double discount , double upcDiscount)
     {
         return Math.Round(CalculatePriceAfterTax(price, tax) - CalculateDiscountAmount(price, discount), 2) -CalculateDiscountAmount(price , upcDiscount);
     }

     public void PrintFinalPrice(double price , double tax , double discount , double upcDisount)
     {
         if (discount == 0)
         Console.WriteLine($"Price after = ${CalculateFinalPrice(price , tax ,discount , upcDisount).ToString("0.00")}");

         else
         {
             Console.WriteLine($"Price after = ${CalculateFinalPrice(price , tax ,discount , upcDisount).ToString("0.00")}"+
                               $"\nAmount Deducted ${CalculateDiscountAmount(price , discount) + CalculateDiscountAmount(price , upcDisount)}");
         }
     }
     public int CalculateDiscountAfterCheckUpc(int upc , int upcToCheck)
     {
         if (upc == upcToCheck)
             return 7;
         else
             return 0;
     }
}
