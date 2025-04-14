using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Models.CarDTO;

namespace RegionalTaxiMVC.Services.Interfaces
{
    public interface ICarServices
    {
        Task<IEnumerable<Cars>> GetAllCarsAsync();
        Task CreateCarModel(CreateCarDTO createCarDTO);
    }
}
