using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineShopping.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required"), StringLength(maximumLength: 50, ErrorMessage = "Maximun length cannot exceed 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is required"), DataType(DataType.Currency)]
        public int Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}