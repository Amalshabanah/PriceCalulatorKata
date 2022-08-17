using PriceCalKata.Models;

namespace PriceCalKata.Services;
public class ProductPrintService :  IProductPrintService
{
    //ToDo: Let PrintTaxInfo Take Product take product and priceAfterTax as a parameter
    public void PrintTaxInfo(Product product , double priceAfterTax)
    {
        //Remove L12, violating loose coupling principle
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc} , "+
                          $"price = ${product.Price.ToString("0.00")}.");
        //ToDo: Remove CalculatePriceAfterTax, put it's value instead -priceAfterTax-
        Console.WriteLine($"Product price reported as ${product.Price.ToString("0.00")} before tax ," +
                          $" and ${priceAfterTax} " +
                          $"after {product.Tax}% tax.");
    }
}