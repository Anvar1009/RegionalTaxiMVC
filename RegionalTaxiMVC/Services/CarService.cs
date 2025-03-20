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
        public async Task<IEnumerable<Cars>> GetAllCarsAsync()
        {
            try
            {
                var result = _carRepository.GetAll(tracked:true,ignoreQueryFilters:false);   
                
                return result;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
