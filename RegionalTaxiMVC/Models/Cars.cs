using System.ComponentModel.DataAnnotations;

namespace RegionalTaxiMVC.Models
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public DateOnly Birth_date { get; set; }
        public int Person_size { get; set; }
        public string Car_color { get; set; }
        public ConditionsLevel condions { get; set; }
        public int Model_Id { get; set; }
        public Modelss Model { get; set; }
        public int Brand_Id { get; set; }
        public Brands Brand { get; set; }
        public int Price { get; set; }
    }
}
