using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RegionalTaxiMVC.Models;

namespace RegionalTaxiMVC.DB_Regtaxi
{
    public class RegTaxiDBContext(DbContextOptions options):DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; User id=postgres; Database=RegtaxiMVC; Password=anvar1009; Include Error Detail=true;");
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Modelss> modelsses { get; set; }
    }
    public class RegTaxiDBContextFactory : IDesignTimeDbContextFactory<RegTaxiDBContext>
    {
        public RegTaxiDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RegTaxiDBContext>();
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; User id=postgres; Database=RegtaxiMVC; Password=anvar1009; Include Error Detail=true;");

            return new RegTaxiDBContext(optionsBuilder.Options);
        }
    }
}
