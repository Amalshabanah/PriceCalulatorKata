using PriceCalKata.Models;

namespace PriceCalKata.Services;
public class ProductPrintService :  IProductPrintService
{
    public void PrintTaxInfo(Product product)
    {
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc}, price = ${product.Price.ToString("0.00")}.");
        Console.WriteLine($"Product price reported as ${product.Price.ToString("0.00")} before tax ," +
                          $" and ${product.CalculatePriceAfterTax(product.Price , product.Tax).ToString("0.00")} after {product.Tax}% tax.");
    }
}