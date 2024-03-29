using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using KayakMeetUpService.Abstractions.Models;
using KayakMeetUpService.Data.Models;
using FishingTournamentEvent = KayakMeetUpService.Data.Models.FishingTournamentEvent;
using RaceEvent = KayakMeetUpService.Data.Models.RaceEvent;
using User = KayakMeetUpService.Data.Models.User;
using CasualMeetUpEvent = KayakMeetUpService.Data.Models.CasualMeetUpEvent;

namespace KayakMeetUpService.Data;

public class MainContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RaceEvent> RaceEvents { get; set; }
    public DbSet<FishingTournamentEvent> FishingTournamentEvents { get; set; }
    public DbSet<CasualMeetUpEvent> CasualMeetUpEvents { get; set; }


    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        UserTable(modelBuilder);
        CasualMeetUpEventTable(modelBuilder);
        FishingTournamentEventTable(modelBuilder);
        RaceEventTable(modelBuilder);
    }

    private static void RaceEventTable(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RaceEvent>().ToTable("RaceEvent");
        modelBuilder.Entity<RaceEvent>().HasKey(re => re.Id);
        modelBuilder.Entity<RaceEvent>().Property(re => re.CityName)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<RaceEvent>().Property(re => re.Address)
           .IsRequired()
           .HasMaxLength(95);
        modelBuilder.Entity<RaceEvent>().Property(re => re.EventName)
           .IsRequired()
           .HasMaxLength(95);
        modelBuilder.Entity<RaceEvent>().Property(re => re.State)
            .IsRequired()
            .HasMaxLength(15);
        modelBuilder.Entity<RaceEvent>().Property(re => re.ZipCode)
            .IsRequired()
            .HasMaxLength(12);
        modelBuilder.Entity<RaceEvent>().Property(re => re.Country)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<RaceEvent>().Property(re => re.PrizePool)
            .IsRequired()
            .HasMaxLength(10);

    }

    private static void FishingTournamentEventTable(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FishingTournamentEvent>().ToTable("FishingTournamentEvent");
        modelBuilder.Entity<FishingTournamentEvent>().HasKey(ft => ft.Id);
        modelBuilder.Entity<FishingTournamentEvent>().Property(ft => ft.CityName)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<FishingTournamentEvent>().Property(ft => ft.EventName)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<FishingTournamentEvent>().Property(ft => ft.Address)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<FishingTournamentEvent>().Property(ft => ft.State)
            .IsRequired()
            .HasMaxLength(15);
        modelBuilder.Entity<FishingTournamentEvent>().Property(ft => ft.ZipCode)
            .IsRequired()
            .HasMaxLength(12);
        modelBuilder.Entity<FishingTournamentEvent>().Property(ft => ft.Country)
            .IsRequired()
            .HasMaxLength(50);
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
    }

    private static void CasualMeetUpEventTable(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CasualMeetUpEvent>().ToTable("CasualMeetUpEvent");
        modelBuilder.Entity<CasualMeetUpEvent>().HasKey(cm => cm.Id);
        modelBuilder.Entity<CasualMeetUpEvent>().Property(cm => cm.Address)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<CasualMeetUpEvent>().Property(cm => cm.EventName)
            .IsRequired()
            .HasMaxLength(95);
        modelBuilder.Entity<CasualMeetUpEvent>().Property(cm => cm.State)
            .IsRequired()
            .HasMaxLength(15);
        modelBuilder.Entity<CasualMeetUpEvent>().Property(cm => cm.ZipCode)
            .IsRequired()
            .HasMaxLength(12);
        modelBuilder.Entity<CasualMeetUpEvent>().Property(cm => cm.Country)
            .IsRequired()
            .HasMaxLength(50);
    }



}
