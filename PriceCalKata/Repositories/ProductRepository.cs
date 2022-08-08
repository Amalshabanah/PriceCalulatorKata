namespace PriceCalKata.Repositories;
public class ProductRepository :  IProductRepository
{
    public double ReadTax()
    {
     return 21;
    }
    public double ReadDiscount()
    {
        return 15;
    }

    public double ReadPackaging()
    {
        return 1;
    }

    public double ReadTransport()
    {
        return 2.2;
    }

    public double ReadUpcDiscount()
    {
        return 7;
    }
}