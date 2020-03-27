using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        // Test 1: TexasTea should implement the INotifyPropertyChanged interface
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        // Test 2: Changing the "Sweet" property should invoke PropertyChanged for "Sweet"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }

        // Test 3: Changing the "Sweet" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }

        // Test 4: Changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;
            });
        }

        // Test 5: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }


        // Test 6: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        // Test 7: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Large;
            });
        }

        // Test 8: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        // Test 9: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large;
            });
        }

        // Test 10: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        // Test 11: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Large;
            });
        }
    }
}
