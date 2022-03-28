using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Client
    {
        public int id { get; set; }

        [Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$",
            ErrorMessage = "Enter a valid phone number")]
        public string PhoneNumber { get; set; }
        // This is one method of manually creating validation
        // [Phone] attribute works as well for basic validation, NOT RECOMMENDED
    }
}
