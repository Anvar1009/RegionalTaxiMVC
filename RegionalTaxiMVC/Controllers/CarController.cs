using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Services.Interfaces;

namespace RegionalTaxiMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarServices _carServices;
        public CarController(ICarServices carServices)
        {
            _carServices = carServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCar()
        {
            var result = await _carServices.GetAllCarsAsync();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cars car)
        {
           
            return View(car); 
        }
    }
}
