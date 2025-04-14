using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Models.CarDTO;
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
        public IActionResult Create(CreateCarDTO car)
        {
            try
            {
                var result = _carServices.CreateCarModel(car);

                return View("Create");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
             
        }
        public IActionResult Edit(int id)
        {
            return View("Edit");
        }
        [HttpPost]
        public IActionResult Edit(Cars cars) 
        {
            try
            {
                return View("GetAllCar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
