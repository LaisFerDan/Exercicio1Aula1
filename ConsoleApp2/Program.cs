using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var piano = new Piano()
            {
                Maker = "Yamaha",
                Categorie = "Grand",
                NumKeys = 88,
                NumStrings = 230,
                Price = 7000
            };

            var guitar = new Guitar()
            {
                Maker = "Fender",
                NumFret = 32,
                NumStrings = 6,
                Price = 4000
            };

            Inventory.Include(piano);
            Inventory.Include(guitar);

            Inventory.Save();

            Console.WriteLine(Inventory.Count);
        }
    }
}
