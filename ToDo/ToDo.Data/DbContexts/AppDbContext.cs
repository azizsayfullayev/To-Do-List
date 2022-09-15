using ToDo.Domain.Constants;
using ToDo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ToDo.Data.DbContexts;

public class AppDbContext : DbContext
{
    public virtual DbSet<Card> Cards { get; set; } = null!;
    public virtual DbSet<Comment> Comments { get; set; } = null!;
    public virtual DbSet<Desk> Desks { get; set; } = null!;
    public virtual DbSet<DeskCard> DeskCards { get; set; } = null!;
    public virtual DbSet<Status> Statuses{ get; set; } = null!;
    public virtual DbSet<StatusCard> StatusCards{ get; set; } = null!;
    public virtual DbSet<Team> Teams{ get; set; } = null!;
    public virtual DbSet<TeamMember> TeamMembers { get; set; } = null!;
    public virtual DbSet<User> Users { get; set; } = null!;



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(DbConstants.CONNECTION_STRING);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>().HasKey(x => x.Id);
        modelBuilder.Entity<Comment>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasKey(x => x.Id);
        modelBuilder.Entity<Status>().HasKey(x => x.Id);
        modelBuilder.Entity<Team>().HasKey(x => x.Id);
        modelBuilder.Entity<Desk>().HasKey(x => x.Id);
        modelBuilder.Entity<DeskCard>().HasNoKey();
        modelBuilder.Entity<StatusCard>().HasNoKey();
        modelBuilder.Entity<TeamMember>().HasNoKey();

    }
}
