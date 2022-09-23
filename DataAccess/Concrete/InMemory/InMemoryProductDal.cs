using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        readonly List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Iphone 13 Pro", UnitPrice=2000, UnitsInStock=10},
                new Product{ProductId=2, CategoryId=1, ProductName="Iphone 13 Pro Max", UnitPrice=2500, UnitsInStock=6},
                new Product{ProductId=3, CategoryId=1, ProductName="Iphone 13 mini", UnitPrice=1700, UnitsInStock=20},
                new Product{ProductId=4, CategoryId=1, ProductName="Iphone 12 mini", UnitPrice=1400, UnitsInStock=8},
                new Product{ProductId=5, CategoryId=1, ProductName="Iphone 12 Pro", UnitPrice=1650, UnitsInStock=13},
                new Product{ProductId=6, CategoryId=2, ProductName="HP pavilion 15", UnitPrice=1950, UnitsInStock=4},
                new Product{ProductId=7, CategoryId=2, ProductName="HP omen 17", UnitPrice=4700, UnitsInStock=2},
                new Product{ProductId=8, CategoryId=2, ProductName="Apple mac m1 Pro", UnitPrice=6670, UnitsInStock=1},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product? productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return  _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product? productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
