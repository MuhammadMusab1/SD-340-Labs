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
    }
}
