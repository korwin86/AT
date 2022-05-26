using AT.Models;
using Microsoft.EntityFrameworkCore;

namespace AT.Data
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<Device>? Devices { get; set; }
        public DbSet<Software>? Softwares { get; set; }
        public DbSet<Сomputer>? Сomputers { get; set; }
        public DbSet<OS>? OperatingSystems{ get; set; }
        public DbSet<PackageManager>? PackageManagers{ get; set; }
        public DbSet<Shell>? Shells{ get; set; }

        public SqliteDbContext()
        {

        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=.\\data.db");
    }
}
