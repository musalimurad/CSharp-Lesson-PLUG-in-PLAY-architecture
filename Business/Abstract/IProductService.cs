using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
       public IDataResult<List<Product>> GetAllProducts();
       public IDataResult<List<Product>> GetAllByCategoryId(int id);
       public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
       public IDataResult<Product> GetById(int id);
       public IResult Add(Product product);
       public IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
