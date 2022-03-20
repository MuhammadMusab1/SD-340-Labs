using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSaleConsoleApp.Models
{
    internal class Video : iMedia
    {
        public Video(Artist artist, string title, float runtime, int id) : base(artist, title, runtime, id) { }

        public override void Play() //overriding the Play() method on the base class iMedia
        {
            Console.WriteLine($"Watching {Title} on your inadequate viewing screen for {Runtime}.");
        }
    }
}
