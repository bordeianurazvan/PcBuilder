using Data.Core.Configuration;
using Data.Core.Domain;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public sealed class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CaseConfiguration());
            modelBuilder.ApplyConfiguration(new CpuConfiguration());
            modelBuilder.ApplyConfiguration(new CoolerConfiguration());
            modelBuilder.ApplyConfiguration(new MotherboardConfiguration());
            modelBuilder.ApplyConfiguration(new RamConfiguration());
            modelBuilder.ApplyConfiguration(new VideoCardConfiguration());
            modelBuilder.ApplyConfiguration(new StorageConfiguration());
            modelBuilder.ApplyConfiguration(new PowerSupplyConfiguration());
        }
    }
}
