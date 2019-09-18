using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Car abigail = new Car{
                Manufacturer = "Chevy",
                CarModel = "Corvette",
                NameOfCar = "Abigail",
                VehicleID = "70421"
            };
            Car cardi = new Car
            {
                Manufacturer = "Toyota",
                CarModel = "GT86",
                NameOfCar = "Cardi",
                VehicleID = "68419"
            };
            Car lucy = new Car
            {
                Manufacturer = "Ford",
                CarModel = "Galaxie",
                NameOfCar = "Lucy",
                VehicleID = "niceDude"
            };
            Car rental = new Car
            {
                Manufacturer = "Nissan",
                CarModel = "Sentra"
            };

            Car[] cars = { abigail, cardi, lucy, rental };

            return View(cars);
        }

        public IActionResult CarDetail()
        {
            Car lucy = new Car
            {
                Manufacturer = "Ford",
                CarModel = "Galaxie",
                NameOfCar = "Lucy",
                VehicleID = "niceDude",
                Year = 1965,
                Color = "Black"                
            };
            return View(lucy);
        }
    }
}