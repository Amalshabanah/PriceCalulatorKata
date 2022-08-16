using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductService : IProductService
{
    private IProductRepository _productRepo = new ProductRepository();

    public Product CalculateAndPrintTaxInfo()
    {
        return _productRepo.GetFirstProductData();
    }

    public double CalculatePriceAfterTax(double price , double tax)
    {
       return Math.Round(price + price * (tax / 100) , 2);
    }
}