using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RentalSite.Components.Classes
{
    public class Person
    {

        
        // public int GuestID { get; set; }
        //public string Name { get; set; }
        // public string Lastname { get; set; }


        [Key] 
        public int GuestID { get; set; }




        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "The name must be between 2 and 10 characters")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The name can only contain letters")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "The lastname must be between 2 and 10 characters")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The lastname can only contain letters")]
        public string Lastname { get; set; } = "";


        //private EnumSex sex;
        //public DateTime reservationDateTime;




        







        public Person()
        {
            
        }
        public Person(string name, string surname, EnumSex sex) : base()
        {
            Name = name;
            Lastname = surname;
            //this.sex = sex;
        }
        public override string ToString()
        {
            //if (sex == EnumSex.men)
            //{
            //    return $"{Name} {Lastname}, Mężczyzna";
            //}


            return $"{Name} {Lastname}, Kobieta";
        }
    }

    //public class Dom
    //{
    //    public string homeName;

    //    public ObservableCollection<Person> people = new();

    //    public void AddPerson(Person t)
    //    {
    //        people.Add(t);
    //    }

    //    public Dom()
    //    {
    //        homeName = "";
    //        people = new ObservableCollection<Person>();
    //    }

    //    public Dom(string homeName) : base()
    //    {
    //        this.homeName = homeName;
    //    }

    //    public string DisplayList()
    //    {
    //        StringBuilder stringBuilder = new();
    //        foreach (var t in people)
    //        {
    //            stringBuilder.AppendLine(t.ToString());
    //        }
    //        return stringBuilder.ToString();
    //    }
    //}

    public enum EnumSex { men = 1, woman = 2, blad = 0 }

}
