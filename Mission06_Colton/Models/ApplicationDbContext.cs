
using Microsoft.EntityFrameworkCore;
namespace Mission06_Colton.Models
{
public class ApplicationDbContext : DbContext //DB context for the application
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }
}
}