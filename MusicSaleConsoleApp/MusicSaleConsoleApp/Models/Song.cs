using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class Song : iMedia //inherits from iMedia
    {
        public override void Play() //overriding the Play() method on the base class iMedia
        {
            Console.WriteLine($"Playing the song {Title} on your favourite music platform for {Runtime} minutes.");
        }
        public Song(Artist artist, string title, float runtime, int id) : base(artist, title, runtime, id) { } //inherits base's constructor
    }
}
