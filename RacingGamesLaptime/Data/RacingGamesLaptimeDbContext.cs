using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RacingGamesLaptime.Data;

public partial class RacingGamesLaptimeDbContext : DbContext
{
    public RacingGamesLaptimeDbContext()
    {
    }

    public RacingGamesLaptimeDbContext(DbContextOptions<RacingGamesLaptimeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Circuit> Circuits { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Laptime> Laptimes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=racing_games_laptime_db;user=root;password=wLgg4Da-AqBjtJ@4", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("car");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Brand)
                .HasMaxLength(45)
                .HasColumnName("brand");
            entity.Property(e => e.Category)
                .HasMaxLength(45)
                .HasColumnName("category");
            entity.Property(e => e.Engine)
                .HasMaxLength(45)
                .HasColumnName("engine");
            entity.Property(e => e.IsMod).HasColumnName("isMod");
            entity.Property(e => e.Model)
                .HasMaxLength(45)
                .HasColumnName("model");
            entity.Property(e => e.OriginCountry)
                .HasMaxLength(45)
                .HasColumnName("origin_country");
            entity.Property(e => e.Tyre)
                .HasMaxLength(45)
                .HasColumnName("tyre");
        });

        modelBuilder.Entity<Circuit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("circuit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Country)
                .HasMaxLength(45)
                .HasColumnName("country");
            entity.Property(e => e.IsMod).HasColumnName("isMod");
            entity.Property(e => e.Layout)
                .HasMaxLength(45)
                .HasColumnName("layout");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("game");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Platform)
                .HasMaxLength(45)
                .HasColumnName("platform");
            entity.Property(e => e.ReleaseYear).HasColumnName("release_year");
        });

        modelBuilder.Entity<Laptime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("laptime");

            entity.HasIndex(e => e.CarCategory, "car_category_idx");

            entity.HasIndex(e => e.Car, "car_idx");

            entity.HasIndex(e => e.Circuit, "circuit_idx");

            entity.HasIndex(e => e.GameName, "game_name_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Car).HasColumnName("car");
            entity.Property(e => e.CarCategory)
                .HasMaxLength(45)
                .HasColumnName("car_category");
            entity.Property(e => e.Circuit).HasColumnName("circuit");
            entity.Property(e => e.GameName).HasColumnName("game_name");
            entity.Property(e => e.Time).HasColumnName("time");

            entity.HasOne(d => d.CarNavigation).WithMany(p => p.Laptimes)
                .HasForeignKey(d => d.Car)
                .HasConstraintName("car");

            entity.HasOne(d => d.CircuitNavigation).WithMany(p => p.Laptimes)
                .HasForeignKey(d => d.Circuit)
                .HasConstraintName("circuit");

            entity.HasOne(d => d.GameNameNavigation).WithMany(p => p.Laptimes)
                .HasForeignKey(d => d.GameName)
                .HasConstraintName("game_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
