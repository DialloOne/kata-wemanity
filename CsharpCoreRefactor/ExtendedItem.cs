using System;

namespace CsharpCoreRefactor
{
    public class ExtendedItem : Item
    {
        public ExtendedItem() { }

        public ItemTypeEnum Type { get; set; }

        public DateTime RunDate { get; set; }

        public bool IsAgingWell => this.Type == ItemTypeEnum.AgedBrie || this.Type == ItemTypeEnum.BackstagePasses;

        public void UpdateItemQuality()
        {
            try
            {
                //Check if items are updated today
                if (RunDate.Date >= DateTime.Now.Date)
                    return;

                //"Backstage passes", like aged brie, increases in Quality as its SellIn value approaches
                if (IsAgingWell)
                {
                    if (Type == ItemTypeEnum.BackstagePasses)
                    {
                        switch (SellIn)
                        {
                            case < 11 and > 5:
                                Quality = (Quality < 49) ? Quality + 2 : 50;
                                break;
                            case <= 5 and >= 0:
                                Quality = (Quality < 48) ? Quality + 3 : 50;
                                break;
                            case < 0:
                                Quality = 0;
                                break;
                            default:
                                return;
                        }

                    }
                    else
                    {
                        Quality = (Quality < 50) ? Quality + 1 : 50;
                    }

                }
                else if (Type == ItemTypeEnum.Sulfuras)
                {
                    //"Sulfuras", being a legendary item, never decreases in Quality
                    return;
                }
                else if (Type == ItemTypeEnum.ConjuredManaCake)
                {
                    //"Conjured" items degrade in Quality twice as fast as normal items
                    Quality = (Quality > 1) ? Quality - 2 : 0;
                }
                else
                {
                    //items degrade in Quality of normal items
                    Quality = (Quality > 0) ? Quality - 1 : 0;
                }

                //"Sulfuras", being a legendary item, never has to be sold
                SellIn = (Type != ItemTypeEnum.Sulfuras) ? SellIn - 1 : SellIn;

            }
            catch (Exception) {
               throw;
            }        
        }

    }
}
