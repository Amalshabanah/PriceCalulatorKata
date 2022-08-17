using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductService : IProductService
{
    //ToDo: 1. Make them read only.
    //2. Remove Creation.
    //2. Inject Them to Constructor
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
        double priceAfterTax = CalculatePriceAfterTax(product.Price, product.Tax);
        
        //ToDo: Let PrintTaxInfo Take Product take product and priceAfterTax as a parameter
        _productPrint.PrintTaxInfo(product , priceAfterTax);
    }
}