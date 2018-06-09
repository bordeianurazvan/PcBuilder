using Data.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public sealed class ConfigureUtils
    {
        public static void ProductConfigure<T>(EntityTypeBuilder<T> builder) where T: class, IProduct
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title).HasMaxLength(255).IsRequired();
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.ImageUrl).IsRequired();
        }
    }
}