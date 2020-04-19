using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> entreeItems = new List<IOrderItem>();
        private static List<IOrderItem> drinkItems = new List<IOrderItem>();
        private static List<IOrderItem> sideItems = new List<IOrderItem>();
        private static List<IOrderItem> allItems = new List<IOrderItem>();



        public static IEnumerable<IOrderItem> Entrees()
        {
            entreeItems.Add(new CowpokeChili());
            entreeItems.Add(new AngryChicken());
            entreeItems.Add(new TrailBurger());
            entreeItems.Add(new DakotaDoubleBurger());
            entreeItems.Add(new TexasTripleBurger());
            entreeItems.Add(new PecosPulledPork());
            entreeItems.Add(new RustlersRibs());

            allItems.Add(new CowpokeChili());
            allItems.Add(new AngryChicken());
            allItems.Add(new TrailBurger());
            allItems.Add(new DakotaDoubleBurger());
            allItems.Add(new TexasTripleBurger());
            allItems.Add(new PecosPulledPork());
            allItems.Add(new RustlersRibs());

            return entreeItems; 
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            sideItems.Add(new ChiliCheeseFries());
            sideItems.Add(new CornDodgers());
            sideItems.Add(new BakedBeans());
            sideItems.Add(new PanDeCampo());

            allItems.Add(new ChiliCheeseFries());
            allItems.Add(new CornDodgers());
            allItems.Add(new BakedBeans());
            allItems.Add(new PanDeCampo());

            return sideItems;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            drinkItems.Add(new JerkedSoda());
            drinkItems.Add(new CowboyCoffee());
            drinkItems.Add(new TexasTea());
            drinkItems.Add(new Water());

            allItems.Add(new JerkedSoda());
            allItems.Add(new CowboyCoffee());
            allItems.Add(new TexasTea());
            allItems.Add(new Water());

            return drinkItems;
        }

        public static IEnumerable<IOrderItem> All { get { return allItems; } }

    }
}
