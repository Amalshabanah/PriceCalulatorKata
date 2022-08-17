using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductPrintService :  IProductPrintService
{
    private IProductRepository _productRepo = new ProductRepository();

    //ToDo: Let PrintTaxInfo Take Product take product and priceAfterTax as a parameter
    public void PrintTaxInfo()
    {
        //Remove L12, violating loose coupling principle
        Product product = _productRepo.GetFirstProductData();
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc},"+
                          $"price = ${product.Price.ToString("0.00")}.");
        //ToDo: Remove CalculatePriceAfterTax, put it's value instead -priceAfterTax-
        Console.WriteLine($"Product price reported as ${product.Price.ToString("0.00")} before tax ," +
                          $" and ${product.CalculatePriceAfterTax(product.Price , product.Tax).ToString("0.00")} "+
                          $"after {product.Tax}% tax.");
    }
}