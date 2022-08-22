using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepo;
    private readonly IProductPrintService _productPrint;

    public ProductService(IProductRepository productRepo, IProductPrintService productPrint)
    {
        _productRepo = productRepo;
        _productPrint = productPrint;
    }

    public double CalculateFinalPrice(double price, double tax, double discount)
    {
        return price + CalculateTaxAmount(price, tax) - CalculateDiscountAmount(price, discount);
    }

    public double CalculateFinalPriceSelectiveDiscount(double price, double tax, double discount, double upcDiscount)
    {
        return Math.Round(price +
                     CalculateTaxAmount(price, tax) -
                     CalculateDiscountAmount(price, discount) -
                     CalculateDiscountAmount(price , upcDiscount), 2);
    }

    public double CalculateDiscountAmount(double price, double discount)
    {
        return Math.Round(price * (discount / 100), 2);
    }

    public double CalculateTaxAmount(double price, double tax)
    {
        return Math.Round(price * (tax / 100), 2);
    }

    public double CalculatePriceAfterTax(double price, double tax)
    {
        return Math.Round(price + CalculateTaxAmount(price, tax), 2);
    }

    public void CalculateAndPrintPriceInfoAfterTax()
    {
        Product product = _productRepo.GetFirstProductData();
        var priceAfterTax = CalculatePriceAfterTax(product.Price, product.Tax);

        _productPrint.PrintTaxInfo(product, priceAfterTax);
    }

    public double CalculateFinalPricePrecedenceDiscount(double price, double tax, double discount, double upcDiscount)
    {
        double priceAfterUpcDiscount = price - CalculateDiscountAmount(price, upcDiscount);
            double taxAmount = CalculateTaxAmount(priceAfterUpcDiscount, tax);
            double discountAmount = CalculateDiscountAmount(priceAfterUpcDiscount, discount);
            return Math.Round((priceAfterUpcDiscount + taxAmount - discountAmount), 2);
        }
    
    public void CalculateAndPrintPriceInfoAfterSelectiveDiscount()
    {
        var productWithUpcDiscount = _productRepo.GetAllProduct()
            .FirstOrDefault(product => product.Upc == product.UpcWithDiscount);
        var productWithoutUpcDiscount = _productRepo.GetAllProduct()
        .FirstOrDefault(product => product.Upc != product.UpcWithDiscount &&
             product.Discount != 0);
        var products = new[] { productWithUpcDiscount, productWithoutUpcDiscount };

        foreach (var product in products)
        {
            var upcDiscount = CalculateDiscountAfterCheckUpc(product.Upc, product.UpcWithDiscount);
            var finalPrice = CalculateFinalPriceSelectiveDiscount(product.Price, product.Tax, product.Discount, upcDiscount);
            var discountAmount = CalculateDiscountAmount(product.Price, product.Discount) +
                                 CalculateDiscountAmount(product.Price, upcDiscount);

            if (product.Discount == 0)
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
            }

            else
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
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
        var products = new[] { productWithDiscount, productWithoutDiscount };

        foreach (var product in products)
        {
            var finalPrice = CalculateFinalPrice(product.Price, product.Tax, product.Discount);
            var discountAmount = CalculateDiscountAmount(product.Price, product.Discount);

            if (product.Discount == 0)
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
            }

            else
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
                _productPrint.PrintDeductedAmount(discountAmount);
            }
        }
    }

    public void CalculateAndPrintPriceAfterPrecedenceDiscount()
    {
        var product = _productRepo.GetAllProduct().FirstOrDefault(product => product.Upc == product.UpcWithDiscount); 
        var upcDiscount = CalculateDiscountAfterCheckUpc(product.Upc, product.UpcWithDiscount);
        var finalPrice = CalculateFinalPricePrecedenceDiscount(product.Price, product.Tax, product.Discount , upcDiscount);
        var priceAfterUpcDiscount = product.Price - CalculateDiscountAmount(product.Price, upcDiscount);
        var discountAmount = CalculateDiscountAmount(priceAfterUpcDiscount, product.Discount) +
                                   CalculateDiscountAmount(product.Price, upcDiscount);
            
            if (product.Discount == 0)
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
            }

            else
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
                _productPrint.PrintDeductedAmount(discountAmount);
            }
    }

    public void CalculateAndPrintPriceWithExpenses()
    {
        var productWithExpenses = _productRepo
                                  .GetAllProduct()
                                  .FirstOrDefault(product => product.Upc == product.UpcWithDiscount && 
                                                             product.PackagingCost != null &&
                                                             product.TransportCost != null);
       var productWithoutExpenses = _productRepo
                                      .GetAllProduct()
                                      .FirstOrDefault(product => product.Discount == 0 &&
                                                                 product.TransportCost == null &&
                                                                 product.TransportCost == null);
        var products = new[] { productWithExpenses, productWithoutExpenses };
        foreach (var product in products)
        {
            var upcDiscount = CalculateDiscountAfterCheckUpc(product.Upc, product.UpcWithDiscount);
            var finalPrice =
                CalculateFinalPriceWithExpenses(product.Price, product.Tax, product.Discount, upcDiscount, product.PackagingCost ,product.TransportCost);
            var priceAfterUpcDiscount = product.Price - CalculateDiscountAmount(product.Price, upcDiscount);
            var discountAmount = CalculateDiscountAmount(priceAfterUpcDiscount, product.Discount) +
                                 CalculateDiscountAmount(product.Price, upcDiscount);

            if (product.Discount == 0)
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
            }

            else
            {
                _productPrint.PrintPriceInfo(product, finalPrice);
                _productPrint.PrintDeductedAmount(discountAmount);
            }
        }
    }

    public double CalculateFinalPriceWithExpenses(double price, double tax, double discount, double upcDiscount, string packaging,
        string transport)
    {
        double taxAmount = CalculateTaxAmount(price, tax);
        double discountAmount = CalculateDiscountAmount(price, discount) + CalculateDiscountAmount(price , upcDiscount);
        double expensesCost = CalculatePackagingAndTransportCost(packaging, transport, price);

        return Math.Round((price + taxAmount - discountAmount + expensesCost), 2);
    }

    public double CalculateCostAmount(double price, double amount)
    {
        return Math.Round(price * (amount / 100), 2);
    }
    
    public double RemoveDollar(String amount)
    {
        string newAmount;

        return Convert.ToDouble(newAmount);
    }
    
    public double RemovePercentage(String amount)
    {
        string newAmount;
        newAmount = amount.Remove(amount.Length - 1, 1);
        
        return Convert.ToDouble(newAmount);
    }

    public double CalculatePackagingAndTransportCost(string packaging, string transport , double price)
    {
        double packagingCost = 0;
        double transportCost = 0;
        if (packaging == null)
            packagingCost = 0;
        else if (transport == null)
            packagingCost = 0;
        else
        {
            if (packaging[0] == '$' || transport[0] == '$')
            {
                if (packaging[0] == '$')
                {
                    packagingCost = RemoveDollar(packaging);
                }

                if (transport[0] == '$')
                {
                    transportCost = RemoveDollar(transport);
                }
            }
            
            if (packaging[0] != '$')
                {
                    packagingCost = CalculateCostAmount(price, RemovePercentage(packaging));

                }
            if (transport[0] != '$')
                {
                    transportCost = CalculateCostAmount(price, RemovePercentage(transport));
                }
            }
        
        return Math.Round((packagingCost + transportCost), 2);
    }
}