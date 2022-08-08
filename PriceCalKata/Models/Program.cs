﻿namespace PriceCalKata.Models;
public class program
{
    public static void Main(string[] args)
    {
        var product = new Product("The Little Prince", 12345, 20.25);
        product.Tax = product.ReadTax();
        product.Discount = product.ReadDiscount();
        product.UpcDiscount = product.DiscountAfterCheckUpc(product.UpcWithDiscount, product.Upc);
        product.PrintInfo(product.ProductName , product.Upc , product.Price);
        product.PrintFinalPrice(product.Price , product.Tax , product.Discount ,  product.UpcDiscount);
    }
}