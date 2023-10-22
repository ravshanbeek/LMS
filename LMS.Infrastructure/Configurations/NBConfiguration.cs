using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class NBConfiguration : IEntityTypeConfiguration<NB>
    {
        public void Configure(EntityTypeBuilder<NB> builder)
        {
            builder.HasKey(nb => nb.Id);

            builder.Property(nb => nb.IsAvailable)
                .HasDefaultValue(true);
        }
    }
}
