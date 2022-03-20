using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class Customer : User
    {
        public ICollection<CustomerSong> CustomerSongs { get; set; }
        public Customer()
        {
            CustomerSongs = new HashSet<CustomerSong>();
        }
    }
}
