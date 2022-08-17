using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductService : IProductService
{ 
    private IProductRepository _productRepo = new ProductRepository();
    private IProductPrintService _productPrint = new ProductPrintService();
    
    public double CalculatePriceAfterTax(double price , double tax)
    {
       return Math.Round(price + price * (tax / 100) , 2);
    }
    
    public void CalculateAndPrintPriceInfo()
    {
        Product product = _productRepo.GetFirstProductData();
        double priceAfterTax = CalculatePriceAfterTax(product.Price, product.Tax);
        _productPrint.PrintTaxInfo();
    }
}