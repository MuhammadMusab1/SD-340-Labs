using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    //Create an abstract class, User(int Id, string Name, List<Song> Collection, string email). 
    //Create for User the method GenerateEmail, which appends their ID to their Name to generate an email for them.
    internal abstract class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
        public string Email { get; set; }
        public virtual void GenerateEmail()
        {
            Email = $"{Name}{Id}@gmail.com"; // e.g "Musab3@gmail.com"
        }
    }
}
