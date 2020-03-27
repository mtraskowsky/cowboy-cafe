using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailburgerPropertyChangedTests
    {
        // Test 1: TrailBurger should implement the INotifyPropertyChanged interface
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var trailburger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trailburger);
        }

        // Test 2: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "Pickle", () =>
            {
                trailburger.Pickle = false;
            });
        }

        // Test 3: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "SpecialInstructions", () =>
            {
                trailburger.Pickle = false;
            });
        }

        // Test 4: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "Bun", () =>
            {
                trailburger.Bun = false;
            });
        }

        // Test 5: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "SpecialInstructions", () =>
            {
                trailburger.Bun = false;
            });
        }

        // Test 6: Changing the "Ketchup" property should invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "Ketchup", () =>
            {
                trailburger.Ketchup = false;
            });
        }

        // Test 7: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "SpecialInstructions", () =>
            {
                trailburger.Ketchup = false;
            });
        }

        // Test 8: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "Mustard", () =>
            {
                trailburger.Mustard = false;
            });
        }

        // Test 9: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "SpecialInstructions", () =>
            {
                trailburger.Mustard = false;
            });
        }

        // Test 10: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "Cheese", () =>
            {
                trailburger.Cheese = false;
            });
        }

        // Test 11: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailburger = new TrailBurger();
            Assert.PropertyChanged(trailburger, "SpecialInstructions", () =>
            {
                trailburger.Cheese = false;
            });
        }
    }
}
