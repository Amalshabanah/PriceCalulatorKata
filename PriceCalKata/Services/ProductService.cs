using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductService : IProductService
{ 
    
    //ToDo: 1. Make them read only.
    //2. Remove Creation.
    //2. Inject Them to Constructor
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
        
        //ToDo: Let PrintTaxInfo Take Product take product and priceAfterTax as a parameter
        _productPrint.PrintTaxInfo();
    }
}