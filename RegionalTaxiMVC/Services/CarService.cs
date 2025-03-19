using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Repositories.Interfaces;
using RegionalTaxiMVC.Services.Interfaces;

namespace RegionalTaxiMVC.Services
{
    public class CarService : ICarServices
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<List<Cars>> GetAllCarsAsync()
        {
            try
            {
                var result = _carRepository.GetAll(tracked:true);   
                var cars = new List<Cars>();
                cars= result.ToList();  
                return cars;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
