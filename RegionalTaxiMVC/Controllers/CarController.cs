using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> GetAllCar()
        {
            var result = await _carServices.GetAllCarsAsync();
            return View(result);
        }
    }
}
