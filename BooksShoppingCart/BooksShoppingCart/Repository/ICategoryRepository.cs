using BooksShoppingCart.Models;

namespace BooksShoppingCart.Repository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category obj);
    }
}
