using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductPrintService :  IProductPrintService
{
    private IProductRepository _productRepo = new ProductRepository();

    public void PrintTaxInfo()
    {
        Product product = _productRepo.GetFirstProductData();
        Console.WriteLine($"Sample product : Book with name = {product.ProductName} , UPC = {product.Upc},"+
                          $"price = ${product.Price.ToString("0.00")}.");
        Console.WriteLine($"Product price reported as ${product.Price.ToString("0.00")} before tax ," +
                          $" and ${product.CalculatePriceAfterTax(product.Price , product.Tax).ToString("0.00")} "+
                          $"after {product.Tax}% tax.");
    }
}