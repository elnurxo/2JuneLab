
using ClassLibrary.MyClasses;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album1 = new Album()
            {
                Name = "After Hours",
                Genre = "Pop",
                Artist = "The Weeknd"
            };

            Track track1 = new Track()
            {
                Name = "Blinding Lights",
                StreamNumber = 1000
            };
            Track track2 = new Track()
            {
                Name = "In Your Eyes",
                StreamNumber = 6000000
            };

            album1.AddTrack(track1);
            album1.AddTrack(track2);

            foreach (var item in album1.FilterByStream(album1))
            {
                Console.WriteLine($"{item.Name} - {item.StreamNumber}");
            }
        }
    }
}
