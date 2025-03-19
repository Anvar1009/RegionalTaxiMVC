using RegionalTaxiMVC.Repositories.Interfaces;

namespace RegionalTaxiMVC.Models
{
    public class Modelss:IEntity<int>
    {
        public int Id { get; init; }
        public string Name { get; set; }
    }
}
