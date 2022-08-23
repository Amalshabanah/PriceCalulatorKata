using PriceCalKata.Models;

namespace PriceCalKata.Services;
public class ProductPrintService :  IProductPrintService
{
    public void PrintTaxInfo(Product product , double priceAfterTax)
    {
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc} , "+
                          $"price = ${product.Price.ToString("0.00")}.");
        
        Console.WriteLine($"Product price reported as ${product.Price.ToString("0.00")} before tax ," +
                          $" and ${priceAfterTax} " +
                          $"after {product.Tax}% tax.");
    }
    
    public void PrintTaxInfoWithCurrency(Product product , double priceAfterTax, string currency, double tax )
    {
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc} , "+
                          $"price = ${product.Price.ToString("0.00")}.");

        Console.WriteLine($"Cost: {product.PriceWithCurrency}\n" +
                          $"Tax: {tax} {currency}\n" +
                          $"Total: {priceAfterTax} {currency}\n");
    }
    
    public void PrintPriceInfo(Product product , double finalPrice)
    {
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc} , "+
                          $"price = ${product.Price.ToString("0.00")}.");

        Console.WriteLine($"Price Before : ${product.Price.ToString("0.00")} ," +
                          $" Price After : ${finalPrice}");
    }

    public void PrintDeductedAmount(double discountAmount)
    {
        Console.WriteLine($"${discountAmount} amount was deduced.\n");
    }
}