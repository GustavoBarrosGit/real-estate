using RealEstate.Models;

namespace RealEstate.Services
{
    public class HomeService
    {
        private List<Home> _homes;

        public HomeService() 
        {
            _homes = new List<Home>
            {
                new Home {Id = 1, Price = 300000, Address = "Rua das Flores, 123", Area = 120 },
                new Home {Id = 2, Price = 450000, Address = "Avenida da Liberdade, 456", Area = 150 },
                new Home {Id = 3, Price = 350000, Address = "Rua do Comércio, 789", Area = 130 },
                new Home {Id = 4, Price = 500000, Address = "Rua da Alegria, 101", Area = 160 },
                new Home {Id = 5, Price = 275000, Address = "Rua do Coração, 202", Area = 115 },
                new Home {Id = 6, Price = 600000, Address = "Avenida de Roma, 303", Area = 180 },
                new Home {Id = 7, Price = 320000, Address = "Rua da Paz, 404", Area = 140 },
                new Home {Id = 8, Price = 470000, Address = "Rua da Liberdade, 505", Area = 155 },
                new Home {Id = 9, Price = 380000, Address = "Rua da Esperança, 606", Area = 145 },
                new Home {Id = 10, Price = 420000, Address = "Rua das Olaias, 707", Area = 150 },
                new Home {Id = 11, Price = 310000, Address = "Rua do Sol, 808", Area = 135 },
                new Home {Id = 12, Price = 440000, Address = "Rua do Bairro Alto, 909", Area = 158 }
            };
        }

        public List<Home> GetHomes()
        {
            return _homes;
        }

        public void AddHome(Home home)
        {
            _homes.Add(home);
        }

        public Home GetHomeById(int id)
        {
            return _homes.Single(x => x.Id == id);
        }
    }
}
