using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class SystemActivitieConfiguration : IEntityTypeConfiguration<SystemActivitie>
    {
        public void Configure(EntityTypeBuilder<SystemActivitie> builder)
        {
            builder.ToTable("SystemActivities");
            builder.HasKey(x => x.Id);
        }
    }
}
