using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class MotherboardConfiguration: IEntityTypeConfiguration<Motherboard>
    {
        public void Configure(EntityTypeBuilder<Motherboard> builder)
        {
            ConfigureUtils.ProductConfigure(builder);
            builder.Property(m => m.FormFactor).IsRequired();
            builder.Property(m => m.GraphicInterface).IsRequired();
            builder.Property(m => m.M2).IsRequired();
            builder.Property(m => m.MaximumRamMemory).IsRequired();
            builder.Property(m => m.RamFrequency).IsRequired();
            builder.Property(m => m.RamSlots).IsRequired();
            builder.Property(m => m.TypeOfRam).IsRequired();
            builder.Property(m => m.Socket).IsRequired();
            builder.Property(m => m.Sata).IsRequired();
        }
    }
}
