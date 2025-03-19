using RegionalTaxiMVC.Models;

namespace RegionalTaxiMVC.Services.Interfaces
{
    public interface ICarServices
    {
        Task<List<Cars>> GetAllCarsAsync();
    }
}
