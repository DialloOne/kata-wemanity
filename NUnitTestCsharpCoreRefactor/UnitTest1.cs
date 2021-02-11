using CsharpCoreRefactor;
using NUnit.Framework;
using System;

namespace NUnitTestCsharpCoreRefactor
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test, Order(1)]
        public void getting_enum_value_as_string()
        {
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", ItemTypeEnum.BackstagePasses.GetItemNameFromEnum());
        }

        [Test, Order(2)]
        public void getting_enum_value_from_string()
        {
            Assert.AreEqual(ItemTypeEnum.BackstagePasses, TypeEnumExtension.GetTypeFromItemName("Backstage passes to a TAFKAL80ETC concert"));
        }

        [Test, Order(3)]
        public void BackstagePasses_UpdateItemQuality()
        {
            //Arrange
            var item = new ExtendedItem()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 37,
                SellIn = 9,
                Type = TypeEnumExtension.GetTypeFromItemName("Backstage passes to a TAFKAL80ETC concert"),
                RunDate = DateTime.Now.AddDays(-1)
            };

            //Act
            item.UpdateItemQuality();

            //Assert
            Assert.AreEqual(item.Quality, 39);
            Assert.AreEqual(item.SellIn, 8);
        }

        [Test, Order(4)]
        public void AgedBrie_UpdateItemQuality()
        {
            //Arrange
            var item = new ExtendedItem()
            {
                Name = "Aged Brie",
                Quality = 42,
                SellIn = 7,
                Type = TypeEnumExtension.GetTypeFromItemName("Aged Brie"),
                RunDate = DateTime.Now.AddDays(-1)
            };

            //Act
            item.UpdateItemQuality();

            //Assert
            Assert.AreEqual(item.Quality, 43);
            Assert.AreEqual(item.SellIn, 6);
        }


        [Test, Order(5)]
        public void Sulfuras_UpdateItemQuality()
        {
            //Arrange
            var item = new ExtendedItem()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = 48,
                Type = TypeEnumExtension.GetTypeFromItemName("Sulfuras, Hand of Ragnaros"),
                RunDate = DateTime.Now.AddDays(-1)
            };

            //Act
            item.UpdateItemQuality();

            //Assert
            Assert.AreEqual(item.Quality, 48);
        }

        [Test, Order(6)]
        public void ConjuredManaCake_UpdateItemQuality()
        {
            //Arrange
            var item = new ExtendedItem()
            {
                Name = "Conjured Mana Cake",
                Quality = 42,
                SellIn = 7,
                Type = TypeEnumExtension.GetTypeFromItemName("Conjured Mana Cake"),
                RunDate = DateTime.Now.AddDays(-1)
            };

            //Act
            item.UpdateItemQuality();

            //Assert
            Assert.AreEqual(item.Quality, 40);
            Assert.AreEqual(item.SellIn, 6);
        }

        [Test, Order(7)]
        public void AnyOtherItem_UpdateItemQuality()
        {
            //Arrange
            var item = new ExtendedItem()
            {
                Name = "",
                Quality = 42,
                SellIn = 7,
                RunDate = DateTime.Now.AddDays(-1)
            };

            //Act
            item.UpdateItemQuality();

            //Assert
            Assert.AreEqual(item.Quality, 41);
            Assert.AreEqual(item.SellIn, 6);
        }

        /// <summary>
        /// Just one update per day
        /// </summary>
        [Test, Order(8)]
        public void RunDate_UpdateItemQuality()
        {
            //Arrange
            var item = new ExtendedItem()
            {
                Name = "",
                Quality = 42,
                SellIn = 7,
                RunDate = DateTime.Now
            };

            //Act
            item.UpdateItemQuality();

            //Assert
            Assert.AreEqual(item.Quality, 42);
            Assert.AreEqual(item.SellIn, 7);
        }

    }
}