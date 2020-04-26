using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        // Test 1: Entrees list should only have seven items
        [Fact]
        public void EntreesShouldHaveSevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }

        //Test 2: Sides list should only have four items
        [Fact]
        public void SidesShouldHaveFourItems()
        {
            Assert.Equal(4, Menu.Sides().Count());
        }

        // Test 3: Drinks list should only have four items
        [Fact]
        public void DrinksShouldHaveFourItems()
        {
            Assert.Equal(4, Menu.Drinks().Count());
        }

        // Test 4: Entrees should only contain entrees
        [Fact]
        public void EntreeSidesShouldOnlyContainExpectedEntrees()
        {
            Assert.Collection<IOrderItem>(
                Menu.Entrees(),
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); }
            );
        }

        // Test 5: Sides should only contain sides
        [Fact]
        public void MenuSidesShouldOnlyContainExpectedSides()
        {
            Assert.Collection<IOrderItem>(
                Menu.Sides(),
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
            );
        }

        // Test 6: Drinks should only contain drinks
        [Fact]
        public void MenuDrinksShouldOnlyContainExpectedDrinks()
        {
            Assert.Collection<IOrderItem>(
                Menu.Drinks(),
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
            );
        }

        // Test 7: CompleteMenu should contain all entrees, sides, and drinks
        [Fact]
        public void CompleteMenuShouldOnlyContainExpectedItems()
        {
            Assert.Collection(
                Menu.All,
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },

                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },

                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
            );
        }
    }
}
