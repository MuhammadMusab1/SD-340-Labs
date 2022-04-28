using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal interface iMedia // interface
    {
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int Id { get; set; }
        //Title, Runtime, and the method Play. 
        public string Title { get; set; }
        public float Runtime { get; set; }
        public ICollection<CustomeriMedia> CustomerMedias { get; set; }
        void Play()
        {
            //no body for the method in interface
        }
        //interface cannot have a constructor
    }
}
