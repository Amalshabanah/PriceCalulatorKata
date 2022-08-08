namespace PriceCalKata.Services;
public interface IProductService
{ 
    public double CalculatePriceAfterTax(double price , double tax);

    public void PrintInfo(string? productName , double upc , double price);

    public void PrintTax(double price , double tax , double priceAfterTax);
    public double CalculateDiscountAmount(double price , double discount);
    public double CalculatePriceAfterDiscount(double price , double upcDiscount);

    public void PrintFinalPrice(double price , double tax , double discount , double upcDiscount);

    public double CalculateFinalPrice(double price , double tax , double discount , double upcDiscount);
    
    public int CalculateDiscountAfterCheckUpc(int upc , int upcToCheck);
}