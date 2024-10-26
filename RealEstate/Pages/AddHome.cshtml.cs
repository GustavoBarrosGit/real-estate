using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstate.Models;
using RealEstate.Services;

namespace RealEstate.Pages
{
    public class AddHomeModel : PageModel
    {
        private readonly HomeService _homeService;

        public AddHomeModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        [BindProperty]
        public Home NewHome { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            _homeService.AddHome(NewHome);
            return RedirectToPage("Index");
        }
    }
}
