using RegionalTaxiMVC.Models;

namespace RegionalTaxiMVC.Services.Interfaces
{
    public interface ICarServices
    {
        Task<IEnumerable<Cars>> GetAllCarsAsync();
    }
}
