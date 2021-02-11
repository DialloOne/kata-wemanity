using System;
using System.Collections.Generic;

namespace CsharpCoreRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = Tools.ItemsSeeder();

            var app = new GildedRose(Items);

            var results = app.UpdateQuality();

            Tools.Display(Items, results);

        }
    }
}
