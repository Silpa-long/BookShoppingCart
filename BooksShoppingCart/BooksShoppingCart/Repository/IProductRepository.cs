using BooksShoppingCart.Models;

namespace BooksShoppingCart.Repository
{
    public interface IProductRepository:IRepository<Product>
    {
        void Update(Product obj);
    }
    
    
}
