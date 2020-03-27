using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        // Test 1: JerkedSoda should implement the INotifyPropertyChanged interface
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        // Test 2: Changing the "Flavor" property from default (CreamSoda) to OrangeSoda should invoke PropertyChanged for "Flavor"
        [Fact]
        public void ChangingFlavorToCreamSodaShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            });
        }

        // Test 3: Changing the "Flavor" property from default (CreamSoda) to Sarsparilla should invoke PropertyChanged for "Flavor"
        [Fact]
        public void ChangingFlavorToSarsparillaShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            });
        }

        // Test 4: Changing the "Flavor" property from default (CreamSoda) to BirchBeer should invoke PropertyChanged for "Flavor"
        [Fact]
        public void ChangingFlavorToBirchBeerShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            });
        }

        // Test 5: Changing the "Flavor" property from default (CreamSoda) to RootBeer should invoke PropertyChanged for "Flavor"
        [Fact]
        public void ChangingFlavorToRootBeerShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.RootBeer;
            });
        }

        // Test 6: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }

        // Test 7: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }

        // Test 8: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Medium;
            });
        }

        // Test 9: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large;
            });
        }

        // Test 10: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium;
            });
        }

        // Test 11: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Large;
            });
        }

        // Test 12: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Medium;
            });
        }

        // Test 13: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Large;
            });
        }
    }
}
