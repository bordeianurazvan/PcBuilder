using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class CpuConfiguration: IEntityTypeConfiguration<Cpu>
    {
        public void Configure(EntityTypeBuilder<Cpu> builder)
        {
            ConfigureUtils.ProductConfigure(builder);
            builder.Property(c => c.Socket).IsRequired();
            builder.Property(c => c.RamFrequency).IsRequired();
            builder.Property(c => c.MaximumRamMemory).IsRequired();
            builder.Property(c => c.TypeOfRam).IsRequired();
            builder.Property(c => c.HasStockCooler).IsRequired();
        }
    }
}
