using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstate.Models;

namespace RealEstate.Pages
{
    public class IndexModel : PageModel
    {
        public List<Home> Homes { get; private set; }
        public double ThresholdPrice { get; set; }

        public void OnGet()
        {
            Homes = new List<Home>
            {
            new Home { Price = 300000, Address = "Rua das Flores, 123", Area = 120 },
            new Home { Price = 450000, Address = "Avenida da Liberdade, 456", Area = 150 },
            new Home { Price = 350000, Address = "Rua do Comércio, 789", Area = 130 },
            new Home { Price = 500000, Address = "Rua da Alegria, 101", Area = 160 },
            new Home { Price = 275000, Address = "Rua do Coração, 202", Area = 115 },
            new Home { Price = 600000, Address = "Avenida de Roma, 303", Area = 180 },
            new Home { Price = 320000, Address = "Rua da Paz, 404", Area = 140 },
            new Home { Price = 470000, Address = "Rua da Liberdade, 505", Area = 155 },
            new Home { Price = 380000, Address = "Rua da Esperança, 606", Area = 145 },
            new Home { Price = 420000, Address = "Rua das Olaias, 707", Area = 150 },
            new Home { Price = 310000, Address = "Rua do Sol, 808", Area = 135 },
            new Home { Price = 440000, Address = "Rua do Bairro Alto, 909", Area = 158 }
            };

            ThresholdPrice = 400000;
        }
    }
}
