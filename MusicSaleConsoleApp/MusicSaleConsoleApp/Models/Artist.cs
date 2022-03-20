using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class Artist : User
    {
        public ICollection<Song> Songs { get; set; }
        public Artist()
        {
            Songs = new HashSet<Song>();
        }
        public override void GenerateEmail()
        {
            Email = $"A{Name}{Id}@gmail.com"; //override the method to have an A at the beginning e.g "AMusab3@gmail.com"
        }
    }
    //Have the Artist override the GenerateEmail method to prepend 
    //an A to the email generated in the base class.
}
