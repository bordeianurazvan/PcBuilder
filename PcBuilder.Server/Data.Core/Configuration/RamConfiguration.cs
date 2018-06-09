using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class RamConfiguration: IEntityTypeConfiguration<Ram>
    {
        public void Configure(EntityTypeBuilder<Ram> builder)
        {
            ConfigureUtils.ProductConfigure(builder);
            builder.Property(r => r.Capacity).IsRequired();
            builder.Property(r => r.Frequency).IsRequired();
            builder.Property(r => r.Type).IsRequired();
        }
    }
}
