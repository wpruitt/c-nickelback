using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();
            allSongs.Add(("Nickelback", "How You Remind Me"));
            allSongs.Add(("Nickelback", "I'd Come for You"));
            allSongs.Add(("Nickelback", "Something in Your Mouth"));
            allSongs.Add(("Linkin Park", "Papercut"));
            allSongs.Add(("Limp Bizkit", "Rollin"));
            allSongs.Add(("Korn", "Freak on a Leash"));
            allSongs.Add(("System of a Down", "Ariels"));
            foreach ((string, string) song in allSongs)
            {
                if (!song.Item1.Contains("Nickelback"))
                {
                goodSongs.Add(song);
                }
            }
            foreach ((string, string) song in goodSongs)
            {
                Console.WriteLine(song);
            }

        }
    }
}
