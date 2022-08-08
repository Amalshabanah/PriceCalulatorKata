namespace PriceCalKata.Services;
public interface IProductService
{ 
    public double CalculatePriceAfterTax(double price , double tax);

    public void PrintInfo(string? productName , double upc , double price);
    
    public double CalculateDiscountAmount(double price , double discount);
    
    public double CalculatePriceAfterDiscount(double price , double upcDiscount);

    public void PrintFinalPrice(double price , double tax , double discount , double upcDiscount , double packaging , double transport);

    public double CalculateFinalPrice(double price , double tax , double discount , double upcDiscount , double packaging , double transport);
    
    public int CalculateDiscountAfterCheckUpc(int upc , int upcToCheck);

    public double CalculateCostAmount(double price, double amount);
}