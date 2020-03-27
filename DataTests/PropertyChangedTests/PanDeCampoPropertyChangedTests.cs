using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        // Test 1: PanDeCampo should implement the INotifyPropertyChanged interface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }

        // Test 2: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Large;
            });
        }

        // Test 4: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForPrice()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Medium;
            });
        }

        // Test 5: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForPrice()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Large;
            });
        }

        // Test 6: Changing the "Size" property from default (Small) to Medium should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToMediumShouldInvokePropertyChangedForCalories()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Medium;
            });
        }

        // Test 7: Changing the "Size" property from default (Small) to Large should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeToLargeShouldInvokePropertyChangedForCalories()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Large;
            });
        }
    }
}
