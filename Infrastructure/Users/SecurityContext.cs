using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class SecurityContext : DbContext
{
    public SecurityContext(DbContextOptions contextOptions) : base(contextOptions)
    {
    }

    public DbSet<User> Users { get; set; }
}