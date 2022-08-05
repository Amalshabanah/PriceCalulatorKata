namespace PriceCalKata.Services;
public interface IProductService
{
    public double CalculatePriceAfterTax(double price, double tax) ;
    
    public void PrintInfo(string? productName, double upc, double price);
    
    public double CalcualteTaxAmount(double price , double tax);

    public double CalculateDiscountAmount(double price , double discount , double upcDiscount);

    public void PrintFinalPrice(double price , double tax , double discount , double upcDiscount);

    public double CalculateFinalPrice(double price, double tax , double discount , double upcDiscount);
    
    public int DiscountAfterCheckUpc(int upc, int upcToCheck);
}