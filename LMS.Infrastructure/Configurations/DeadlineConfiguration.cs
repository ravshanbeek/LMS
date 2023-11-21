using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class DeadlineConfiguration : IEntityTypeConfiguration<Deadline>
    {
        public void Configure(EntityTypeBuilder<Deadline> builder)
        {
            builder.HasKey(dedline => dedline.Id);

            builder.Property(dedline => dedline.MaxGrade)
                .IsRequired();

            builder.Property(dedline => dedline.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Property(dedline => dedline.UpdatedAt)
                .IsRequired();

            builder.Property(dedline => dedline.ExpiredDate)
                .IsRequired();

            builder.HasMany(dedline => dedline.TaskGrades)
                .WithOne(taskGrade => taskGrade.Deadline)
                .HasForeignKey(taskGrade => taskGrade.DedlineId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
