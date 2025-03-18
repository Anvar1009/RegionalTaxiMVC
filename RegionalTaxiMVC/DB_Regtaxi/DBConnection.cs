using Microsoft.EntityFrameworkCore;
using RegionalTaxiMVC.Models;

namespace RegionalTaxiMVC.DB_Regtaxi
{
    public class DBConnection:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; User id=postgres; Database=RegtaxiMVC; Password=anvar1009; Include Error Detail=true;");
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Modelss> modelsses { get; set; }
        public DbSet<Brands> brands { get; set; }   
    }
}
