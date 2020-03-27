using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        // Test 1: TexasTripleBurger should implement the INotifyPropertyChanged interface
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasBurger);
        }

        // Test 2: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Pickle", () =>
            {
                texasBurger.Pickle = false;
            });
        }

        // Test 3: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Pickle = false;
            });
        }

        // Test 4: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Bun", () =>
            {
                texasBurger.Bun = false;
            });
        }

        // Test 5: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Bun = false;
            });
        }

        // Test 6: Changing the "Ketchup" property should invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Ketchup", () =>
            {
                texasBurger.Ketchup = false;
            });
        }

        // Test 7: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Ketchup = false;
            });
        }

        // Test 8: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Mustard", () =>
            {
                texasBurger.Mustard = false;
            });
        }

        // Test 9: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Mustard = false;
            });
        }

        // Test 10: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Cheese", () =>
            {
                texasBurger.Cheese = false;
            });
        }

        // Test 11: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Cheese = false;
            });
        }

        // Test 12: Changing the "Tomato" property should invoke PropertyChanged for "Tomato"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Tomato", () =>
            {
                texasBurger.Tomato = false;
            });
        }

        // Test 13: Changing the "Tomato" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Tomato = false;
            });
        }

        // Test 14: Changing the "Lettuce" property should invoke PropertyChanged for "Lettuce"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Lettuce", () =>
            {
                texasBurger.Lettuce = false;
            });
        }

        // Test 15: Changing the "Lettuce" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Lettuce = false;
            });
        }

        // Test 16: Changing the "Mayo" property should invoke PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Mayo", () =>
            {
                texasBurger.Mayo = false;
            });
        }

        // Test 17: Changing the "Mayo" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Mayo = false;
            });
        }

        // Test 18: Changing the "Bacon" property should invoke PropertyChanged for "Bacon"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Bacon", () =>
            {
                texasBurger.Bacon = false;
            });
        }

        // Test 19: Changing the "Bacon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Bacon = false;
            });
        }

        // Test 20: Changing the "Egg" property should invoke PropertyChanged for "Egg"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Egg", () =>
            {
                texasBurger.Egg = false;
            });
        }

        // Test 21: Changing the "Egg" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Egg = false;
            });
        }
    }
}
