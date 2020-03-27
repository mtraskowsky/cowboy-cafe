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
    }
}
