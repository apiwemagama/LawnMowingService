using LawnMowingService.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Machine> Machines { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Operator> Operators { get; set; }
}
