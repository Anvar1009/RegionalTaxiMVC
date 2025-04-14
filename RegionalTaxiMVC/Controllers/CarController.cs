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

                return RedirectToAction("GetAllCar");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
             
        }
        public async Task< IActionResult> Edit(int id)
        {
            var car = await _carServices.GetByID(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
        [HttpPost]
        public async Task< IActionResult> Edit(Cars cars) 
        {
            try
            {
                if (cars == null)
                {
                    return NotFound();
                }

                await _carServices.Edit(cars);

                return RedirectToAction("GetAllCar");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
