using Microsoft.EntityFrameworkCore;
using MvcDataApp.Models;

namespace MvcDataApp.Data;

public class FactoryManagerContext : DbContext
{

    public FactoryManagerContext(DbContextOptions<FactoryManagerContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Factory> Factories { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Shift> Shifts { get; set; }
}
