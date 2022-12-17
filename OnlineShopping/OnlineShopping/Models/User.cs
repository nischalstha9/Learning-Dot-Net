
using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:100, ErrorMessage="Email cant exceed 100 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be atleast 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
