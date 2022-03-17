using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationLab.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(25)")]
        [StringLength(25, MinimumLength = 3, ErrorMessage= "A minimum length of three characters and a max of 25.")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(25)")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "A minimum length of three characters and a max of 25.")]
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage ="Not a phone number try again")]
        [Required]
        public string PhoneNumber { get; set; }
        public Credit Credit { get; set; }
        public int? CurrentRoomId { get; set; }
        [InverseProperty("CurrentClient")]
        public Room? CurrentRoom { get; set; }
        public int? PreviousRoomId { get; set; }
        [InverseProperty("PreviousClient")]
        public Room? PreviousRoom { get; set; }

        public Client()
        {

        }
        public Client(string firstName, string lastName, string phoneNumber, Credit credit)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Credit = credit;
        }
    }
    [Owned]
    public class Credit
    {
        public bool IsValid { get; set; }
        [StringLength(20)] //max of 20 characters
        public string HolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}

/*
An ID (int will be sufficient here)

A FirstName and LastName. The last name is required, and both have a minimum length of three characters and a max of 25.

PhoneNumber, a string which must represent a phone number and have an appropriate validation message. 
It is also required in order to register a Client. Search for a way to validate phone numbers in C#.

Lab 2 Requirments:

Since our hotel is very outdated, it utilizes varchar for the first and last names 
of Customers rather than the default nvarchar.

A Complex Type called Credit associated with each Customer. 
Credit tracks IsValid (a boolean), HolderName(a string, with a max length of 20 characters), 
and ExpiryDate.

What type of database relationship does a complex type resemble?

Migrate these changes into the database.

We need a way to book rooms. To implement this, we will need to use an InverseProperty annotation.

Our rooms need to track a current and previous booking, 
as does the customer. 

Each Customer will need a 
PreviousRoom and PreviousRoomID, and a CurrentRoom and CurrentRoomID. 
        public int? CurrentRoomId { get; set; }
        public Room? CurrentRoom { get; set; }
        public int? PreviousRoomId { get; set; } 
        public Room? PreviousRoom { get; set; }


Similarly, Room will require 
CurrentCustomer, CurrentCustomerID, PreviousCustomer, PreviousCustomerID.


Try migrating in these changes. Do you encounter an error?

Use the InverseProperty annotation to inform EF6 how Room and Customer are related between these properties.


 */
