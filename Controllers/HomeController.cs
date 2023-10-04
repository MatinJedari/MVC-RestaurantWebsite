using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantMVCPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVCPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Dish> _dishes = new List<Dish>
        {
            new Dish
            {
                DishName = "Dish1",
                DishImage = "menu-1.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "105$"
            },
            new Dish
            {
                DishName = "Dish2",
                DishImage = "menu-2.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "110$"
            },
            new Dish
            {
                DishName = "Dish3",
                DishImage = "menu-3.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "115$"
            },
            new Dish
            {
                DishName = "Dish4",
                DishImage = "menu-4.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "120$"
            },
            new Dish
            {
                DishName = "Dish5",
                DishImage = "menu-5.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "125$"
            },
            new Dish
            {
                DishName = "Dish6",
                DishImage = "menu-6.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "130$"
            },
            new Dish
            {
                DishName = "Dish7",
                DishImage = "menu-7.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "135$"
            },
            new Dish
            {
                DishName = "Dish8",
                DishImage = "menu-8.jpg",
                DishDescription = "lab lab lab lab ...",
                DishCost = "140$"
            }
        };


        private readonly List<Chef> _chefs = new List<Chef>
        {
            new Chef
            {
                FullName = "Mario Balotelli",
                Designation = "Junior Chef",
                Image = "team-1.jpg"
            },
            new Chef
            {
                FullName = "Marco Verratti",
                Designation = "Chef",
                Image = "team-2.jpg"
            },
            new Chef
            {
                FullName = "Gianluigi Donnarumma",
                Designation = "Chef",
                Image = "team-3.jpg"
            },
            new Chef
            {
                FullName = "Luciano Spalletti",
                Designation = "Chef master",
                Image = "team-4.jpg"
            }
        };


        private readonly List<Client> _clients = new List<Client>
        {
            new Client
            {
                ClientFullName = "Nicolò Zaniolo",
                ClientImage = "testimonial-1.jpg",
                ClientView = "lab lab lab ..."
            },
            new Client
            {
                ClientFullName = "Sandro Tonali",
                ClientImage = "testimonial-2.jpg",
                ClientView = "lab lab lab ..."
            },
            new Client
            {
                ClientFullName = "Ciro Immobile",
                ClientImage = "testimonial-3.jpg",
                ClientView = "lab lab lab ..."
            },
            new Client
            {
                ClientFullName = "Alessio Romagnoli",
                ClientImage = "testimonial-4.jpg",
                ClientView = "lab lab lab ..."
            },

        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.navTitle = "About Us";
            return View();
        }

        public IActionResult Menu()
        {
            ViewBag.navTitle = "Menu";
            return View(_dishes);
        }

        public IActionResult Booking()
        {
            ViewBag.navTitle = "Booking";
            return View();
        }

        public IActionResult Team()
        {
            ViewBag.navTitle = "Our Team";
            return View(_chefs);
        }

        public IActionResult Testimonial()
        {
            ViewBag.navTitle = "Testimonial";
            return View(_clients);
        }

        public IActionResult Contact()
        {
            ViewBag.navTitle = "Contact Us";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
