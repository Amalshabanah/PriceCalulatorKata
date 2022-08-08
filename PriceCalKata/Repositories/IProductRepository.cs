namespace PriceCalKata.Repositories;
public interface IProductRepository 
{ 
    public double ReadTax();
    public double ReadDiscount();
    public double ReadPackaging();
    public double ReadTransport();
   
}