using PriceCalKata.Repositories;
namespace PriceCalKata.Services;
public class ProductServices : IProductService 
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

     public double CalculatePriceAfterDiscount(double price , double upcDiscount) => Math.Round((double)(price - CalculateDiscountAmount(price, upcDiscount)) , 2);
     

     public double CalculateFinalPrice(double price, double tax , double discount , double upcDiscount , double packaging , double transport)
    { 
        double priceAfterTax = CalculatePriceAfterTax(price, tax);
        double discountAmount = CalculateDiscountAmount(price, upcDiscount) +
                                CalculateDiscountAmount(price, discount);
        double costAmount = CalculateCostAmount(price, packaging) + Math.Round((double) transport,2);
        
        return  Math.Round((double)(priceAfterTax - discountAmount + costAmount) , 2);
    }

    public double CalculateCostAmount(double price, double amount) =>  Math.Round((double)price * (amount / 100),2);

     public void PrintFinalPrice(double price , double tax , double discount , double upcDiscount , double packaging , double transport)
     {
         double priceAfterUpcDiscount = price - CalculateDiscountAmount(price, upcDiscount);
         double discountAmount = CalculateDiscountAmount(priceAfterUpcDiscount, discount);

         if (discount == 0)
         {
             Console.WriteLine(
                 $"Price after = ${CalculateFinalPrice(price, tax, discount, upcDiscount, packaging, transport).ToString("0.00")}");
         }
         else
         {
             Console.WriteLine($"Price : ${CalculateFinalPrice(price , tax , discount  , upcDiscount ,packaging ,transport).ToString("0.00")} \n" +
                               $"Dicount Amount :${(CalculateDiscountAmount(price , upcDiscount) + CalculateDiscountAmount(price , discount )).ToString("0.00")}.");
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