using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotations.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Column(TypeName = "varchar(150)")]
        [StringLength(25, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Column(TypeName = "varchar(150)")]
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

        [InverseProperty("CurrentClient")]
        public Room CurrentRoom { get; set; }
        public int CurrentRoomId { get; set; }

        [InverseProperty("PreviousClient")]
        public Room PreviousRoom { get; set; }
        public int PreviousRoomId { get; set; }
    }
}
