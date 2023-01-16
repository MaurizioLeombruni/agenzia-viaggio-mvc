using Microsoft.EntityFrameworkCore;
using AgenziaViaggioMVC.Models;

namespace AgenziaViaggioMVC.Database
{
    public class TravelContext : DbContext
    {
        public DbSet<Travel> Travels { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Database = TravelAgencyV1; " + "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
