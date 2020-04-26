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
        
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> list, string terms)
        {
            List<IOrderItem> items = new List<IOrderItem>();

            if (terms == null) { return All; }

            // search through all menu items for a match to the search
            foreach(IOrderItem menuItem in All)
            {
                if (menuItem.ToString() != null && menuItem.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    items.Add(menuItem);
                }
            }

            // if no search results are found, return the whole menu
            if (items.Count == 0)
            {
                return All;
            }

            // if results are found, return the results of the search
            else
            {
                return items;
            }
        }
        


        /// <summary>
        /// The possible types of the menu item
        /// </summary>
        public static string[] ItemType
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// </summary>
        /// <param name="list"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> typeFilter)
        {
            if (typeFilter == null || typeFilter.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in items)
            {
                if (typeFilter.Equals("Entree"))
                {
                    foreach (IOrderItem i in Entrees())
                    {
                        results.Add(i);
                    }
                }
                else if (typeFilter.Equals("Drink"))
                {
                    foreach (IOrderItem i in Drinks())
                    {
                        results.Add(i);
                    }
                }
                else if (typeFilter.Equals("Sides"))
                {
                    foreach (IOrderItem i in Sides())
                    {
                        results.Add(i);
                    }
                }
            }
            
            return results;
        }




        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories <= max) results.Add(i);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories >= min) results.Add(i);
                }
                return results;
            }

            foreach (IOrderItem i in items)
            {
                if (i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }


        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Price <= max) results.Add(i);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Price >= min) results.Add(i);
                }
                return results;
            }

            foreach (IOrderItem i in items)
            {
                if (i.Price >= min && i.Price <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }


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

            return entreeItems; 
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            sideItems.Add(new ChiliCheeseFries());
            sideItems.Add(new CornDodgers());
            sideItems.Add(new BakedBeans());
            sideItems.Add(new PanDeCampo());
           
            return sideItems;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            drinkItems.Add(new JerkedSoda());
            drinkItems.Add(new CowboyCoffee());
            drinkItems.Add(new TexasTea());
            drinkItems.Add(new Water());

            return drinkItems;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            allItems.Add(new CowpokeChili());
            allItems.Add(new AngryChicken());
            allItems.Add(new TrailBurger());
            allItems.Add(new DakotaDoubleBurger());
            allItems.Add(new TexasTripleBurger());
            allItems.Add(new PecosPulledPork());
            allItems.Add(new RustlersRibs());

            allItems.Add(new ChiliCheeseFries());
            allItems.Add(new CornDodgers());
            allItems.Add(new BakedBeans());
            allItems.Add(new PanDeCampo());

            allItems.Add(new JerkedSoda());
            allItems.Add(new CowboyCoffee());
            allItems.Add(new TexasTea());
            allItems.Add(new Water());

            return allItems;
        }

        private static IEnumerable<IOrderItem> all = CompleteMenu();
        public static IEnumerable<IOrderItem> All
        {
            get
            {
                return all;
            }
            set
            {
                all = value;
            }
        }

    }
}
