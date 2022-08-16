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

     public double CalculateDiscountAmount(double price, double discount)
     {
          return Math.Round(price * (discount / 100), 2);
     }

     public double CalculateUpcDiscountAmount(double price, double discount, double upcDiscount)
     {
        return Math.Round(price * (upcDiscount / 100), 2);
     }

     public double CalculateFinalPrice(double price, double tax, double discount, double upcDiscount)
     {
         double priceAfterUpcDiscount = price - CalculateDiscountAmount(price, upcDiscount);
         double taxAmount = CalcualteTaxAmount(priceAfterUpcDiscount, tax);
         double discountAmount = CalculateDiscountAmount(priceAfterUpcDiscount, discount);
         return Math.Round((priceAfterUpcDiscount + taxAmount - discountAmount), 2);
     }

     public void PrintFinalPrice(double price , double tax , double discount , double upcDiscount)
     {
         double priceAfterUpcDiscount = price - CalculateDiscountAmount(price, upcDiscount);
         double discountAmount = CalculateDiscountAmount(priceAfterUpcDiscount, discount);
         
         if (discount == 0)
         Console.WriteLine($"Price after = ${CalculateFinalPrice(price , tax ,discount , upcDiscount).ToString("0.00")}");

         else
         {
             Console.WriteLine($"Price after = ${CalculateFinalPrice(price , tax ,discount , upcDiscount).ToString("0.00")}"+
                               $"\nAmount Deducted ${CalculateDiscountAmount(price , upcDiscount) + CalculateDiscountAmount(priceAfterUpcDiscount , discount)}");
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
