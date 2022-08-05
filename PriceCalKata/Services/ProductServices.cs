namespace PriceCalKata.Services;
public class ProductServices : IProductService
{
    public double CalculatePriceAfterTax(double price, double tax) => price + price * (tax / 100);
    
    public void PrintInfo(string? productName , double upc , double price)
    {
        Console.WriteLine($"Sample product : Book with name = {productName} , UPC = {upc}, price = ${price.ToString("0.00")}.");
    }
    
     public void PrintTax(double price, double tax , double priceAfterTax)
    {
        Console.WriteLine($"Product price reported as ${price.ToString("0.00")} before tax , and ${priceAfterTax.ToString("0.00")} after {tax}% tax.");
    }

     public double CalcualteTaxAmount(double price , double tax) => price * (tax / 100);

     public double CalculateDiscountAmount(double price , double discount) => price * (discount / 100);

     public double CalculateFinalPrice(double price, double tax, double discount) =>
         price + CalcualteTaxAmount(price, tax) - CalculateDiscountAmount(price, discount);
    
     public void  PrintFinalPrice(double price, double tax, double discount)
     {
         if (discount == 0)
         {
             Console.WriteLine($"Price : ${CalculateFinalPrice(price, tax, discount)}");
         }
         else
         {
             Console.WriteLine($"Price : ${CalculateFinalPrice(price ,tax ,discount).ToString("0.00")} \n" +
             $"${CalculateDiscountAmount(price ,discount).ToString("0.00")} was deduced.");
         }
     }
}