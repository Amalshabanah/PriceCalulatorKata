namespace PriceCalKata.Services;

public class ProductServices : IProductService
{
    public double CalculatePriceAfterTax(double price , double tax) => Math.Round((double)(price + price * (tax / 100)) , 2);

    public void PrintInfo(string? productName , double upc , double price)
    {
        Console.WriteLine($"Sample product : Book with name = {productName} , UPC = {upc}, price = ${price.ToString("0.00")}.");
    }
    
    public double CalcualteTaxAmount(double price , double tax) => Math.Round((double)price * (tax / 100) , 2);

    public double CalculateDiscountAmount(double price , double discount) => Math.Round((double)price * (discount / 100), 2);

    public double CalculatePriceAfterDiscount(double price , double upcDiscount) => Math.Round((double)(price - CalculateDiscountAmount(price, upcDiscount)) , 2);
    
    public double CalculateFinalPrice(double price, double tax , double discount, double upcDiscount)
    {
        double priceAfterUpcDiscount = CalculatePriceAfterDiscount(price , upcDiscount);
        double taxAmount = CalcualteTaxAmount(priceAfterUpcDiscount , tax);
        double discountAmount = CalculateDiscountAmount(priceAfterUpcDiscount , discount);
      return  Math.Round((double)(priceAfterUpcDiscount + taxAmount - discountAmount) , 2);
    }

public void  PrintFinalPrice(double price , double tax , double discount , double upcDiscount)
     {
         if (discount == 0)
         {
             Console.WriteLine($"Price : ${CalculateFinalPrice(price , tax , discount , upcDiscount)}");
         }
         else
         {
             double priceAfterUpcDiscount = CalculatePriceAfterDiscount(price , upcDiscount);
             Console.WriteLine($"Price : ${CalculateFinalPrice(price ,tax , discount  , upcDiscount).ToString("0.00")} \n" +
             $"Dicount Amount :${(CalculateDiscountAmount(price , upcDiscount) + CalculateDiscountAmount(priceAfterUpcDiscount , discount )).ToString("0.00")}.");
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