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
       return price + TaxAmount(price, tax) - DiscountAmount(price, discount);
    }

    public double DiscountAmount(double price, double discount)
    {
        return Math.Round(price * (discount / 100) , 2);
    }

    public double TaxAmount(double price, double tax)
    {
        return Math.Round(price * (tax / 100) , 2);
    }

    public void CalculateAndPrintPriceInfo()
    {
        Product product = _productRepo.GetFirstProductData();
        var priceAfterTax = CalculatePriceAfterTaxAndDiscount(product.Price, product.Tax , product.Discount);
        
        _productPrint.PrintTaxInfo(product , priceAfterTax);
    }
}