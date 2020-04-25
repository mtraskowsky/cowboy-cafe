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
        public string SearchTerms { get; set; } = "";


        public void OnGet()
        {
            ItemsDisplayed = Menu.All;
        }
        
        public void OnPost()
        {
            ItemsDisplayed = Menu.Search(ItemsDisplayed, SearchTerms);
        }
        
    }
}
