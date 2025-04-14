using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Models.CarDTO;

namespace RegionalTaxiMVC.Services.Interfaces
{
    public interface ICarServices
    {
        Task<IEnumerable<Cars>> GetAllCarsAsync();
        Task CreateCarModel(CreateCarDTO createCarDTO);
        Task Edit(Cars car);
        Task Delete(Cars cars);
        Task<Cars> GetByID(int id);
    }
}
