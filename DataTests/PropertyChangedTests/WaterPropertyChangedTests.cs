using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        // Test 1: Water should implement the INotifyPropertyChanged interface
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var w = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(w);
        }


        // Test 6: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Ice", () =>
            {
                w.Ice = false;
            });
        }

        // Test 7: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "SpecialInstructions", () =>
            {
                w.Ice = false;
            });
        }
        // Test 4: Changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Lemon", () =>
            {
                w.Lemon = true;
            });
        }

        // Test 5: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "SpecialInstructions", () =>
            {
                w.Lemon = true;
            });
        }


        // Test 6: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForSize()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Size", () =>
            {
                w.Size = Size.Medium;
            });
        }

        // Test 7: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForSize()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Size", () =>
            {
                w.Size = Size.Large;
            });
        }

        // Test 8: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForPrice()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Price", () =>
            {
                w.Size = Size.Medium;
            });
        }

        // Test 9: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForPrice()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Price", () =>
            {
                w.Size = Size.Large;
            });
        }

        // Test 10: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForCalories()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Calories", () =>
            {
                w.Size = Size.Medium;
            });
        }

        // Test 11: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForCalories()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Calories", () =>
            {
                w.Size = Size.Large;
            });
        }
    }
}
