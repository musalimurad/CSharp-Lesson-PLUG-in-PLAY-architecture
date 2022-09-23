using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductManager productManager = new ProductManager(new EfProductDal());
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

foreach (var product in productManager.GetProductDetails())
{
    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
}

//foreach (var category in categoryManager.GetAll())
//{ 
//    Console.WriteLine(category.CategoryName);
//}




