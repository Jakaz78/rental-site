using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalSite.Components.Classes
{
    public class Reservation
    {
        
       

        [Key]
    public int ReservationID { get; set; }

        [ForeignKey("Guests")]
        public int GuestID { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The name must be between 2 and 50 characters")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The name can only contain letters")]
        

        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The lastname must be between 2 and 50 characters")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The lastname can only contain letters")]
        public string Lastname { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The email must be between 1 and 100 characters")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email pattern")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumberPrefix { get; set; } = "+48";

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "The phone number must be exactly 9 digits")]
        public string PhoneNumber { get; set; }

        public DateTime ReservationDate { get; set; } = DateTime.Now;
        public bool Paid { get; set; } = false;


        public DateTime ReservationFrom { get; set; } 

        public DateTime ReservationTo { get; set; } 



    }
}
