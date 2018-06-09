using Data.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Core.Configuration
{
    public class PowerSupplyConfiguration: IEntityTypeConfiguration<PowerSupply>
    {
        public void Configure(EntityTypeBuilder<PowerSupply> builder)
        {
            ConfigureUtils.ProductConfigure(builder);
        }
    }
}
