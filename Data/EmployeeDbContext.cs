#nullable disable
using Microsoft.EntityFrameworkCore;
using EFCoreDB.Model;

    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
