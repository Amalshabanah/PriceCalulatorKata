using PriceCalKata.Models;

namespace PriceCalKata.Services;
public class ProductPrintService :  IProductPrintService
{
    public void PrintTaxInfo(Product product , double priceAfterTax)
    {
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc} , "+
                          $"price = ${product.Price.ToString("0.00")}.");

        Console.WriteLine($"Price Before : ${product.Price.ToString("0.00")} ," +
                          $" Price After : ${priceAfterTax}");
    }
}