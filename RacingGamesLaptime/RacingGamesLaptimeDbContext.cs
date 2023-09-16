using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using RacingGamesLaptime.Models;

namespace RacingGamesLaptime
{
    public class RacingGamesLaptimeDbContext : DbContext
    {
        public virtual DbSet<Car> Car { get; set; }

        public virtual DbSet<Circuit> Circuit { get; set; }

        public virtual DbSet<Game> Game { get; set; }

        public virtual DbSet<Laptime> Laptime { get; set; }

        public RacingGamesLaptimeDbContext(DbContextOptions<RacingGamesLaptimeDbContext> dbContextOptions) : base(dbContextOptions)
        {
            try 
            {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null) 
                {
                    // Create Database if cannot connect
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();

                    // Create Tables if no tables exist
                    if(!databaseCreator.HasTables()) databaseCreator.CreateTables();
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
