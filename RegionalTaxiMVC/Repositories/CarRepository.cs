using RegionalTaxiMVC.DB_Regtaxi;
using RegionalTaxiMVC.Models;
using RegionalTaxiMVC.Repositories.Interfaces;

namespace RegionalTaxiMVC.Repositories;

public class CarRepository(RegTaxiDBContext dBConnection) : Repository<Cars, int>(dBConnection),ICarRepository;

