using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Netflix.Domain.Models.Entities;

namespace Netflix.Domain.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(50);
            builder.Property(m => m.MaxDevices).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Price).IsRequired().HasMaxLength(50);


        }
    }
}
