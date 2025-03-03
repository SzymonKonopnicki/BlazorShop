using BlazorShop.Application.Interfaces;

namespace BlazorShop.Application.Services;

public class ProductService : IProductService
{
    public  MyProperty { get; set; }
    public ICollection<IProductService> Products()
    {
        throw new NotImplementedException();
    }
}
