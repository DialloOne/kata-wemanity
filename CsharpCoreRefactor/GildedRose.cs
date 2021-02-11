using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCoreRefactor
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public IList<ExtendedItem> UpdateQuality()
        {
            try
            {
                var results = Items.Select(i =>
                    new ExtendedItem() 
                    { 
                        Name = i.Name,
                        Quality = i.Quality,
                        SellIn = i.SellIn,
                        Type = TypeEnumExtension.GetTypeFromItemName(i.Name),
                        RunDate = DateTime.Now.AddDays(-1)
                    }).ToList();

                foreach (var extItem in results)
                {
                    extItem.UpdateItemQuality();
                }

                return results;
            }
            catch (Exception) {
                throw;
            }        
        }
    }
}
