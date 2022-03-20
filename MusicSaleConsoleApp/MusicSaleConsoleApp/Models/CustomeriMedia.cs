using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class CustomeriMedia
    {
        public int Id { get; set; }
        public int MediaId { get; set;}
        public int CustomerId { get; set; }
        public iMedia Media { get; set; }
        public Customer Customer { get; set; }
        public DateTime PurchasedDate { get; set; }

        public CustomeriMedia(Customer customer, iMedia media)
        {
            Media = media;
            MediaId = media.Id;
            Customer = customer;
            CustomerId = customer.Id;
            PurchasedDate = DateTime.Now;

        }
    }
}
