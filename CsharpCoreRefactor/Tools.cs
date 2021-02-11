using System;
using System.Collections.Generic;

namespace CsharpCoreRefactor
{
    public static class Tools
    {
        public static IList<Item> ItemsSeeder()
        {
            IList<Item> Items = new List<Item>()
            {
                new Item () { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item () { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item () { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item () { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item () { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                new Item () { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item () { Name = "Red wine", SellIn = 10, Quality = 49 },
                new Item () { Name = "Camenbert", SellIn = 5,  Quality = 49 },
                new Item () { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
            };

            return Items;
        }

        public static void Display(IList<Item> Items, IList<ExtendedItem> ExtendedItems)
        {
            Console.WriteLine("name, sellIn, quality, sellIn (updated), quality (updated), Rundate");
            for (var j = 0; j < Items.Count; j++)
            {
                System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + ", " + ExtendedItems[j].SellIn + ", " + ExtendedItems[j].Quality + ", " + ExtendedItems[j].RunDate);
            }
        }
    }
}
