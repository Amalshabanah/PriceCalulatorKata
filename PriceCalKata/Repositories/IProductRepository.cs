using PriceCalKata.Services;
namespace PriceCalKata.Repositories;
public interface IProductRepository : IProductService
{
    public void ReadProductData();
}