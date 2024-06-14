using KayakMeetupService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KayakMeetupService.Data;

public class MainContext : DbContext
{
    public MainContext(DbContextOptions<MainContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        UserTable(modelBuilder);
    }

    private static void UserTable(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<User>().Property(u => u.Address)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<User>().Property(u => u.State)
            .IsRequired()
            .HasMaxLength(15);
        modelBuilder.Entity<User>().Property(u => u.ZipCode)
            .IsRequired()
            .HasMaxLength(12);
        modelBuilder.Entity<User>().Property(u => u.GivenName)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.FamilyName)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(128);
        modelBuilder.Entity<User>().Property(u => u.DateOfBirth)
            .IsRequired();
        modelBuilder.Entity<User>().Property(u => u.Boat)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);
        modelBuilder.Entity<User>().Property(u => u.CityName)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.IsDeleted)
            .IsRequired();
        modelBuilder.Entity<User>().Property(u => u.UpdatedOn)
            .IsRequired();
        modelBuilder.Entity<User>().Property(u => u.CreatedOn)
            .IsRequired();
    }
}
