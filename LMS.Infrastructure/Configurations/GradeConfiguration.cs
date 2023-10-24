using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(grade => grade.Id);

            builder.Property(grade => grade.CreatedAt)
             .HasDefaultValue(DateTime.Now);

            builder.Property(grade => grade.UpdatedAt)
                .IsRequired();

            builder.Property(grade => grade.DedlineId)
                .IsRequired();

            builder.Property(grade => grade.StudentId)
                .IsRequired();

            builder.Property(grade => grade.GradeValue)
                .HasDefaultValue(0);
        }
    }
}
