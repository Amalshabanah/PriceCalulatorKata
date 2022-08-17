using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepo;
    private readonly IProductPrintService _productPrint;

    public ProductService(IProductRepository productRepo , IProductPrintService productPrint)
    {
        _productRepo = productRepo;
        _productPrint = productPrint;
    }

    protected ProductService()
    {
    }

    public double CalculatePriceAfterTax(double price , double tax)
    {
       return Math.Round(price + price * (tax / 100) , 2);
    }
    
    public void CalculateAndPrintPriceInfo()
    {
        Product product = _productRepo.GetFirstProductData();
        var priceAfterTax = CalculatePriceAfterTax(product.Price, product.Tax);
        
        _productPrint.PrintTaxInfo(product , priceAfterTax);
    }
}