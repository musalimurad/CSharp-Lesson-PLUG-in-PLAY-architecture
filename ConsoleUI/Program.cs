using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductManager productManager = new ProductManager(new EfProductDal());
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
var result = productManager.GetProductDetails();

if (result.Success)
{
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName + " / " + product.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}


//foreach (var category in categoryManager.GetAll())
//{
//    Console.WriteLine(category.CategoryName);
//}




