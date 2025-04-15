using System.ComponentModel.DataAnnotations;
using RegionalTaxiMVC.Models.constants;

namespace RegionalTaxiMVC.Models.CarDTO
{
    public class CreateCarDTO
    {
        public string Name { get; set; }
        public DateOnly Birth_date { get; set; }
        public int Person_size { get; set; }
        public CarColor Car_color { get; set; }
        public ConditionsLevel condions { get; set; }
        public Modelss? Model { get; set; }
        public Brands Brand { get; set; }
        public int Price { get; set; }
        public string state_number { get; set; }
    }
}
