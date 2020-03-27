using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        // Test 1: CornDodgers should implement the INotifyPropertyChanged interface
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }

        // Test 2: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Large;
            });
        }

        // Test 4: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForPrice()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = Size.Medium;
            });
        }

        // Test 5: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForPrice()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = Size.Large;
            });
        }

        // Test 6: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForCalories()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = Size.Medium;
            });
        }

        // Test 7: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForCalories()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = Size.Large;
            });
        }
    }
}
