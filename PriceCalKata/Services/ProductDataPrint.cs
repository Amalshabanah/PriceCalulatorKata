using PriceCalKata.Models;
using PriceCalKata.Repositories;

namespace PriceCalKata.Services;
public class ProductDataPrint : IProductDataPrint
{
    private IProductRepository productRepo = new ProductRepository();

    public Product GetProductData()
    {
        return productRepo.GetFirstProductData();
    }
}