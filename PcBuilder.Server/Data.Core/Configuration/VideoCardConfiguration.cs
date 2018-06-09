using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class VideoCardConfiguration: IEntityTypeConfiguration<VideoCard>
    {
        public void Configure(EntityTypeBuilder<VideoCard> builder)
        {
            ConfigureUtils.ProductConfigure(builder);
            builder.Property(v => v.Interface).IsRequired();
            builder.Property(v => v.Width).IsRequired();
        }
    }
}
