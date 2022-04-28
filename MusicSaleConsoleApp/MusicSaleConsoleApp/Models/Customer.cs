using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class Customer : User
    {
        public ICollection<CustomeriMedia> CustomerMedias { get; set; }
        public Customer(string name, int id) : base(name, id)
        {
            CustomerMedias = new HashSet<CustomeriMedia>();
        }
    }
}
