using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class CustomerSong
    {
        public int Id { get; set; }
        public int SongId { get; set;}
        public int CustomerId { get; set; }
        public Song Song { get; set; }
        public Customer Customer { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
