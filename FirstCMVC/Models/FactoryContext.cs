using Microsoft.EntityFrameworkCore;

namespace FirstCMVC.Models
{
    public class FactoryContext : DbContext
    {
        public FactoryContext()
        {
        }
        public FactoryContext(DbContextOptions<FactoryContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
