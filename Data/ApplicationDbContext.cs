using Microsoft.EntityFrameworkCore;
using VehicleRegistrationApp.Models;

namespace VehicleRegistrationApp.Data
{
    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    }
}
