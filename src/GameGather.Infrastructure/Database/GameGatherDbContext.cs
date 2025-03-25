using System.Reflection.Metadata;
using GameGather.Domain.Aggregates.Users;
using Microsoft.EntityFrameworkCore;

namespace GameGather.Infrastructure.Persistance;

public class GameGatherDbContext : DbContext
{
    public GameGatherDbContext(DbContextOptions<GameGatherDbContext> options) 
        : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(GameGatherDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}