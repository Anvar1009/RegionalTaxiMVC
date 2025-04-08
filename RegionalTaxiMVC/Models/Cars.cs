using System.ComponentModel.DataAnnotations;
using RegionalTaxiMVC.Repositories.Interfaces;

namespace RegionalTaxiMVC.Models
{
    public class Cars:IEntity<int>
    {
        [Key]
        public int Id { get; init; }
        public string Name { get; set; }    
        public DateOnly Birth_date { get; set; }
        public int Person_size { get; set; }
        public string Car_color { get; set; }
        public ConditionsLevel condions { get; set; }
        public Modelss? Model { get; set; }
        public Brands? Brand { get; set; }
        public int Price { get; set; }
        public string state_number { get; set; }
    }
}
