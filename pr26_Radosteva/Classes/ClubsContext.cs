using Microsoft.EntityFrameworkCore;
using pr26_Radosteva.Classes.Common;
using pr26_Radosteva.Models;

namespace pr26_Radosteva.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connectionConfig, Config.version);
        }
    }
}
