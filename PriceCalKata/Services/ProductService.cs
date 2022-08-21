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
    
    public double CalculateFinalPrice(double price , double tax , double discount)
    {
        return price + CalculateTaxAmount(price, tax) - CalculateDiscountAmount(price, discount);
    }
    
    public double CalculateFinalPriceSelectiveDiscount(double price , double tax , double discount , double upcDiscount)
    {
        return Math.Round( price + CalculateTaxAmount(price, tax) - CalculateDiscountAmount(price, discount)
                     - CalculateDiscountAmount(price , upcDiscount) , 2);
    }
    
    public double CalculateDiscountAmount(double price, double discount)
    {
        return Math.Round(price * (discount / 100) , 2);
    }
   
    public double CalculateTaxAmount(double price, double tax)
    {
        return Math.Round(price * (tax / 100) , 2);
    }
    
    public double CalculatePriceAfterTax(double price , double tax)
    {
        return Math.Round(price + CalculateTaxAmount(price , tax) , 2);
    }
    
    public void CalculateAndPrintPriceInfoAfterTax()
    {
        Product product = _productRepo.GetFirstProductData();
        var priceAfterTax = CalculatePriceAfterTax(product.Price, product.Tax);
        
        _productPrint.PrintTaxInfo(product , priceAfterTax);
    }
    
    public void CalculateAndPrintPriceInfoAfterSelectiveDiscount()
    {
        var productWithUpcDiscount = _productRepo.GetAllProduct().
            FirstOrDefault(product => product.Upc == product.UpcWithDiscount);
        var productWithoutUpcDiscount = _productRepo.GetAllProduct()
            .FirstOrDefault(product => product.Upc != product.UpcWithDiscount 
            && product.Discount != 0);
        var products = new[] { productWithUpcDiscount , productWithoutUpcDiscount };
        
        foreach (var product in products)
        {
            var upcDiscount = CalculateDiscountAfterCheckUpc(product.Upc , product.UpcWithDiscount);
            var finalPrice = CalculateFinalPriceSelectiveDiscount(product.Price, product.Tax , product.Discount , upcDiscount);
            var discountAmount = CalculateDiscountAmount(product.Price , product.Discount)
                                      + CalculateDiscountAmount(product.Price , upcDiscount);

            if (product.Discount == 0)
            {
                _productPrint.PrintPriceInfo(product , finalPrice);
            }

            else
            {
                _productPrint.PrintPriceInfo(product , finalPrice);
                _productPrint.PrintDeductedAmount(discountAmount);
            }
        }
    }
    
    public double CalculateDiscountAfterCheckUpc(double upc, double upcToCheck)
    {
        if (upc == upcToCheck)
            return 7;
        return 0;
    }

    public void CalculateAndPrintPriceInfoAfterDiscount()
    {
        var productWithDiscount = _productRepo.GetAllProduct().FirstOrDefault(product => product.Discount == 15);
        var productWithoutDiscount = _productRepo.GetAllProduct().FirstOrDefault(product => product.Discount == 0);
        var products = new[] { productWithDiscount , productWithoutDiscount };
        
        foreach (var product in products)
        {
            var finalPrice = CalculateFinalPrice(product.Price, product.Tax , product.Discount);
            var discountAmount = CalculateDiscountAmount(product.Price , product.Discount);

            if (product.Discount == 0)
            {
                _productPrint.PrintPriceInfo(product , finalPrice);
            }

            else
            {
                _productPrint.PrintPriceInfo(product , finalPrice);
                _productPrint.PrintDeductedAmount(discountAmount);
            }
        }
    }
}