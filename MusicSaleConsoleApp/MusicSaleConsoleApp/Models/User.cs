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
        public ICollection<iMedia> Medias { get; set; }
        public string? Email { get; set; }
        public virtual void GenerateEmail()
        {
            Email = $"{Name}{Id}@gmail.com"; // e.g "Musab3@gmail.com"
        }
        public void Binge()
        {
            if(Medias.Any())
            {
                foreach(iMedia imedia in Medias)
                {
                    imedia.Play();
                }
            }
            else
            {
                Console.WriteLine("Media is empty");
            }
        }
        public User(string name, int id)
        {
            Name = name;
            Id = id;
            Medias = new HashSet<iMedia>();
        }
    }
}
