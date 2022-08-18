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

    public double CalculatePriceAfterTaxAndDiscount(double price , double tax , double discount)
    {
       return price + CalculateTaxAmount(price, tax) - CalculateDiscountAmount(price, discount);
    }

    public double CalculateDiscountAmount(double price, double discount)
    {
        return Math.Round(price * (discount / 100) , 2);
    }

    public double CalculateTaxAmount(double price, double tax)
    {
        return Math.Round(price * (tax / 100) , 2);
    }

    public void CalculateAndPrintPriceInfo()
    {
        Product product = _productRepo.GetFirstProductData();
        var priceFinalPrice = CalculatePriceAfterTaxAndDiscount(product.Price, product.Tax , product.Discount);
        
        _productPrint.PrintPriceInfo(product , priceFinalPrice);
    }
}