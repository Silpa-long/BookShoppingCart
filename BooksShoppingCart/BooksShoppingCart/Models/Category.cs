using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BooksShoppingCart.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [MaxLength(30)]
        [Required]
        [DisplayName("Category name")]
        public string CategoryName { get; set; } = string.Empty;
    }
}
