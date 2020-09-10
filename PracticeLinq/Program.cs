using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<string>() { "subaru", "corrola", "ferarri", "civic", "tacoma", "mini van" };
            var carsWithR = cars.Where(c => c.Contains('r')).OrderByDescending(c => c[0]);
            foreach(string car in carsWithR)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("...........................................................................");
            Console.WriteLine();

            var videoGames = new List<string>() { "mario kart", "super smash", "donkey kong", "pac man", "zelda" };
            // Lambda syntax
            var orderedVideoGames = videoGames.OrderBy(v => v.Length);
            foreach(string game in orderedVideoGames)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("...........................................................................");
            Console.WriteLine();
            // Method syntax
            var secOrderedVG = from vg in videoGames
                               orderby vg.Length ascending
                               select vg;
            foreach(string vidGame in secOrderedVG)
            {
                Console.WriteLine(vidGame);
            }



        }
    }
}
