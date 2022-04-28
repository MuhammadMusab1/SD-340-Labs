using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class Song : iMedia //inherits from iMedia
    {
        //Implement those properties in the implement class
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int Id { get; set; }
        //Title, Runtime, and the method Play. 
        public string Title { get; set; }
        public float Runtime { get; set; }
        public ICollection<CustomeriMedia> CustomerMedias { get; set; }
        public void Play() //overriding the Play() method on the base class iMedia
        {
            Console.WriteLine($"Playing the song {Title} on your favourite music platform for {Runtime} minutes.");
        }
        public Song(Artist artist, string title, float runtime, int id)
        {
            Id = id;
            ArtistId = artist.Id;
            Artist = artist;
            Title = title;
            Runtime = runtime;
            CustomerMedias = new HashSet<CustomeriMedia>();
        }
    }
}
