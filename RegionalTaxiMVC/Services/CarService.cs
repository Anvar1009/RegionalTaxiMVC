using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Models.CarDTO;
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

        public  Task CreateCarModel(CreateCarDTO createCarDTO)
        {
            var CarModel = new Cars
            {
                Name = createCarDTO.Name,
                Birth_date = createCarDTO.Birth_date,
                Brand = createCarDTO.Brand,
                Car_color = createCarDTO.Car_color,
                Person_size = createCarDTO.Person_size, 
                Price = createCarDTO.Price, 
                condions = createCarDTO.condions,
                state_number = createCarDTO.state_number

            };

            var result =  _carRepository.Add(CarModel);

            return Task.CompletedTask;  
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


        public async Task<Cars> GetByID(int id)
        {
            try
            {
                var result = await _carRepository.GetById(id, cancellationToken: default);
                return result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Edit(Cars car)
        {
            try
            {
                await _carRepository.Update(car, cancellationToken: default);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(Cars cars)
        {
            try
            {
                await _carRepository.Remove(cars);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
