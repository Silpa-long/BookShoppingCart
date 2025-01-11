using BooksShoppingCart.Models;

namespace BooksShoppingCart.Repository
{
    public interface IProductImageRepository:IRepository<ProductImage>

    {
        void Update(ProductImage obj);
    }
}
