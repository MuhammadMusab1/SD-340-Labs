using System.ComponentModel.DataAnnotations;

namespace DataAnnotationLab.Models
{
    public class Client
    {
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 3, ErrorMessage= "A minimum length of three characters and a max of 25.")]
        public string FirstName { get; set; }
        [StringLength(25, MinimumLength = 3, ErrorMessage = "A minimum length of three characters and a max of 25.")]
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage ="Not a phone number try again")]
        [Required]
        public string PhoneNumber { get; set; }

        public Client()
        {

        }
        public Client(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

    }
}

/*
An ID (int will be sufficient here)

A FirstName and LastName. The last name is required, and both have a minimum length of three characters and a max of 25.

PhoneNumber, a string which must represent a phone number and have an appropriate validation message. 
It is also required in order to register a Client. Search for a way to validate phone numbers in C#.
 */
