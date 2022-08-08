namespace PriceCalKata.Repositories;

public class ProductRepository :  IProductRepository
{
    public double ReadTax()
    {
     return 20;
    }
    public double ReadDiscount()
    {
        return 15;
    }
    public double ReadUpcDiscount()
    {
        return 7;
    }
}