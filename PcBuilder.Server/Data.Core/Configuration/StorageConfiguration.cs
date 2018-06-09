using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class StorageConfiguration: IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            ConfigureUtils.ProductConfigure(builder);
            builder.Property(s => s.FormFactor).IsRequired();
            builder.Property(s => s.Interface).IsRequired();
        }
    }
}
