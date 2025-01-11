using BooksShoppingCart.Models;

namespace BooksShoppingCart.Repository
{
    public class CategoryRepositry:Repository<Category>,ICategoryRepository

    {
        public ApplicationDbContext _db;
        public CategoryRepositry(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Category.Update(obj);
        }

    }
}
