using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstate.Models;
using RealEstate.Services;

namespace RealEstate.Pages
{
    public class HomeDetailModel : PageModel
    {
        private readonly HomeService _homeService;

        public HomeDetailModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        public Home Home { get; set; }

        public IActionResult OnGet(int id)
        {
            Home = GetHomeById(id);
            return Page();
        }

        private Home GetHomeById(int id)
        {
            return _homeService.GetHomeById(id);
        }
    }
}