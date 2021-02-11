using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CsharpCoreRefactor
{
    public enum ItemTypeEnum
    {
        [Description("+5 Dexterity Vest")]
        DexterityVest = 1,
        [Description("Aged Brie")]
        AgedBrie = 2,
        [Description("Elixir of the Mongoose")]
        ElixirMongoose = 3,
        [Description("Sulfuras, Hand of Ragnaros")]
        Sulfuras = 4,
        [Description("Backstage passes to a TAFKAL80ETC concert")]
        BackstagePasses = 5,
        [Description("Conjured Mana Cake")]
        ConjuredManaCake = 6,
        [Description("")]
        NotDefine = 7
    }

}
