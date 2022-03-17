using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationLab.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public Section Section { get; set; }
        public int? CurrentClientId { get; set; }
        //[InverseProperty("CurrentRoom")]
        public Client? CurrentClient { get; set; }
        public int? PreviousClientId { get; set; }
        //[InverseProperty("PreviousRoom")]
        public Client? PreviousClient { get; set; }


        public Room()
        {

        }
        public Room(int capacity, Section section)
        {
            Section = section;
            Capacity = capacity;
        }

    }
    public enum Section
    {
        First,
        Second,
        Third,
    }
}

/*
A Room:

Must have a RoomNumber, which serves as its Primary Key. 

Capacity

Section, an Enum (First, Second, Third) 

lab2 
        public int CurrentClientId { get; set; }
        public Client CurrentClient { get; set; }
        public int PreviousClientId { get; set; } 
        public Client PreviousClient { get; set; }
*/
