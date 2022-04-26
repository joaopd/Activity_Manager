using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");

            builder.HasIndex(x => x.Id).IsUnique();
            builder.HasKey(x => x.Number);
            builder.Property(x => x.Description).HasColumnType("varchar(250)");
            builder.Property(x => x.Title).HasColumnType("varchar(100)");
        }
    }
}
