using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class CaseConfiguration: IEntityTypeConfiguration<Case>
    {
        public void Configure(EntityTypeBuilder<Case> builder)
        {
            ConfigureUtils.ProductConfigure(builder);

            builder.Property(c => c.MotherBoardFormFactor).IsRequired();
            builder.Property(c => c.CoolerHeight).IsRequired();
            builder.Property(c => c.VideoCardWidth).IsRequired();
            builder.Property(c => c.NumberOfSlots).IsRequired();
        }
    }
}
