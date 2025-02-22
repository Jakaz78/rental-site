using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalSite.Components.Classes
{
    public class Person
    {



        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestID { get; set; } 


        [Required(ErrorMessage = "Imię jest wymagane")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Imię musi zawierać od 2 do 20 liter")]
        [RegularExpression("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]*$", ErrorMessage = "Imię może zawierać tylko litery")]
        public string Name { get; set; } = "";



        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Nazwisko musi zawierać od 2 do 20 liter")]
        [RegularExpression("^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]*$", ErrorMessage = "Nazwisko może zawierać tylko litery")]
        public string Lastname { get; set; } = "";



        [Required(ErrorMessage = "Email jest wymagany")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Email musi zawierać od 2 do 100 znaków")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Nieprawidłowy format email")]
        public string Email { get; set; } = "";



        public string PhoneNumberPrefix { get; set; } = "+48";



        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Numer telefonu musi zawierać dokładnie 9 cyfr")]
        public string PhoneNumber { get; set; } = "";













    }



    public enum EnumSex { men = 1, woman = 2, blad = 0 }

}
