using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Animals;
using Xunit;

namespace Zoo.Test
{
    public class ZooTest
    {
        [Fact]
        public static void FennecFox_Is_Cute()
        {
            FennecFox fox = new FennecFox();
            Assert.True(fox.IsCute);
        }

        [Fact]
        public static void BaldEagle_reppin_Murrica()
        {
            BaldEagle baldy = new BaldEagle();
            baldy.Name = "Baldy";
            Assert.Equal("Murica!", baldy.Climate());
            Assert.Equal("Baldy", baldy.Name);
            Assert.False(baldy.ColdBlooded);
            Assert.True(baldy.LayEggs);
        }
        [Fact]
        public static void Platypus_name_is_Perry()
        {
            DuckBilledPlatypus perry = new DuckBilledPlatypus();
            Assert.Equal("Perry",perry.Name);
            Assert.False(perry.IsCute);
        }
        [Fact]
        public static void SeaTurtle_isnt_venomous()
        {
            SeaTurtle squirt = new SeaTurtle();
            Assert.Equal("Squirt", squirt.Name);
            Assert.False(squirt.Venomous);
        }
        [Fact]
        
        public static void Check_Origin()
        {
            BaldEagle baldy = new BaldEagle();
            SeaTurtle squirt = new SeaTurtle();
            Assert.Equal("I'm an animal", baldy.Origin());
            Assert.Equal("I'm a cartoon", squirt.Origin());
        }
    }
}
