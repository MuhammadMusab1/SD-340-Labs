using System.ComponentModel.DataAnnotations;

namespace DataAnnotationLab.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public Section Section { get; set; }

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
*/
