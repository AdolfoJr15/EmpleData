using EmployeeData.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpleData.Models
{
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
            { }
            public DbSet<Employee> employee { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql("Server=localhost;Database=EmpleData;User=root;Password = cristiantiquet18; port=3306",
                new MySqlServerVersion(new Version(8, 0, 23)));
                }
            }
        }
}
