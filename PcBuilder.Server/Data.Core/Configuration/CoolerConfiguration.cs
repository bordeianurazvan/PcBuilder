using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class CoolerConfiguration: IEntityTypeConfiguration<Cooler>
    {
        public void Configure(EntityTypeBuilder<Cooler> builder)
        {
            ConfigureUtils.ProductConfigure(builder);

            builder.Property(c => c.CompatibleSockets).IsRequired();
            builder.Property(c => c.Height).IsRequired();
        }
    }
}
