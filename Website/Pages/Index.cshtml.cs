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
        /*
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        */

        public IEnumerable<IOrderItem> ItemsDisplayed { get; protected set; }

        [BindProperty]
        public double? PriceMin { get; set; }

        [BindProperty]
        public double? PriceMax { get; set; }

        [BindProperty]
        public uint? CaloriesMin { get; set; }

        [BindProperty]
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// Whether the item is an entree, drink, or side
        /// </summary>
        [BindProperty]
        public string[] ItemType { get; set; }


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
