using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
      
        // The items to be displayed on the screen
        public IEnumerable<IOrderItem> ItemsDisplayed { get; protected set; }

        // Minimum price
        [BindProperty]
        public double? PriceMin { get; set; }

        // Maximum price
        [BindProperty]
        public double? PriceMax { get; set; }

        // Minimum calories
        [BindProperty]
        public uint? CaloriesMin { get; set; }

        // Maximum calories
        [BindProperty]
        public uint? CaloriesMax { get; set; }

        // Whether the item is an entree, drink, or side
        [BindProperty]
        public string[] ItemType { get; set; }

        // The search terms 
        [BindProperty]
        public string SearchTerms { get; set; } = "";


        public void OnGet()
        {
            ItemsDisplayed = Menu.All;
        }
        
        public void OnPost()
        {
            ItemsDisplayed = Menu.Search(ItemsDisplayed, SearchTerms);
            ItemsDisplayed = Menu.FilterByCategory(ItemsDisplayed, ItemType);
            ItemsDisplayed = Menu.FilterByCalories(ItemsDisplayed, CaloriesMin, CaloriesMax);
            ItemsDisplayed = Menu.FilterByPrice(ItemsDisplayed, PriceMin, PriceMax);
        }
        
    }
}
