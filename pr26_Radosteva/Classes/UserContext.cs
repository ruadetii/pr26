using Microsoft.EntityFrameworkCore;
using pr26_Radosteva.Classes.Common;
using pr26_Radosteva.Models;

namespace pr26_Radosteva.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connectionConfig, Config.version);
        }
    }
}
