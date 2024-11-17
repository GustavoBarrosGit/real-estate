using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstate.Models;
using RealEstate.Services;

namespace RealEstate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HomeService _homeService;
        public List<Home> Homes { get; private set; }

        public IndexModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        public void OnGet()
        {
            try
            {
                Homes = _homeService.GetHomes();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error fetching home from the database: {ex.Message}. Refresh the page.";
            }
        }
    }
}
